namespace COMP123_S2019_Assignment5_Tzu_An_Wang.Views
{
    partial class OrderForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForms));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ManufactursTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.LCDSizeTextBox = new System.Windows.Forms.TextBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.GBUBrandLabel = new System.Windows.Forms.Label();
            this.CPUBrandTextBox = new System.Windows.Forms.TextBox();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.CPUnumberLabel = new System.Windows.Forms.Label();
            this.CPUNumberTextBox = new System.Windows.Forms.TextBox();
            this.CPUspeedLabel = new System.Windows.Forms.Label();
            this.CPUSeedTextBox = new System.Windows.Forms.TextBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.HDDTextBox = new System.Windows.Forms.TextBox();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.GPUTypeTextBox = new System.Windows.Forms.TextBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.WebCamTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.OSTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.OrderFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(1082, 28);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(163, 6);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(826, 535);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 46);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(951, 535);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(119, 46);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Finish";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(701, 535);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 46);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ManufactursTextBox
            // 
            this.ManufactursTextBox.Enabled = false;
            this.ManufactursTextBox.Location = new System.Drawing.Point(168, 127);
            this.ManufactursTextBox.Name = "ManufactursTextBox";
            this.ManufactursTextBox.Size = new System.Drawing.Size(168, 30);
            this.ManufactursTextBox.TabIndex = 10;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(16, 127);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(138, 25);
            this.ManufacturerLabel.TabIndex = 9;
            this.ManufacturerLabel.Text = "Manufacturer :";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(48, 75);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(106, 25);
            this.ConditionLabel.TabIndex = 9;
            this.ConditionLabel.Text = "Condition :";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Location = new System.Drawing.Point(168, 75);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(168, 30);
            this.ConditionTextBox.TabIndex = 10;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(368, 130);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(77, 25);
            this.ModelLabel.TabIndex = 9;
            this.ModelLabel.Text = "Model :";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(351, 78);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(94, 25);
            this.PlatformLabel.TabIndex = 9;
            this.PlatformLabel.Text = "Platform :";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Location = new System.Drawing.Point(459, 127);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(168, 30);
            this.ModelTextBox.TabIndex = 10;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Location = new System.Drawing.Point(459, 75);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(168, 30);
            this.PlatformTextBox.TabIndex = 10;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(59, 186);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(103, 25);
            this.LCDSizeLabel.TabIndex = 9;
            this.LCDSizeLabel.Text = "LCD size :";
            // 
            // LCDSizeTextBox
            // 
            this.LCDSizeTextBox.Enabled = false;
            this.LCDSizeTextBox.Location = new System.Drawing.Point(168, 183);
            this.LCDSizeTextBox.Name = "LCDSizeTextBox";
            this.LCDSizeTextBox.Size = new System.Drawing.Size(459, 30);
            this.LCDSizeTextBox.TabIndex = 10;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(68, 211);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(94, 25);
            this.MemoryLabel.TabIndex = 9;
            this.MemoryLabel.Text = "Memory :";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.Enabled = false;
            this.MemoryTextBox.Location = new System.Drawing.Point(168, 208);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(459, 30);
            this.MemoryTextBox.TabIndex = 10;
            // 
            // GBUBrandLabel
            // 
            this.GBUBrandLabel.AutoSize = true;
            this.GBUBrandLabel.Location = new System.Drawing.Point(40, 236);
            this.GBUBrandLabel.Name = "GBUBrandLabel";
            this.GBUBrandLabel.Size = new System.Drawing.Size(122, 25);
            this.GBUBrandLabel.TabIndex = 9;
            this.GBUBrandLabel.Text = "GBU Brand :";
            // 
            // CPUBrandTextBox
            // 
            this.CPUBrandTextBox.Enabled = false;
            this.CPUBrandTextBox.Location = new System.Drawing.Point(168, 233);
            this.CPUBrandTextBox.Name = "CPUBrandTextBox";
            this.CPUBrandTextBox.Size = new System.Drawing.Size(459, 30);
            this.CPUBrandTextBox.TabIndex = 10;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(48, 263);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(115, 25);
            this.CPUTypeLabel.TabIndex = 9;
            this.CPUTypeLabel.Text = "CPU Type :";
            // 
            // CPUTypeTextBox
            // 
            this.CPUTypeTextBox.Enabled = false;
            this.CPUTypeTextBox.Location = new System.Drawing.Point(168, 260);
            this.CPUTypeTextBox.Name = "CPUTypeTextBox";
            this.CPUTypeTextBox.Size = new System.Drawing.Size(459, 30);
            this.CPUTypeTextBox.TabIndex = 10;
            // 
            // CPUnumberLabel
            // 
            this.CPUnumberLabel.AutoSize = true;
            this.CPUnumberLabel.Location = new System.Drawing.Point(27, 288);
            this.CPUnumberLabel.Name = "CPUnumberLabel";
            this.CPUnumberLabel.Size = new System.Drawing.Size(136, 25);
            this.CPUnumberLabel.TabIndex = 9;
            this.CPUnumberLabel.Text = "CPU number :";
            // 
            // CPUNumberTextBox
            // 
            this.CPUNumberTextBox.Enabled = false;
            this.CPUNumberTextBox.Location = new System.Drawing.Point(168, 285);
            this.CPUNumberTextBox.Name = "CPUNumberTextBox";
            this.CPUNumberTextBox.Size = new System.Drawing.Size(459, 30);
            this.CPUNumberTextBox.TabIndex = 10;
            // 
            // CPUspeedLabel
            // 
            this.CPUspeedLabel.AutoSize = true;
            this.CPUspeedLabel.Location = new System.Drawing.Point(38, 313);
            this.CPUspeedLabel.Name = "CPUspeedLabel";
            this.CPUspeedLabel.Size = new System.Drawing.Size(124, 25);
            this.CPUspeedLabel.TabIndex = 9;
            this.CPUspeedLabel.Text = "CPU speed :";
            // 
            // CPUSeedTextBox
            // 
            this.CPUSeedTextBox.Enabled = false;
            this.CPUSeedTextBox.Location = new System.Drawing.Point(168, 310);
            this.CPUSeedTextBox.Name = "CPUSeedTextBox";
            this.CPUSeedTextBox.Size = new System.Drawing.Size(459, 30);
            this.CPUSeedTextBox.TabIndex = 10;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(97, 338);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(65, 25);
            this.HDDLabel.TabIndex = 9;
            this.HDDLabel.Text = "HDD :";
            // 
            // HDDTextBox
            // 
            this.HDDTextBox.Enabled = false;
            this.HDDTextBox.Location = new System.Drawing.Point(168, 335);
            this.HDDTextBox.Name = "HDDTextBox";
            this.HDDTextBox.Size = new System.Drawing.Size(459, 30);
            this.HDDTextBox.TabIndex = 10;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(47, 363);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(115, 25);
            this.GPUTypeLabel.TabIndex = 9;
            this.GPUTypeLabel.Text = "GPU Type :";
            // 
            // GPUTypeTextBox
            // 
            this.GPUTypeTextBox.Enabled = false;
            this.GPUTypeTextBox.Location = new System.Drawing.Point(168, 360);
            this.GPUTypeTextBox.Name = "GPUTypeTextBox";
            this.GPUTypeTextBox.Size = new System.Drawing.Size(459, 30);
            this.GPUTypeTextBox.TabIndex = 10;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(55, 390);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(107, 25);
            this.WebCamLabel.TabIndex = 9;
            this.WebCamLabel.Text = "WebCam :";
            // 
            // WebCamTextBox
            // 
            this.WebCamTextBox.Enabled = false;
            this.WebCamTextBox.Location = new System.Drawing.Point(168, 385);
            this.WebCamTextBox.Name = "WebCamTextBox";
            this.WebCamTextBox.Size = new System.Drawing.Size(459, 30);
            this.WebCamTextBox.TabIndex = 10;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(109, 413);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(53, 25);
            this.OSLabel.TabIndex = 9;
            this.OSLabel.Text = "OS :";
            // 
            // OSTextBox
            // 
            this.OSTextBox.Enabled = false;
            this.OSTextBox.Location = new System.Drawing.Point(168, 410);
            this.OSTextBox.Name = "OSTextBox";
            this.OSTextBox.Size = new System.Drawing.Size(459, 30);
            this.OSTextBox.TabIndex = 10;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(754, 360);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 25);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sales Tax (13%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total :";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Location = new System.Drawing.Point(827, 357);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(168, 30);
            this.CostTextBox.TabIndex = 10;
            this.CostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Enabled = false;
            this.SalesTaxTextBox.Location = new System.Drawing.Point(827, 396);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(168, 30);
            this.SalesTaxTextBox.TabIndex = 10;
            this.SalesTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(837, 469);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(168, 30);
            this.TotalTextBox.TabIndex = 10;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1082, 593);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 671;
            this.lineShape1.X2 = 1018;
            this.lineShape1.Y1 = 452;
            this.lineShape1.Y2 = 452;
            // 
            // OrderForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 593);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.PlatformTextBox);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.OSTextBox);
            this.Controls.Add(this.WebCamTextBox);
            this.Controls.Add(this.GPUTypeTextBox);
            this.Controls.Add(this.HDDTextBox);
            this.Controls.Add(this.CPUSeedTextBox);
            this.Controls.Add(this.CPUNumberTextBox);
            this.Controls.Add(this.CPUTypeTextBox);
            this.Controls.Add(this.CPUBrandTextBox);
            this.Controls.Add(this.MemoryTextBox);
            this.Controls.Add(this.LCDSizeTextBox);
            this.Controls.Add(this.ManufactursTextBox);
            this.Controls.Add(this.PlatformLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.OSLabel);
            this.Controls.Add(this.WebCamLabel);
            this.Controls.Add(this.GPUTypeLabel);
            this.Controls.Add(this.HDDLabel);
            this.Controls.Add(this.CPUspeedLabel);
            this.Controls.Add(this.CPUnumberLabel);
            this.Controls.Add(this.CPUTypeLabel);
            this.Controls.Add(this.GBUBrandLabel);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.LCDSizeLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.OrderForms_Activated);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox OSTextBox;
        private System.Windows.Forms.TextBox WebCamTextBox;
        private System.Windows.Forms.TextBox GPUTypeTextBox;
        private System.Windows.Forms.TextBox HDDTextBox;
        private System.Windows.Forms.TextBox CPUSeedTextBox;
        private System.Windows.Forms.TextBox CPUNumberTextBox;
        private System.Windows.Forms.TextBox CPUTypeTextBox;
        private System.Windows.Forms.TextBox CPUBrandTextBox;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.TextBox LCDSizeTextBox;
        private System.Windows.Forms.TextBox ManufactursTextBox;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUspeedLabel;
        private System.Windows.Forms.Label CPUnumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label GBUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}