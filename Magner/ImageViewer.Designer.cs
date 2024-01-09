
using System.Windows.Forms;

namespace Magner
{
    partial class ImageViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.saveDSBox = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panels = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Magner.Properties.Resources.CloseWhite;
            this.btnClose.Location = new System.Drawing.Point(546, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 62);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.saveDSBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 62);
            this.panel2.TabIndex = 1;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.AutoSize = false;
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackColor = System.Drawing.Color.Black;
            this.close.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.close.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.close.Depth = 0;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.HighEmphasis = true;
            this.close.Icon = null;
            this.close.Location = new System.Drawing.Point(372, 9);
            this.close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.close.MouseState = MaterialSkin.MouseState.HOVER;
            this.close.Name = "close";
            this.close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.close.Size = new System.Drawing.Size(106, 42);
            this.close.TabIndex = 7;
            this.close.Text = "Назад";
            this.close.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.close.UseAccentColor = false;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 6;
            this.label1.Tag = "";
            // 
            // saveDSBox
            // 
            this.saveDSBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDSBox.AutoSize = false;
            this.saveDSBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveDSBox.BackColor = System.Drawing.Color.Black;
            this.saveDSBox.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.saveDSBox.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveDSBox.Depth = 0;
            this.saveDSBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDSBox.HighEmphasis = true;
            this.saveDSBox.Icon = null;
            this.saveDSBox.Location = new System.Drawing.Point(489, 9);
            this.saveDSBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveDSBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveDSBox.Name = "saveDSBox";
            this.saveDSBox.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveDSBox.Size = new System.Drawing.Size(106, 42);
            this.saveDSBox.TabIndex = 5;
            this.saveDSBox.Text = "Сохранить";
            this.saveDSBox.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveDSBox.UseAccentColor = false;
            this.saveDSBox.UseVisualStyleBackColor = false;
            this.saveDSBox.Click += new System.EventHandler(this.saveDSBox_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(62, 335);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(546, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(62, 335);
            this.panel4.TabIndex = 3;
            // 
            // panels
            // 
            this.panels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panels.Location = new System.Drawing.Point(62, 62);
            this.panels.Margin = new System.Windows.Forms.Padding(0);
            this.panels.Name = "panels";
            this.panels.Size = new System.Drawing.Size(484, 335);
            this.panels.TabIndex = 4;
            this.panels.MouseLeave += new System.EventHandler(this.panels_MouseLeave);
            this.panels.MouseHover += new System.EventHandler(this.panels_MouseHover);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(608, 459);
            this.Controls.Add(this.panels);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageViewer";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panels;
        private MaterialSkin.Controls.MaterialButton saveDSBox;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton close;
    }
}