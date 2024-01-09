using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tesseract;

namespace Magner
{
    public partial class FormRecognize : MaterialForm
    {
        public string[] rbName = new string[2];
        public static string frontSideImagePath = "image/FrontSide.jpg";
        public static string backSideImagePath = "image/BackSide.jpg";
        private string clearedImagePath = "image/ClearedImage.jpg";
        private List<string> textLine = new List<string>();
        private Dictionary<String, Image> imageBox = new Dictionary<String, Image>();
        private Dictionary<String, int> imageBoxLocation = new Dictionary<String, int>();
        private List<MaterialMaskedTextBox> boxes = new List<MaterialMaskedTextBox>();
        private PictureBox showBox = new PictureBox();
        public FormRecognize()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Treshold(string[] rbName, ref int blockSize, ref int c, ref int width, ref int height)
        {
            foreach (var path in rbName)
            {
                switch (path)
                {
                    case "xml/BackrbNewPassport.xml":
                        blockSize = 35;
                        c = 6;
                        width = 900;
                        height = 788;
                        break;
                    case "xml/FrontrbNewPassport.xml":
                        blockSize = 35;
                        c = 6;
                        width = 900;
                        height = 788;
                        break;
                    case "xml/FrontrbBankCard.xml":
                        blockSize = 0;
                        c = 0;
                        width = 900;
                        height = 788;
                        break;
                    case "xml/FrontrbDrivingPassport.xml":
                        blockSize = 0;
                        c = 0;
                        width = 900;
                        height = 788;
                        break;
                    case "xml/FrontrbOldPassport.xml":
                        blockSize = 0;
                        c = 0;
                        width = 600;
                        height = 888;
                        break;
                    case "xml/FrontrbTravelPassport.xml":
                        blockSize = 0;
                        c = 0;
                        width = 600;
                        height = 788;
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private string GetText(string textLine, int k)
        {
            int tabCount = 0;
            string text = "";
            foreach (var ch in textLine)
            {
                if (ch == ' ')
                    tabCount++;
                if (tabCount < k)
                    text += ch;
                else
                    break;
            }
            return text;
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            panelTextBox.Controls.Clear();
            textLine.Clear();
            boxes.Clear();
            imageBoxLocation.Clear();
            imageBox.Clear();
            int blockSize = 0, c = 0, width = 900, height = 788, i = 0, i2, pointY = 0;
            Treshold(rbName, ref blockSize, ref c, ref width, ref height);
            foreach (var path in rbName)
            {
                mpbRecognize.Value = 0;
                if (File.Exists(path))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(DocType));
                    StreamReader file = new StreamReader(path);
                    DocType doc = (DocType)reader.Deserialize(file);
                    var img = new ClearImage();
                    if (path.Contains("Front"))
                        img.Clear(frontSideImagePath, clearedImagePath, blockSize, c, width, height);
                    else
                        img.Clear(backSideImagePath, clearedImagePath, blockSize, c, width, height);
                    Bitmap bmp = (Bitmap)img.Cleared;
                    Bitmap OrignBmp = (Bitmap)img.OrignImage;
                    Image im = bmp;
                    string[] cord;
                    int x, y, w, h, k = 0;
                    int progress = 100 / doc.Cordinate.Length;
                    i2 = 0;
                    foreach (var el in doc.Cordinate)
                    {
                        cord = el.Split(' ');
                        x = Convert.ToInt32(cord[0]);
                        y = Convert.ToInt32(cord[1]);
                        w = Convert.ToInt32(cord[2]);
                        h = Convert.ToInt32(cord[3]);
                        x = (im.Width * x) / 679;
                        y = (im.Height * y) / 386;
                        w = (im.Width * w) / 679;
                        h = (im.Height * h) / 386;
                        Bitmap targetBitmap = new Bitmap(w, h);
                        Graphics g = Graphics.FromImage(targetBitmap);
                        g.DrawImage(bmp, new Rectangle(0, 0, w, h),
                            new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
                        Pix pix = PixConverter.ToPix(targetBitmap);
                        var engine = new TesseractEngine("tessdata", doc.TrainDataType[k]);
                        engine.SetVariable("tessedit_char_whitelist", doc.SetChars[k]);
                        var page = engine.Process(pix);
                        textLine.Add(page.GetText().Replace("\n", " "));
                        var segm = page.GetSegmentedRegions(PageIteratorLevel.Block);
                        foreach (var s in segm)
                        {
                            targetBitmap = new Bitmap(s.Width, s.Height);
                            g = Graphics.FromImage(targetBitmap);
                            g.DrawImage(OrignBmp, new Rectangle(0, 0, s.Width, s.Height),
                                new Rectangle(x + s.X - 5, y, s.Width + 10, h), GraphicsUnit.Pixel);
                        }
                        if (segm.Count == 0)
                        {
                            g.DrawImage(OrignBmp, new Rectangle(0, 0, w, h),
                                new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
                        }
                        imageBox.Add(doc.Lable[i2], (Image)targetBitmap.Clone());
                        imageBoxLocation.Add(doc.Lable[i2++], pointY += 48);
                        if (textLine[i].Length > 0)
                            if (textLine[i][textLine[i].Length - 1] == ' ')
                                textLine[i] = textLine[i].Substring(0, textLine[i].Length - 1);
                        i++;
                        mpbRecognize.Value += progress;
                        mpbRecognize.Update();
                        g.Dispose();
                        targetBitmap.Dispose();
                        k++;
                    }
                    i -= k;
                    string pol = null;
                    foreach (var hint in doc.Lable)
                    {
                        if (path.Contains("FrontrbOldPassport"))
                        {
                            switch (hint)
                            {
                                case "Ном / Номи падар":
                                    textLine[i] = GetText(textLine[i], 2);
                                    break;
                                case "Миллат":
                                    if (textLine[i].Contains("ВЕК"))
                                        textLine[i] = textLine[i].Replace("ВЕК", "БЕК");
                                    break;
                                case "Санаи таваллуд":
                                    textLine[i] = GetText(textLine[i], 4);
                                    break;
                                case "Санаи додани шиноснома":
                                    textLine[i] = GetText(textLine[i], 4);
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (path.Contains("BackrbNewPassport"))
                        {
                            switch (hint)
                            {
                                case "Вазъи оилавӣ":
                                    if (textLine[i].Contains("ОИЛА"))
                                        textLine[i] = "ОИЛАДОР";
                                    else
                                        textLine[i] = "МУҶАРРАД";
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (hint == "Насаб" && textLine[i].Length > 0)
                            if (textLine[i].Substring(textLine[i].Length - 1).ToUpper() == "А")
                                pol = "З";
                            else if ((textLine[i].Substring(textLine[i].Length - 1).ToUpper() == "В"))
                                pol = "М";
                        if (hint == "Ҷинс")
                            if (pol != null)
                                boxes.Add(GetTextBox(pol, hint, i));
                            else
                                if (textLine[i].Contains("М"))
                                boxes.Add(GetTextBox("М", hint, i));
                            else if (textLine[i].Contains("З"))
                                boxes.Add(GetTextBox("З", hint, i));
                            else
                                boxes.Add(GetTextBox("", hint, i));
                        else
                            boxes.Add(GetTextBox(textLine[i], hint, i));
                        i++;
                    }
                    file.Close();
                    mpbRecognize.Value += 100 - mpbRecognize.Value;
                }
            }
            showBox.Location = new Point(66, 22);
            showBox.Name = "pictureBox1";
            showBox.Size = new Size(100, 50);
            showBox.TabIndex = 1;
            showBox.TabStop = false;
            showBox.Visible = false;
            panelTextBox.Controls.Add(showBox);
            panelTextBox.Update();
            for (int j = textLine.Count - 1; j >= 0; j--)
            {
                panelTextBox.Controls.Add(boxes[j]);
                panelTextBox.Update();
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Процесс распознавание завершён!");
        }
        private MaterialMaskedTextBox GetTextBox(string text, string hint, int i)
        {
            MaterialMaskedTextBox maskedTextBox = new MaterialMaskedTextBox();
            maskedTextBox.Dock = DockStyle.Top;
            maskedTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskedTextBox.Hint = hint;
            maskedTextBox.MaxLength = 32767;
            maskedTextBox.Name = "idPassMaterialMaskedTextBox" + i;
            maskedTextBox.TabIndex = i;
            maskedTextBox.GotFocus += new EventHandler(materialMaskedTextBox_Click);
            maskedTextBox.Leave += new EventHandler(materialMaskedTextBox_Leave);
            maskedTextBox.MouseHover += new EventHandler(control_MouseEnter);
            maskedTextBox.Text = text;
            return maskedTextBox;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (boxes.Count == 0)
                return;
            string currDirectory = "Magner";
            string directory = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + currDirectory;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += "\\" + directory;
            Directory.CreateDirectory(path);
            StreamWriter streamWriter = new StreamWriter(path + "\\info.txt");
            List<string> textBoxis = new List<string>();
            foreach (MaterialMaskedTextBox textBox in boxes)
                textBoxis.Add($"{textBox.Hint}: {textBox.Text}");
            textBoxis.Reverse();
            foreach (var textbox in textBoxis)
                streamWriter.WriteLine(textbox);
            streamWriter.Close();
            if (picFrontSide.Image != null)
                ClearImage.SaveImage(frontSideImagePath, path + "\\FrontSide.jpeg");
            if (picBackSide.Image != null)
                ClearImage.SaveImage(backSideImagePath, path + "\\BackSide.jpeg");
            MessageBox.Show("Данные успещно сохранены!\nВ папке \"Документы\"");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (boxes.Count == 0)
                return;
            TextBox textBox = new TextBox();
            for (int i = 0; i < boxes.Count; i++)
                textBox.Text += boxes[i].Text + Environment.NewLine;
            textBox.SelectAll();
            textBox.Copy();
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Данные скопированы", "OK", true);
            SnackBarMessage.Show(this);
        }

        private void materialMaskedTextBox_Click(object sender, EventArgs e)
        {
            var textBox = (BaseMaskedTextBox)sender;
            int w, h = 38;
            w = h - imageBox[textBox.Hint].Height + imageBox[textBox.Hint].Width;
            showBox.Location = new Point(0, imageBoxLocation[textBox.Hint] - panelTextBox.VerticalScroll.Value);
            showBox.Size = new Size(w, h);
            showBox.Image = imageBox[textBox.Hint];
            showBox.SizeMode = PictureBoxSizeMode.StretchImage;
            showBox.Visible = true;
        }

        private void materialMaskedTextBox_Leave(object sender, EventArgs e)
        {
            showBox.Visible = false;
        }

        private void control_MouseEnter(object sender, EventArgs e)
        {
            if (sender is BaseMaskedTextBox)
            {
                if (panelTextBox.ContainsFocus)
                    showBox.Visible = true;
            }
            else
                showBox.Visible = false;
        }
    }
}
