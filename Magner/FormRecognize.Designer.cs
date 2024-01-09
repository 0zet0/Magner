
namespace Magner
{
    partial class FormRecognize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecognize));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picBackSide = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnRecognize = new MaterialSkin.Controls.MaterialButton();
            this.picFrontSide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.mpbRecognize = new MaterialSkin.Controls.MaterialProgressBar();
            this.fbdSave = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackSide)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontSide)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.picBackSide, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialCard1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.picFrontSide, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.03872F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.03872F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.92256F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 492);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // picBackSide
            // 
            this.picBackSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackSide.ErrorImage = null;
            this.picBackSide.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBackSide.InitialImage")));
            this.picBackSide.Location = new System.Drawing.Point(3, 190);
            this.picBackSide.Name = "picBackSide";
            this.picBackSide.Size = new System.Drawing.Size(264, 181);
            this.picBackSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackSide.TabIndex = 4;
            this.picBackSide.TabStop = false;
            this.picBackSide.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tableLayoutPanel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(5, 379);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard1.Size = new System.Drawing.Size(260, 108);
            this.materialCard1.TabIndex = 2;
            this.materialCard1.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialButton3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRecognize, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(250, 98);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClose.Depth = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(4, 53);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClose.Size = new System.Drawing.Size(117, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "назад";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(129, 53);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(117, 41);
            this.materialButton3.TabIndex = 2;
            this.materialButton3.TabStop = false;
            this.materialButton3.Text = "Копировать";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.btnCopy_Click);
            this.materialButton3.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(129, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(117, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // btnRecognize
            // 
            this.btnRecognize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRecognize.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnRecognize.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRecognize.Depth = 0;
            this.btnRecognize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecognize.HighEmphasis = true;
            this.btnRecognize.Icon = null;
            this.btnRecognize.Location = new System.Drawing.Point(4, 4);
            this.btnRecognize.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecognize.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRecognize.Size = new System.Drawing.Size(117, 41);
            this.btnRecognize.TabIndex = 0;
            this.btnRecognize.TabStop = false;
            this.btnRecognize.Text = "распознать";
            this.btnRecognize.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRecognize.UseAccentColor = false;
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            this.btnRecognize.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // picFrontSide
            // 
            this.picFrontSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFrontSide.ErrorImage = null;
            this.picFrontSide.InitialImage = ((System.Drawing.Image)(resources.GetObject("picFrontSide.InitialImage")));
            this.picFrontSide.Location = new System.Drawing.Point(3, 3);
            this.picFrontSide.Name = "picFrontSide";
            this.picFrontSide.Size = new System.Drawing.Size(264, 181);
            this.picFrontSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrontSide.TabIndex = 3;
            this.picFrontSide.TabStop = false;
            this.picFrontSide.MouseHover += new System.EventHandler(this.control_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTextBox);
            this.panel1.Controls.Add(this.mpbRecognize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(279, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 492);
            this.panel1.TabIndex = 1;
            // 
            // panelTextBox
            // 
            this.panelTextBox.AutoScroll = true;
            this.panelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextBox.Location = new System.Drawing.Point(0, 0);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(455, 487);
            this.panelTextBox.TabIndex = 2;
            // 
            // mpbRecognize
            // 
            this.mpbRecognize.Depth = 0;
            this.mpbRecognize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mpbRecognize.Location = new System.Drawing.Point(0, 487);
            this.mpbRecognize.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpbRecognize.Name = "mpbRecognize";
            this.mpbRecognize.Size = new System.Drawing.Size(455, 5);
            this.mpbRecognize.TabIndex = 0;
            // 
            // FormRecognize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormRecognize";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackSide)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontSide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnRecognize;
        public System.Windows.Forms.PictureBox picBackSide;
        public System.Windows.Forms.PictureBox picFrontSide;
        private System.Windows.Forms.FolderBrowserDialog fbdSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTextBox;
        private MaterialSkin.Controls.MaterialProgressBar mpbRecognize;
    }
}