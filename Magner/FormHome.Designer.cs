
using System.Windows.Forms;

namespace Magner
{
    partial class FormHome
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.idPassMaterialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.panelTopRigh = new System.Windows.Forms.Panel();
            this.darckLiteTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picBackSide = new System.Windows.Forms.PictureBox();
            this.picFrontSide = new System.Windows.Forms.PictureBox();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.showImage = new AForge.Controls.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tbpRadioButtonList = new System.Windows.Forms.TableLayoutPanel();
            this.rbBankCard = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDrivingPassport = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbTravelPassport = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbOldPassport = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbNewPassport = new MaterialSkin.Controls.MaterialRadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cardRadioButtonList = new MaterialSkin.Controls.MaterialCard();
            this.tlpRightTop = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.btnCropImage = new MaterialSkin.Controls.MaterialButton();
            this.isBackSide = new MaterialSkin.Controls.MaterialRadioButton();
            this.isFrontSide = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenImage = new MaterialSkin.Controls.MaterialButton();
            this.btnSnapshoot = new MaterialSkin.Controls.MaterialButton();
            this.btnWebcam = new MaterialSkin.Controls.MaterialButton();
            this.comboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.panelTopRigh.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontSide)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showImage)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.tbpRadioButtonList.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.cardRadioButtonList.SuspendLayout();
            this.tlpRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "Pass.png");
            this.icons.Images.SetKeyName(1, "travelPass.png");
            this.icons.Images.SetKeyName(2, "idPass.png");
            // 
            // idPassMaterialDrawer1
            // 
            this.idPassMaterialDrawer1.AutoHide = false;
            this.idPassMaterialDrawer1.AutoShow = false;
            this.idPassMaterialDrawer1.BackgroundWithAccent = false;
            this.idPassMaterialDrawer1.BaseTabControl = null;
            this.idPassMaterialDrawer1.Depth = 0;
            this.idPassMaterialDrawer1.HighlightWithAccent = true;
            this.idPassMaterialDrawer1.IndicatorWidth = 0;
            this.idPassMaterialDrawer1.IsOpen = false;
            this.idPassMaterialDrawer1.Location = new System.Drawing.Point(-250, 22);
            this.idPassMaterialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.idPassMaterialDrawer1.Name = "idPassMaterialDrawer1";
            this.idPassMaterialDrawer1.ShowIconsWhenHidden = false;
            this.idPassMaterialDrawer1.Size = new System.Drawing.Size(250, 36);
            this.idPassMaterialDrawer1.TabIndex = 1;
            this.idPassMaterialDrawer1.Text = "materialDrawer1";
            this.idPassMaterialDrawer1.UseColors = false;
            // 
            // panelTopRigh
            // 
            this.panelTopRigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopRigh.Controls.Add(this.darckLiteTheme);
            this.panelTopRigh.Location = new System.Drawing.Point(1052, 24);
            this.panelTopRigh.Name = "panelTopRigh";
            this.panelTopRigh.Size = new System.Drawing.Size(58, 40);
            this.panelTopRigh.TabIndex = 2;
            // 
            // darckLiteTheme
            // 
            this.darckLiteTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darckLiteTheme.AutoSize = true;
            this.darckLiteTheme.BackColor = System.Drawing.Color.Transparent;
            this.darckLiteTheme.Depth = 0;
            this.darckLiteTheme.Location = new System.Drawing.Point(0, 0);
            this.darckLiteTheme.Margin = new System.Windows.Forms.Padding(0);
            this.darckLiteTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darckLiteTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.darckLiteTheme.Name = "darckLiteTheme";
            this.darckLiteTheme.Ripple = true;
            this.darckLiteTheme.Size = new System.Drawing.Size(58, 37);
            this.darckLiteTheme.TabIndex = 7;
            this.darckLiteTheme.UseVisualStyleBackColor = false;
            this.darckLiteTheme.CheckedChanged += new System.EventHandler(this.darckLiteTheme_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 533);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.picBackSide, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.picFrontSide, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.videoSourcePlayer1, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(331, 533);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // picBackSide
            // 
            this.picBackSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackSide.Location = new System.Drawing.Point(0, 180);
            this.picBackSide.Margin = new System.Windows.Forms.Padding(0, 3, 2, 0);
            this.picBackSide.Name = "picBackSide";
            this.picBackSide.Size = new System.Drawing.Size(329, 174);
            this.picBackSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackSide.TabIndex = 1;
            this.picBackSide.TabStop = false;
            this.picBackSide.Click += new System.EventHandler(this.picBackSide_Click);
            // 
            // picFrontSide
            // 
            this.picFrontSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFrontSide.Location = new System.Drawing.Point(0, 3);
            this.picFrontSide.Margin = new System.Windows.Forms.Padding(0, 3, 2, 0);
            this.picFrontSide.Name = "picFrontSide";
            this.picFrontSide.Size = new System.Drawing.Size(329, 174);
            this.picFrontSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrontSide.TabIndex = 0;
            this.picFrontSide.TabStop = false;
            this.picFrontSide.Click += new System.EventHandler(this.picFrontSide_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 357);
            this.videoSourcePlayer1.Margin = new System.Windows.Forms.Padding(0, 3, 2, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(329, 173);
            this.videoSourcePlayer1.TabIndex = 2;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(331, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(773, 533);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.showImage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.materialCard1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(773, 266);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // showImage
            // 
            this.showImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showImage.Image = null;
            this.showImage.Location = new System.Drawing.Point(3, 3);
            this.showImage.Name = "showImage";
            this.showImage.Size = new System.Drawing.Size(380, 260);
            this.showImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showImage.TabIndex = 2;
            this.showImage.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tbpRadioButtonList);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(391, 5);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard1.Size = new System.Drawing.Size(377, 256);
            this.materialCard1.TabIndex = 0;
            // 
            // tbpRadioButtonList
            // 
            this.tbpRadioButtonList.ColumnCount = 1;
            this.tbpRadioButtonList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpRadioButtonList.Controls.Add(this.rbBankCard, 0, 4);
            this.tbpRadioButtonList.Controls.Add(this.rbDrivingPassport, 0, 3);
            this.tbpRadioButtonList.Controls.Add(this.rbTravelPassport, 0, 2);
            this.tbpRadioButtonList.Controls.Add(this.rbOldPassport, 0, 1);
            this.tbpRadioButtonList.Controls.Add(this.rbNewPassport, 0, 0);
            this.tbpRadioButtonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpRadioButtonList.Location = new System.Drawing.Point(5, 5);
            this.tbpRadioButtonList.Margin = new System.Windows.Forms.Padding(0);
            this.tbpRadioButtonList.Name = "tbpRadioButtonList";
            this.tbpRadioButtonList.RowCount = 5;
            this.tbpRadioButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpRadioButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpRadioButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpRadioButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpRadioButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpRadioButtonList.Size = new System.Drawing.Size(367, 246);
            this.tbpRadioButtonList.TabIndex = 1;
            // 
            // rbBankCard
            // 
            this.rbBankCard.AutoSize = true;
            this.rbBankCard.Depth = 0;
            this.rbBankCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbBankCard.Location = new System.Drawing.Point(0, 196);
            this.rbBankCard.Margin = new System.Windows.Forms.Padding(0);
            this.rbBankCard.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBankCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBankCard.Name = "rbBankCard";
            this.rbBankCard.Ripple = true;
            this.rbBankCard.Size = new System.Drawing.Size(367, 50);
            this.rbBankCard.TabIndex = 25;
            this.rbBankCard.TabStop = true;
            this.rbBankCard.Text = "Банковская Карта";
            this.rbBankCard.UseVisualStyleBackColor = true;
            this.rbBankCard.CheckedChanged += new System.EventHandler(this.rbChanged_CheckedChanged);
            // 
            // rbDrivingPassport
            // 
            this.rbDrivingPassport.AutoSize = true;
            this.rbDrivingPassport.Depth = 0;
            this.rbDrivingPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDrivingPassport.Location = new System.Drawing.Point(0, 147);
            this.rbDrivingPassport.Margin = new System.Windows.Forms.Padding(0);
            this.rbDrivingPassport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDrivingPassport.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDrivingPassport.Name = "rbDrivingPassport";
            this.rbDrivingPassport.Ripple = true;
            this.rbDrivingPassport.Size = new System.Drawing.Size(367, 49);
            this.rbDrivingPassport.TabIndex = 24;
            this.rbDrivingPassport.TabStop = true;
            this.rbDrivingPassport.Text = "Водительские Права";
            this.rbDrivingPassport.UseVisualStyleBackColor = true;
            this.rbDrivingPassport.CheckedChanged += new System.EventHandler(this.rbChanged_CheckedChanged);
            // 
            // rbTravelPassport
            // 
            this.rbTravelPassport.AutoSize = true;
            this.rbTravelPassport.Depth = 0;
            this.rbTravelPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTravelPassport.Location = new System.Drawing.Point(0, 98);
            this.rbTravelPassport.Margin = new System.Windows.Forms.Padding(0);
            this.rbTravelPassport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTravelPassport.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTravelPassport.Name = "rbTravelPassport";
            this.rbTravelPassport.Ripple = true;
            this.rbTravelPassport.Size = new System.Drawing.Size(367, 49);
            this.rbTravelPassport.TabIndex = 23;
            this.rbTravelPassport.TabStop = true;
            this.rbTravelPassport.Text = "Загран Паспорт РТ";
            this.rbTravelPassport.UseVisualStyleBackColor = true;
            this.rbTravelPassport.CheckedChanged += new System.EventHandler(this.rbChanged_CheckedChanged);
            // 
            // rbOldPassport
            // 
            this.rbOldPassport.AutoSize = true;
            this.rbOldPassport.Depth = 0;
            this.rbOldPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbOldPassport.Location = new System.Drawing.Point(0, 49);
            this.rbOldPassport.Margin = new System.Windows.Forms.Padding(0);
            this.rbOldPassport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbOldPassport.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbOldPassport.Name = "rbOldPassport";
            this.rbOldPassport.Ripple = true;
            this.rbOldPassport.Size = new System.Drawing.Size(367, 49);
            this.rbOldPassport.TabIndex = 22;
            this.rbOldPassport.TabStop = true;
            this.rbOldPassport.Text = "Старый Паспорт РТ";
            this.rbOldPassport.UseVisualStyleBackColor = true;
            this.rbOldPassport.CheckedChanged += new System.EventHandler(this.rbChanged_CheckedChanged);
            // 
            // rbNewPassport
            // 
            this.rbNewPassport.AutoSize = true;
            this.rbNewPassport.Depth = 0;
            this.rbNewPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbNewPassport.Location = new System.Drawing.Point(0, 0);
            this.rbNewPassport.Margin = new System.Windows.Forms.Padding(0);
            this.rbNewPassport.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNewPassport.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNewPassport.Name = "rbNewPassport";
            this.rbNewPassport.Ripple = true;
            this.rbNewPassport.Size = new System.Drawing.Size(367, 49);
            this.rbNewPassport.TabIndex = 20;
            this.rbNewPassport.TabStop = true;
            this.rbNewPassport.Text = "Новый Паспорт РТ";
            this.rbNewPassport.UseVisualStyleBackColor = true;
            this.rbNewPassport.CheckedChanged += new System.EventHandler(this.rbChanged_CheckedChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.cardRadioButtonList, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.materialCard3, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 266);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(773, 267);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // cardRadioButtonList
            // 
            this.cardRadioButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRadioButtonList.Controls.Add(this.tlpRightTop);
            this.cardRadioButtonList.Depth = 0;
            this.cardRadioButtonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRadioButtonList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRadioButtonList.Location = new System.Drawing.Point(5, 5);
            this.cardRadioButtonList.Margin = new System.Windows.Forms.Padding(5);
            this.cardRadioButtonList.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRadioButtonList.Name = "cardRadioButtonList";
            this.cardRadioButtonList.Padding = new System.Windows.Forms.Padding(5);
            this.cardRadioButtonList.Size = new System.Drawing.Size(376, 257);
            this.cardRadioButtonList.TabIndex = 1;
            // 
            // tlpRightTop
            // 
            this.tlpRightTop.ColumnCount = 1;
            this.tlpRightTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightTop.Controls.Add(this.trackBar1, 0, 2);
            this.tlpRightTop.Controls.Add(this.trackBar2, 0, 3);
            this.tlpRightTop.Controls.Add(this.btnCropImage, 0, 4);
            this.tlpRightTop.Controls.Add(this.isBackSide, 0, 1);
            this.tlpRightTop.Controls.Add(this.isFrontSide, 0, 0);
            this.tlpRightTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightTop.Location = new System.Drawing.Point(5, 5);
            this.tlpRightTop.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRightTop.Name = "tlpRightTop";
            this.tlpRightTop.RowCount = 5;
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18123F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18123F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18123F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18123F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.09385F));
            this.tlpRightTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18123F));
            this.tlpRightTop.Size = new System.Drawing.Size(366, 247);
            this.tlpRightTop.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(3, 97);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(360, 41);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Value = 255;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Location = new System.Drawing.Point(3, 144);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(360, 41);
            this.trackBar2.TabIndex = 16;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btnCropImage
            // 
            this.btnCropImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCropImage.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnCropImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCropImage.Depth = 0;
            this.btnCropImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCropImage.HighEmphasis = true;
            this.btnCropImage.Icon = null;
            this.btnCropImage.Location = new System.Drawing.Point(4, 194);
            this.btnCropImage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCropImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCropImage.Name = "btnCropImage";
            this.btnCropImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCropImage.Size = new System.Drawing.Size(358, 47);
            this.btnCropImage.TabIndex = 17;
            this.btnCropImage.Text = "Обрезать";
            this.btnCropImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCropImage.UseAccentColor = false;
            this.btnCropImage.UseVisualStyleBackColor = true;
            this.btnCropImage.Click += new System.EventHandler(this.btnCropImage_Click);
            // 
            // isBackSide
            // 
            this.isBackSide.AutoSize = true;
            this.isBackSide.Depth = 0;
            this.isBackSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isBackSide.Location = new System.Drawing.Point(0, 47);
            this.isBackSide.Margin = new System.Windows.Forms.Padding(0);
            this.isBackSide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isBackSide.MouseState = MaterialSkin.MouseState.HOVER;
            this.isBackSide.Name = "isBackSide";
            this.isBackSide.Ripple = true;
            this.isBackSide.Size = new System.Drawing.Size(366, 47);
            this.isBackSide.TabIndex = 15;
            this.isBackSide.TabStop = true;
            this.isBackSide.Text = "Обратная сторона";
            this.isBackSide.UseVisualStyleBackColor = true;
            // 
            // isFrontSide
            // 
            this.isFrontSide.AutoSize = true;
            this.isFrontSide.Depth = 0;
            this.isFrontSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isFrontSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isFrontSide.Location = new System.Drawing.Point(0, 0);
            this.isFrontSide.Margin = new System.Windows.Forms.Padding(0);
            this.isFrontSide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isFrontSide.MouseState = MaterialSkin.MouseState.HOVER;
            this.isFrontSide.Name = "isFrontSide";
            this.isFrontSide.Ripple = true;
            this.isFrontSide.Size = new System.Drawing.Size(366, 47);
            this.isFrontSide.TabIndex = 14;
            this.isFrontSide.TabStop = true;
            this.isFrontSide.Text = "Лицевая сторона";
            this.isFrontSide.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel6);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(391, 5);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard3.Size = new System.Drawing.Size(377, 257);
            this.materialCard3.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btnSubmit, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.btnOpenImage, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.btnSnapshoot, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btnWebcam, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(367, 247);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.HighEmphasis = true;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(4, 200);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit.Size = new System.Drawing.Size(359, 43);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "отправить";
            this.btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit.UseAccentColor = false;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenImage.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnOpenImage.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenImage.Depth = 0;
            this.btnOpenImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenImage.HighEmphasis = true;
            this.btnOpenImage.Icon = null;
            this.btnOpenImage.Location = new System.Drawing.Point(4, 151);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenImage.Size = new System.Drawing.Size(359, 41);
            this.btnOpenImage.TabIndex = 20;
            this.btnOpenImage.Text = "Выбрать изображение";
            this.btnOpenImage.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenImage.UseAccentColor = false;
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnSnapshoot
            // 
            this.btnSnapshoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSnapshoot.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnSnapshoot.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSnapshoot.Depth = 0;
            this.btnSnapshoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSnapshoot.HighEmphasis = true;
            this.btnSnapshoot.Icon = null;
            this.btnSnapshoot.Location = new System.Drawing.Point(4, 102);
            this.btnSnapshoot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSnapshoot.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSnapshoot.Name = "btnSnapshoot";
            this.btnSnapshoot.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSnapshoot.Size = new System.Drawing.Size(359, 41);
            this.btnSnapshoot.TabIndex = 19;
            this.btnSnapshoot.Text = "Получить кадр с камеры";
            this.btnSnapshoot.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSnapshoot.UseAccentColor = false;
            this.btnSnapshoot.UseVisualStyleBackColor = true;
            this.btnSnapshoot.Click += new System.EventHandler(this.btnSnapshoot_Click);
            // 
            // btnWebcam
            // 
            this.btnWebcam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWebcam.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnWebcam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWebcam.Depth = 0;
            this.btnWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWebcam.HighEmphasis = true;
            this.btnWebcam.Icon = null;
            this.btnWebcam.Location = new System.Drawing.Point(4, 53);
            this.btnWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.btnWebcam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWebcam.Size = new System.Drawing.Size(359, 41);
            this.btnWebcam.TabIndex = 18;
            this.btnWebcam.Text = "Запустить Веб-камеру";
            this.btnWebcam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWebcam.UseAccentColor = false;
            this.btnWebcam.UseVisualStyleBackColor = true;
            this.btnWebcam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoResize = false;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.Depth = 0;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.DropDownHeight = 174;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 121;
            this.comboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Hint = "Выбрать Веб-камеру";
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 43;
            this.comboBox1.Location = new System.Drawing.Point(4, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 49);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1110, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTopRigh);
            this.Controls.Add(this.idPassMaterialDrawer1);
            this.DrawerShowIconsWhenHidden = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosed);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.panelTopRigh.ResumeLayout(false);
            this.panelTopRigh.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontSide)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showImage)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.tbpRadioButtonList.ResumeLayout(false);
            this.tbpRadioButtonList.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.cardRadioButtonList.ResumeLayout(false);
            this.tlpRightTop.ResumeLayout(false);
            this.tlpRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList icons;
        private MaterialSkin.Controls.MaterialDrawer idPassMaterialDrawer1;
        private System.Windows.Forms.Panel panelTopRigh;
        private MaterialSkin.Controls.MaterialSwitch darckLiteTheme;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox picBackSide;
        private PictureBox picFrontSide;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard cardRadioButtonList;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialButton btnOpenImage;
        private MaterialSkin.Controls.MaterialButton btnSnapshoot;
        private MaterialSkin.Controls.MaterialButton btnWebcam;
        private MaterialSkin.Controls.MaterialComboBox comboBox1;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.PictureBox showImage;
        private TableLayoutPanel tbpRadioButtonList;
        private MaterialSkin.Controls.MaterialRadioButton rbBankCard;
        private MaterialSkin.Controls.MaterialRadioButton rbDrivingPassport;
        private MaterialSkin.Controls.MaterialRadioButton rbTravelPassport;
        private MaterialSkin.Controls.MaterialRadioButton rbOldPassport;
        private MaterialSkin.Controls.MaterialRadioButton rbNewPassport;
        private TableLayoutPanel tlpRightTop;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private MaterialSkin.Controls.MaterialButton btnCropImage;
        private MaterialSkin.Controls.MaterialRadioButton isBackSide;
        private MaterialSkin.Controls.MaterialRadioButton isFrontSide;
    }
}

