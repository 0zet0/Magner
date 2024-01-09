using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Magner
{
    public partial class ImageViewer : Form
    {
        public static Size SizeDSBox = new Size();
        public string pathImage;
        public string pathXML;
        DocType doc = new DocType();
        List<DSBox> dSBox = new List<DSBox>();
        public ImageViewer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        private Image GetCroppedImage(string path)
        {
            Image image;
            using (var croped = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Inheritable))
            {
                image = Image.FromStream(croped);
                croped.Close();
            }
            return image;
        }
        private void ImageViewer_Load(object sender, EventArgs e)
        {
            SizeDSBox = panels.Size;
            XmlSerializer reader = new XmlSerializer(typeof(DocType));
            StreamReader file = new StreamReader(pathXML);
            doc = (DocType)reader.Deserialize(file);
            string[] cord;
            int x, y, w, h, i = 0;
            foreach (var el in doc.Cordinate)
            {
                cord = el.Split(' ');
                x = Convert.ToInt32(cord[0]);
                y = Convert.ToInt32(cord[1]);
                w = Convert.ToInt32(cord[2]);
                h = Convert.ToInt32(cord[3]);
                x = (panels.Width * x) / 679;
                y = (panels.Height * y) / 386;
                w = (panels.Width * w) / 679;
                h = (panels.Height * h) / 386;
                DSBox dsBox = new DSBox();
                dsBox.Location = new Point(x, y);
                dsBox.Size = new Size(w, h);
                dsBox.TabIndex = i;
                dSBox.Add(dsBox);
                panels.Controls.Add(dSBox[i++]);
                panels.Update();
            }
            file.Close();
            this.panels.BackgroundImage = GetCroppedImage(pathImage);
            foreach (var dsbox in dSBox)
                dsbox.MouseHover += (object senderr, EventArgs ee) => label1.Text = doc.Lable[dsbox.TabIndex];
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnClose_MouseHover(object sender, EventArgs e) => btnClose.BackColor = Color.Red;

        private void btnClose_MouseLeave(object sender, EventArgs e) => btnClose.BackColor = Color.Transparent;

        private void saveDSBox_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x, y, w, h;
            DSBox ib = new DSBox();
            foreach (Control con in panels.Controls)
            {
                if (!(con.GetType() == ib.GetType()))
                    continue;
                ib = (DSBox)con;
                x = (679 * ib.Location.X) / panels.Width;
                y = (386 * ib.Location.Y) / panels.Height;
                w = (679 * ib.Width) / panels.Width;
                h = (386 * ib.Height) / panels.Height;
                doc.Cordinate[i++] = $"{++x} {++y} {++w} {++h}";
            }
            XmlSerializer writer = new XmlSerializer(typeof(DocType));
            StreamWriter file = new StreamWriter(pathXML);
            writer.Serialize(file, doc);
            file.Close();
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Изменения успешно сохранены", "OK", true);
            SnackBarMessage.Show(this);
        }

        private void panels_MouseHover(object sender, EventArgs e) => label1.Text = "";

        private void panels_MouseLeave(object sender, EventArgs e) => label1.Text = "";

        private void close_Click(object sender, EventArgs e) => this.Close();
    }
}
