namespace RTURelayControl
{
    partial class PortSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortSettings));
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelComPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBit = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelStopBit = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(166, 169);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(80, 27);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(250, 169);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 27);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.72897F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.27103F));
            this.tableLayoutPanel1.Controls.Add(this.labelComPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBaudRate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDataBit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelParity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelStopBit, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxComPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBaudRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDataBit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxParity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStopBit, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 151);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelComPort
            // 
            this.labelComPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(93, 8);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(53, 13);
            this.labelComPort.TabIndex = 0;
            this.labelComPort.Text = "COM Port";
            this.labelComPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(88, 38);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(58, 13);
            this.labelBaudRate.TabIndex = 0;
            this.labelBaudRate.Text = "Baud Rate";
            this.labelBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDataBit
            // 
            this.labelDataBit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDataBit.AutoSize = true;
            this.labelDataBit.Location = new System.Drawing.Point(101, 68);
            this.labelDataBit.Name = "labelDataBit";
            this.labelDataBit.Size = new System.Drawing.Size(45, 13);
            this.labelDataBit.TabIndex = 0;
            this.labelDataBit.Text = "Data Bit";
            this.labelDataBit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelParity
            // 
            this.labelParity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(113, 98);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(33, 13);
            this.labelParity.TabIndex = 0;
            this.labelParity.Text = "Parity";
            this.labelParity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStopBit
            // 
            this.labelStopBit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStopBit.AutoSize = true;
            this.labelStopBit.Location = new System.Drawing.Point(102, 128);
            this.labelStopBit.Name = "labelStopBit";
            this.labelStopBit.Size = new System.Drawing.Size(44, 13);
            this.labelStopBit.TabIndex = 0;
            this.labelStopBit.Text = "Stop Bit";
            this.labelStopBit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(154, 4);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(164, 21);
            this.comboBoxComPort.TabIndex = 1;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(154, 34);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(164, 21);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBit.Location = new System.Drawing.Point(154, 64);
            this.comboBoxDataBit.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(164, 21);
            this.comboBoxDataBit.TabIndex = 1;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Location = new System.Drawing.Point(154, 94);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(164, 21);
            this.comboBoxParity.TabIndex = 1;
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Location = new System.Drawing.Point(154, 124);
            this.comboBoxStopBit.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(164, 21);
            this.comboBoxStopBit.TabIndex = 1;
            // 
            // PortSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 209);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortSettings";
            this.Text = "PortSettings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBit;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelStopBit;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
    }
}