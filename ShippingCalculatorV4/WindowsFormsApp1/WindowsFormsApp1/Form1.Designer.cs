namespace WindowsFormsApp1
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdoBox = new System.Windows.Forms.RadioButton();
            this.rdoCarte = new System.Windows.Forms.RadioButton();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCentimeter = new System.Windows.Forms.RadioButton();
            this.rdoInch = new System.Windows.Forms.RadioButton();
            this.grbDimentionsImput = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtOriging = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResultsBar = new System.Windows.Forms.Label();
            this.grbResults = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoKilogram = new System.Windows.Forms.RadioButton();
            this.rdoPound = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HOME = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl3rdPrice = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl3rdCompany = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl2ndPrice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl2ndCompany = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl1stPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1stCompany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.courierLogoList = new System.Windows.Forms.ImageList(this.components);
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbDimentionsImput.SuspendLayout();
            this.grbResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.HOME.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(247, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(366, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SHIPPING CALCULATOR";
            // 
            // rdoBox
            // 
            this.rdoBox.AutoSize = true;
            this.rdoBox.Location = new System.Drawing.Point(146, 31);
            this.rdoBox.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBox.Name = "rdoBox";
            this.rdoBox.Size = new System.Drawing.Size(54, 25);
            this.rdoBox.TabIndex = 3;
            this.rdoBox.TabStop = true;
            this.rdoBox.Text = "Box";
            this.rdoBox.UseVisualStyleBackColor = true;
            this.rdoBox.CheckedChanged += new System.EventHandler(this.rdoBox_CheckedChanged);
            // 
            // rdoCarte
            // 
            this.rdoCarte.AutoSize = true;
            this.rdoCarte.Location = new System.Drawing.Point(146, 74);
            this.rdoCarte.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCarte.Name = "rdoCarte";
            this.rdoCarte.Size = new System.Drawing.Size(66, 25);
            this.rdoCarte.TabIndex = 4;
            this.rdoCarte.TabStop = true;
            this.rdoCarte.Text = "Crate";
            this.rdoCarte.UseVisualStyleBackColor = true;
            this.rdoCarte.CheckedChanged += new System.EventHandler(this.rdoCarte_CheckedChanged);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.picBox);
            this.grpType.Controls.Add(this.rdoOther);
            this.grpType.Controls.Add(this.rdoBox);
            this.grpType.Controls.Add(this.rdoCarte);
            this.grpType.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpType.Location = new System.Drawing.Point(10, 136);
            this.grpType.Margin = new System.Windows.Forms.Padding(2);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(2);
            this.grpType.Size = new System.Drawing.Size(256, 170);
            this.grpType.TabIndex = 5;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type";
            // 
            // picBox
            // 
            this.picBox.Image = global::WindowsFormsApp1.Properties.Resources.cardboard;
            this.picBox.Location = new System.Drawing.Point(4, 17);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(120, 136);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(146, 116);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(2);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(70, 25);
            this.rdoOther.TabIndex = 5;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdoOther_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCentimeter);
            this.groupBox1.Controls.Add(this.rdoInch);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(278, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(191, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensions Units";
            // 
            // rdoCentimeter
            // 
            this.rdoCentimeter.AutoSize = true;
            this.rdoCentimeter.Location = new System.Drawing.Point(25, 58);
            this.rdoCentimeter.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCentimeter.Name = "rdoCentimeter";
            this.rdoCentimeter.Size = new System.Drawing.Size(105, 25);
            this.rdoCentimeter.TabIndex = 2;
            this.rdoCentimeter.TabStop = true;
            this.rdoCentimeter.Text = "Centimeter";
            this.rdoCentimeter.UseVisualStyleBackColor = true;
            this.rdoCentimeter.CheckedChanged += new System.EventHandler(this.rdoCentimeter_CheckedChanged);
            // 
            // rdoInch
            // 
            this.rdoInch.AutoSize = true;
            this.rdoInch.Location = new System.Drawing.Point(25, 102);
            this.rdoInch.Margin = new System.Windows.Forms.Padding(2);
            this.rdoInch.Name = "rdoInch";
            this.rdoInch.Size = new System.Drawing.Size(61, 25);
            this.rdoInch.TabIndex = 1;
            this.rdoInch.TabStop = true;
            this.rdoInch.Text = "Inch";
            this.rdoInch.UseVisualStyleBackColor = true;
            this.rdoInch.CheckedChanged += new System.EventHandler(this.rdoInch_CheckedChanged);
            // 
            // grbDimentionsImput
            // 
            this.grbDimentionsImput.Controls.Add(this.txtHeight);
            this.grbDimentionsImput.Controls.Add(this.txtTotalWeight);
            this.grbDimentionsImput.Controls.Add(this.txtWidth);
            this.grbDimentionsImput.Controls.Add(this.txtLenght);
            this.grbDimentionsImput.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDimentionsImput.Location = new System.Drawing.Point(755, 137);
            this.grbDimentionsImput.Margin = new System.Windows.Forms.Padding(2);
            this.grbDimentionsImput.Name = "grbDimentionsImput";
            this.grbDimentionsImput.Padding = new System.Windows.Forms.Padding(2);
            this.grbDimentionsImput.Size = new System.Drawing.Size(150, 169);
            this.grbDimentionsImput.TabIndex = 7;
            this.grbDimentionsImput.TabStop = false;
            this.grbDimentionsImput.Text = "Dimensions";
            this.toolTip3.SetToolTip(this.grbDimentionsImput, "Please enter the dimentions her for the objetc you want to ship");
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHeight.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtHeight.Location = new System.Drawing.Point(26, 90);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(93, 29);
            this.txtHeight.TabIndex = 13;
            this.txtHeight.Text = "Height";
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Enter);
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotalWeight.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalWeight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalWeight.Location = new System.Drawing.Point(26, 123);
            this.txtTotalWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalWeight.Multiline = true;
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(93, 29);
            this.txtTotalWeight.TabIndex = 12;
            this.txtTotalWeight.Text = "Total Weight";
            this.txtTotalWeight.TextChanged += new System.EventHandler(this.txtTotalWeight_TextChanged);
            this.txtTotalWeight.Enter += new System.EventHandler(this.txtTotalWeight_Enter);
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtWidth.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtWidth.Location = new System.Drawing.Point(26, 56);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidth.Multiline = true;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(93, 29);
            this.txtWidth.TabIndex = 11;
            this.txtWidth.Text = "Width";
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            this.txtWidth.Enter += new System.EventHandler(this.txtWidth_Enter);
            // 
            // txtLenght
            // 
            this.txtLenght.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLenght.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLenght.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtLenght.Location = new System.Drawing.Point(26, 23);
            this.txtLenght.Margin = new System.Windows.Forms.Padding(2);
            this.txtLenght.Multiline = true;
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(93, 29);
            this.txtLenght.TabIndex = 10;
            this.txtLenght.Text = "Lenght";
            this.txtLenght.TextChanged += new System.EventHandler(this.txtLenght_TextChanged);
            this.txtLenght.Enter += new System.EventHandler(this.txtLenght_Enter);
            // 
            // txtOriging
            // 
            this.txtOriging.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOriging.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOriging.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtOriging.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriging.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtOriging.Location = new System.Drawing.Point(10, 76);
            this.txtOriging.Margin = new System.Windows.Forms.Padding(2);
            this.txtOriging.Name = "txtOriging";
            this.txtOriging.Size = new System.Drawing.Size(681, 26);
            this.txtOriging.TabIndex = 8;
            this.txtOriging.Text = "Origin";
            this.toolTip1.SetToolTip(this.txtOriging, "Please enter the adress on google maps format. \r\nExample : 3501 Davie Rd, Davie, " +
        "FL 33314");
            this.txtOriging.TextChanged += new System.EventHandler(this.txtOriging_TextChanged_1);
            this.txtOriging.Enter += new System.EventHandler(this.txtOriging_Enter);
            // 
            // txtDest
            // 
            this.txtDest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDest.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtDest.Location = new System.Drawing.Point(10, 106);
            this.txtDest.Margin = new System.Windows.Forms.Padding(2);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(681, 26);
            this.txtDest.TabIndex = 9;
            this.txtDest.Text = "Destination";
            this.toolTip2.SetToolTip(this.txtDest, "Please enter the adress on google maps format. \r\nExample : 3501 Davie Rd, Davie, " +
        "FL 33314\r\n");
            this.txtDest.TextChanged += new System.EventHandler(this.txtDest_TextChanged_1);
            this.txtDest.Enter += new System.EventHandler(this.txtDest_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Navy;
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalculate.Location = new System.Drawing.Point(736, 321);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 34);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Shipping";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResultsBar
            // 
            this.lblResultsBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultsBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultsBar.Location = new System.Drawing.Point(14, 27);
            this.lblResultsBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultsBar.Name = "lblResultsBar";
            this.lblResultsBar.Size = new System.Drawing.Size(621, 24);
            this.lblResultsBar.TabIndex = 11;
            this.lblResultsBar.Text = "PACKAGE TYPE             LENGTH              WIDTH                  HEIGHT       " +
    "           WEIGHT                 ";
            // 
            // grbResults
            // 
            this.grbResults.Controls.Add(this.lblHeight);
            this.grbResults.Controls.Add(this.lblWidth);
            this.grbResults.Controls.Add(this.lblLength);
            this.grbResults.Controls.Add(this.lblWeight);
            this.grbResults.Controls.Add(this.lblType);
            this.grbResults.Controls.Add(this.lblResultsBar);
            this.grbResults.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbResults.Location = new System.Drawing.Point(10, 321);
            this.grbResults.Margin = new System.Windows.Forms.Padding(2);
            this.grbResults.Name = "grbResults";
            this.grbResults.Padding = new System.Windows.Forms.Padding(2);
            this.grbResults.Size = new System.Drawing.Size(722, 111);
            this.grbResults.TabIndex = 12;
            this.grbResults.TabStop = false;
            this.grbResults.Text = "Shipping Calculation Results";
            // 
            // lblHeight
            // 
            this.lblHeight.BackColor = System.Drawing.Color.AliceBlue;
            this.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHeight.Location = new System.Drawing.Point(389, 51);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(121, 25);
            this.lblHeight.TabIndex = 16;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.AliceBlue;
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWidth.Location = new System.Drawing.Point(264, 51);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(121, 25);
            this.lblWidth.TabIndex = 15;
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.Color.AliceBlue;
            this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLength.Location = new System.Drawing.Point(139, 51);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(121, 25);
            this.lblLength.TabIndex = 14;
            this.lblLength.Click += new System.EventHandler(this.lblLength_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.AliceBlue;
            this.lblWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWeight.Location = new System.Drawing.Point(514, 51);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(121, 25);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.AliceBlue;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblType.Location = new System.Drawing.Point(14, 51);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(121, 25);
            this.lblType.TabIndex = 12;
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Location = new System.Drawing.Point(736, 359);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Clear Results";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(736, 397);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 34);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDistance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDistance.Location = new System.Drawing.Point(769, 82);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(105, 32);
            this.lblDistance.TabIndex = 17;
            this.lblDistance.Click += new System.EventHandler(this.lblDistance_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoKilogram);
            this.groupBox2.Controls.Add(this.rdoPound);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(479, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(257, 170);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weight Units";
            // 
            // rdoKilogram
            // 
            this.rdoKilogram.AutoSize = true;
            this.rdoKilogram.Location = new System.Drawing.Point(23, 102);
            this.rdoKilogram.Margin = new System.Windows.Forms.Padding(2);
            this.rdoKilogram.Name = "rdoKilogram";
            this.rdoKilogram.Size = new System.Drawing.Size(94, 25);
            this.rdoKilogram.TabIndex = 3;
            this.rdoKilogram.TabStop = true;
            this.rdoKilogram.Text = "Kilogram";
            this.rdoKilogram.UseVisualStyleBackColor = true;
            // 
            // rdoPound
            // 
            this.rdoPound.AutoSize = true;
            this.rdoPound.Location = new System.Drawing.Point(23, 58);
            this.rdoPound.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPound.Name = "rdoPound";
            this.rdoPound.Size = new System.Drawing.Size(74, 25);
            this.rdoPound.TabIndex = 0;
            this.rdoPound.TabStop = true;
            this.rdoPound.Text = "Pound";
            this.rdoPound.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HOME);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(10, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(970, 511);
            this.tabControl.TabIndex = 18;
            // 
            // HOME
            // 
            this.HOME.Controls.Add(this.lblTitle);
            this.HOME.Controls.Add(this.btnExit);
            this.HOME.Controls.Add(this.groupBox2);
            this.HOME.Controls.Add(this.btnClear);
            this.HOME.Controls.Add(this.txtOriging);
            this.HOME.Controls.Add(this.btnCalculate);
            this.HOME.Controls.Add(this.grbResults);
            this.HOME.Controls.Add(this.grbDimentionsImput);
            this.HOME.Controls.Add(this.lblDistance);
            this.HOME.Controls.Add(this.txtDest);
            this.HOME.Controls.Add(this.grpType);
            this.HOME.Controls.Add(this.groupBox1);
            this.HOME.Location = new System.Drawing.Point(4, 22);
            this.HOME.Name = "HOME";
            this.HOME.Padding = new System.Windows.Forms.Padding(3);
            this.HOME.Size = new System.Drawing.Size(962, 485);
            this.HOME.TabIndex = 0;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = true;
            this.HOME.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.lblPrice);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RESULTS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl3rdPrice);
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.lbl3rdCompany);
            this.groupBox5.Location = new System.Drawing.Point(135, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(623, 85);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3 RD";
            // 
            // lbl3rdPrice
            // 
            this.lbl3rdPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl3rdPrice.Location = new System.Drawing.Point(488, 16);
            this.lbl3rdPrice.Name = "lbl3rdPrice";
            this.lbl3rdPrice.Size = new System.Drawing.Size(100, 23);
            this.lbl3rdPrice.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(223, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lbl3rdCompany
            // 
            this.lbl3rdCompany.Location = new System.Drawing.Point(38, 30);
            this.lbl3rdCompany.Name = "lbl3rdCompany";
            this.lbl3rdCompany.Size = new System.Drawing.Size(35, 13);
            this.lbl3rdCompany.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl2ndPrice);
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.lbl2ndCompany);
            this.groupBox4.Location = new System.Drawing.Point(129, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2 ND";
            // 
            // lbl2ndPrice
            // 
            this.lbl2ndPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl2ndPrice.Location = new System.Drawing.Point(494, 20);
            this.lbl2ndPrice.Name = "lbl2ndPrice";
            this.lbl2ndPrice.Size = new System.Drawing.Size(100, 23);
            this.lbl2ndPrice.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(229, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl2ndCompany
            // 
            this.lbl2ndCompany.Location = new System.Drawing.Point(38, 30);
            this.lbl2ndCompany.Name = "lbl2ndCompany";
            this.lbl2ndCompany.Size = new System.Drawing.Size(35, 13);
            this.lbl2ndCompany.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrice.Location = new System.Drawing.Point(554, 107);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(198, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "BEST PRICE ON TOP ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl1stPrice);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbl1stCompany);
            this.groupBox3.Location = new System.Drawing.Point(129, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1 ST";
            // 
            // lbl1stPrice
            // 
            this.lbl1stPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl1stPrice.Location = new System.Drawing.Point(494, 30);
            this.lbl1stPrice.Name = "lbl1stPrice";
            this.lbl1stPrice.Size = new System.Drawing.Size(100, 23);
            this.lbl1stPrice.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(229, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1stCompany
            // 
            this.lbl1stCompany.Location = new System.Drawing.Point(38, 30);
            this.lbl1stCompany.Name = "lbl1stCompany";
            this.lbl1stCompany.Size = new System.Drawing.Size(100, 23);
            this.lbl1stCompany.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(183, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "SHIPPING CALCULATOR";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            // 
            // courierLogoList
            // 
            this.courierLogoList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("courierLogoList.ImageStream")));
            this.courierLogoList.TransparentColor = System.Drawing.Color.Transparent;
            this.courierLogoList.Images.SetKeyName(0, "ups.png");
            this.courierLogoList.Images.SetKeyName(1, "dhl.png");
            this.courierLogoList.Images.SetKeyName(2, "usps.png");
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 543);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDimentionsImput.ResumeLayout(false);
            this.grbDimentionsImput.PerformLayout();
            this.grbResults.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.HOME.ResumeLayout(false);
            this.HOME.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdoBox;
        private System.Windows.Forms.RadioButton rdoCarte;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCentimeter;
        private System.Windows.Forms.RadioButton rdoInch;
        private System.Windows.Forms.GroupBox grbDimentionsImput;
        private System.Windows.Forms.TextBox txtOriging;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResultsBar;
        private System.Windows.Forms.GroupBox grbResults;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoKilogram;
        private System.Windows.Forms.RadioButton rdoPound;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage HOME;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl3rdPrice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl3rdCompany;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl2ndPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl2ndCompany;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl1stPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1stCompany;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ImageList courierLogoList;
    }
}

