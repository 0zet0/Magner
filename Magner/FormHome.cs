using AForge.Video;
using AForge.Video.DirectShow;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Magner
{
    public partial class FormHome : MaterialForm
    {

        private string orgImagePath = null;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private Image[] croppedImageList = new Image[2];
        private bool isShowFrontSide = true;
        private string frontSideImagePath = "";
        private string backSideImagePath = "";

        private FormRecognize formRecognize = new FormRecognize();
        public FormHome()
        {
            InitializeComponent();
            getListCameraUSB();
            DeleteImage();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png;*.gif;*.tif";
            isFrontSide.Checked = true;
            rbNewPassport.Checked = true;
            cropper.Threshold1 = trackBar1.Value;
            cropper.Threshold2 = trackBar2.Value;
        }
        private string GetNameCheckedRadioButton()
        {
            MaterialRadioButton radioButton = new MaterialRadioButton();
            foreach (var rb in tbpRadioButtonList.Controls)
            {
                radioButton = (MaterialRadioButton)rb;
                if (radioButton.Checked)
                    break;
            }
            return radioButton.Name;
        }
        private void DeleteImage()
        {
            var process = Process.GetProcessesByName("Magner");
            if (process.Length == 1)
            {
                //var files = Directory.GetFiles("image");
                //foreach (var f in files)
                //    File.Delete(f);
            }
        }
        private Image ReadXml(string path, Image img)
        {
            XmlSerializer reader = new XmlSerializer(typeof(DocType));
            StreamReader file = new StreamReader(path);
            DocType doc = (DocType)reader.Deserialize(file);
            string[] cord;
            int x, y, w, h;
            foreach (var el in doc.Cordinate)
            {
                cord = el.Split(' ');
                x = Convert.ToInt32(cord[0]);
                y = Convert.ToInt32(cord[1]);
                w = Convert.ToInt32(cord[2]);
                h = Convert.ToInt32(cord[3]);
                x = (img.Width * x) / 679;
                y = (img.Height * y) / 386;
                w = (img.Width * w) / 679;
                h = (img.Height * h) / 386;
                img = DrawBox(img, x, y, w, h);
            }
            file.Close();
            return img;
        }
        private Image DrawBox(Image image, int x, int y, int w, int h)
        {
            Pen pen = new Pen(Color.Green, 3);
            Graphics g = Graphics.FromImage(image);
            Bitmap targetBitmap = new Bitmap(w, h);
            Graphics g2 = Graphics.FromImage(targetBitmap);
            g2.DrawImage(image, new Rectangle(0, 0, w, h),
                new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
            var localData = LocalData.GetBox(targetBitmap);
            if (localData != null && localData.Height != 0)
                g.DrawRectangle(pen, x + localData.X - 3, y + localData.Y - 3, localData.Width + 6, localData.Height + 6);
            else
                g.DrawRectangle(pen, x, y, w, h);
            g.Dispose();
            pen.Dispose();
            return image;
        }
        private Image GetCroppedImage(string path)
        {
            using (var croped = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
            {
                Image image = Image.FromStream(croped);
                croped.Close();
                return image;
            }
        }
        private void ShowImagViewer(string pathXML, string pathImage)
        {
            if (!File.Exists(pathImage) || !File.Exists(pathXML))
                return;
            ImageViewer imageViewer = new ImageViewer();
            imageViewer.FormClosed += new FormClosedEventHandler(this.ImageViewer_FormClosed);
            imageViewer.pathImage = pathImage;
            imageViewer.pathXML = pathXML;
            imageViewer.ShowDialog();
            imageViewer.Dispose();
        }
        private void darckLiteTheme_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (darckLiteTheme.Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        #region webcam
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] snapshotCapabilities;
        private ArrayList listCamera = new ArrayList();
        public string pathFolder = Application.StartupPath + @"\ImageCapture\";
        private Stopwatch stopWatch;
        private static bool needSnapshot = false;
        private static string _usbcamera;
        Cropper cropper = new Cropper();

        public string usbcamera
        {
            get { return _usbcamera; }
            set { _usbcamera = value; }
        }

        #region Open Scan Camera
        private void OpenCamera()
        {
            try
            {
                usbcamera = comboBox1.SelectedIndex.ToString();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count != 0)
                    foreach (FilterInfo device in videoDevices)// add all devices to combo
                        listCamera.Add(device.Name);
                videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(usbcamera)].MonikerString);
                videoDevice.DisplayPropertyPage(IntPtr.Zero);
                snapshotCapabilities = videoDevice.SnapshotCapabilities;
                OpenVideoSource(videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        #endregion
        public delegate void CaptureSnapshotManifast(Bitmap image);
        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                CloseCurrentVideoSource();
                videoSourcePlayer1.VideoSource = source;
                videoSourcePlayer1.Start();
                stopWatch = null;
                this.Cursor = Cursors.Default;
            }
            catch { }
        }
        private void getListCameraUSB()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count != 0)
                foreach (FilterInfo device in videoDevices)
                    comboBox1.Items.Add(device.Name);
            //comboBox1.SelectedIndex = 0;
        }

        public void CloseCurrentVideoSource()
        {
            try
            {
                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();
                    for (int i = 0; i < 30; i++)
                    {
                        if (!videoSourcePlayer1.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }
                    if (videoSourcePlayer1.IsRunning)
                        videoSourcePlayer1.Stop();
                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch { }
        }
        private void videoSourcePlayer1_NewFrame_1(object sender, ref Bitmap image)
        {
            try
            {
                if (needSnapshot)
                {
                    needSnapshot = false;
                    orgImagePath = "image/orgImagePath.jpg";
                    image.Save(orgImagePath);
                    showImage.Image = cropper.GetDrawContours(orgImagePath);
                }
            }
            catch { }
        }
        private void btnWebcam_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSourcePlayer1.IsRunning)
                {
                    CloseCurrentVideoSource();
                    btnWebcam.Text = "Запустить Веб-камеру";
                }
                else
                {
                    OpenCamera();
                    btnWebcam.Text = "Остановить Веб-камеру";
                }
            }
            catch { }
        }
        private void btnSnapshoot_Click(object sender, EventArgs e) => needSnapshot = true;
        #endregion

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                cropper.Threshold1 = trackBar1.Value;
                cropper.Threshold2 = trackBar2.Value;
                showImage.Image = cropper.GetDrawContours(orgImagePath);
            }
            catch { }
        }


        private void btnCropImage_Click(object sender, EventArgs e)
        {
            string path = "image/" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            if (orgImagePath == null) return;
            string pathXML;
            if (isFrontSide.Checked)
            {
                pathXML = "xml/Front" + this.GetNameCheckedRadioButton() + ".xml";
                if (!File.Exists(pathXML))
                    return;
                cropper.CropImage(orgImagePath, path);
                FormRecognize.frontSideImagePath = path;
                if (File.Exists(frontSideImagePath))
                    File.Delete(frontSideImagePath);
                frontSideImagePath = path;
                picFrontSide.Image = ReadXml(pathXML, cropper.GetFinalImage());
                croppedImageList[0] = GetCroppedImage(path);
            }
            else
            {
                pathXML = "xml/Back" + this.GetNameCheckedRadioButton() + ".xml";
                if (!File.Exists(pathXML))
                    return;
                cropper.CropImage(orgImagePath, path);
                FormRecognize.backSideImagePath = path;
                if (File.Exists(backSideImagePath))
                    File.Delete(backSideImagePath);
                backSideImagePath = path;
                picBackSide.Image = ReadXml(pathXML, cropper.GetFinalImage());
                croppedImageList[1] = GetCroppedImage(path);
            }
            formRecognize.Close();
        }
        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHomeClose();
        }
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                cropper.Threshold1 = trackBar1.Value;
                cropper.Threshold2 = trackBar2.Value;
                orgImagePath = openFileDialog.FileName;
                showImage.Image = cropper.GetDrawContours(orgImagePath);
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            formRecognize.Close();
            formRecognize = new FormRecognize();
            if (picBackSide.Image == null && picFrontSide.Image == null)
                return;
            if (picBackSide.Image != null)
                formRecognize.rbName[1] = "xml/Back" + GetNameCheckedRadioButton() + ".xml";
            if (picFrontSide.Image != null)
                formRecognize.rbName[0] = "xml/Front" + GetNameCheckedRadioButton() + ".xml";
            formRecognize.picFrontSide.Image = croppedImageList[0];
            formRecognize.picBackSide.Image = croppedImageList[1];
            formRecognize.Show();
        }
        private void rbChanged_CheckedChanged(object sender, EventArgs e)
        {
            picBackSide.Image = null;
            picFrontSide.Image = null;
            croppedImageList[0] = null;
            croppedImageList[1] = null;
            if (File.Exists(backSideImagePath))
                File.Delete(backSideImagePath);
            if (File.Exists(frontSideImagePath))
                File.Delete(frontSideImagePath);
            isFrontSide.Checked = true;
            isBackSide.Checked = false;
            formRecognize.Close();
        }
        private void picFrontSide_Click(object sender, EventArgs e)
        {
            if (picFrontSide.Image == null) return;
            isShowFrontSide = true;
            ShowImagViewer("xml/Front" + GetNameCheckedRadioButton() + ".xml", frontSideImagePath);
        }
        private void picBackSide_Click(object sender, EventArgs e)
        {
            if (picBackSide.Image == null) return;
            isShowFrontSide = false;
            ShowImagViewer("xml/Back" + GetNameCheckedRadioButton() + ".xml", backSideImagePath);
        }
        private void ImageViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isShowFrontSide)
                picFrontSide.Image = ReadXml("xml/Front" + GetNameCheckedRadioButton() + ".xml", GetCroppedImage(frontSideImagePath));
            else
                picBackSide.Image = ReadXml("xml/Back" + GetNameCheckedRadioButton() + ".xml", GetCroppedImage(backSideImagePath));
        }

        private void FormHome_FormClosed(object sender, FormClosingEventArgs e)
        {
            FormHomeClose();
        }
        private void FormHomeClose()
        {
            if (File.Exists(frontSideImagePath))
                File.Delete(frontSideImagePath);
            if (File.Exists(backSideImagePath))
                File.Delete(backSideImagePath);
            CloseCurrentVideoSource();
        }
    }
}
