namespace RTURelayControl
{
    partial class FormSettings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Программа");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Интерфейс");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Опрос и таймауты");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Автоматизация");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.settingsTreeView = new System.Windows.Forms.TreeView();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.tableLayoutProgram = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabInterface = new System.Windows.Forms.TabPage();
            this.tableLayoutInterface = new System.Windows.Forms.TableLayoutPanel();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericPollInterval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAutoScan = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelCyclePoll = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCyclePollInterval = new System.Windows.Forms.NumericUpDown();
            this.tabAutomat = new System.Windows.Forms.TabPage();
            this.tableLayoutAutomat = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControlSettings.SuspendLayout();
            this.tabProgram.SuspendLayout();
            this.tableLayoutProgram.SuspendLayout();
            this.tabInterface.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPollInterval)).BeginInit();
            this.tableLayoutPanelCyclePoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCyclePollInterval)).BeginInit();
            this.tabAutomat.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTreeView
            // 
            this.settingsTreeView.Location = new System.Drawing.Point(12, 12);
            this.settingsTreeView.Name = "settingsTreeView";
            treeNode1.Name = "NodeApp";
            treeNode1.Tag = "SettingsSectionEnum.Program";
            treeNode1.Text = "Программа";
            treeNode2.Name = "NodeInterface";
            treeNode2.Tag = "SettingsSectionEnum.Interface";
            treeNode2.Text = "Интерфейс";
            treeNode3.Name = "NodeTimer";
            treeNode3.Tag = "SettingsSectionEnum.Timer";
            treeNode3.Text = "Опрос и таймауты";
            treeNode4.Name = "NodeAuto";
            treeNode4.Tag = "SettingsSectionEnum.Automat";
            treeNode4.Text = "Автоматизация";
            this.settingsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.settingsTreeView.ShowLines = false;
            this.settingsTreeView.ShowPlusMinus = false;
            this.settingsTreeView.Size = new System.Drawing.Size(194, 426);
            this.settingsTreeView.TabIndex = 0;
            this.settingsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.settingsTreeView_AfterSelect);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabProgram);
            this.tabControlSettings.Controls.Add(this.tabInterface);
            this.tabControlSettings.Controls.Add(this.tabTimer);
            this.tabControlSettings.Controls.Add(this.tabAutomat);
            this.tabControlSettings.Location = new System.Drawing.Point(212, 8);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(465, 397);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabProgram
            // 
            this.tabProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProgram.Controls.Add(this.tableLayoutProgram);
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(457, 371);
            this.tabProgram.TabIndex = 0;
            this.tabProgram.Text = "tabProgram";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // tableLayoutProgram
            // 
            this.tableLayoutProgram.ColumnCount = 2;
            this.tableLayoutProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68958F));
            this.tableLayoutProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31042F));
            this.tableLayoutProgram.Controls.Add(this.label1, 0, 0);
            this.tableLayoutProgram.Controls.Add(this.checkBox1, 1, 0);
            this.tableLayoutProgram.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutProgram.Name = "tableLayoutProgram";
            this.tableLayoutProgram.RowCount = 3;
            this.tableLayoutProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutProgram.Size = new System.Drawing.Size(451, 365);
            this.tableLayoutProgram.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запускать при старте Windows";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.Location = new System.Drawing.Point(189, 9);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Tag = "AutoStart";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.formElements_ValChanged);
            // 
            // tabInterface
            // 
            this.tabInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInterface.Controls.Add(this.tableLayoutInterface);
            this.tabInterface.Location = new System.Drawing.Point(4, 22);
            this.tabInterface.Name = "tabInterface";
            this.tabInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterface.Size = new System.Drawing.Size(457, 371);
            this.tabInterface.TabIndex = 1;
            this.tabInterface.Text = "tabInterface";
            this.tabInterface.UseVisualStyleBackColor = true;
            // 
            // tableLayoutInterface
            // 
            this.tableLayoutInterface.ColumnCount = 2;
            this.tableLayoutInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.00665F));
            this.tableLayoutInterface.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.99335F));
            this.tableLayoutInterface.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutInterface.Name = "tableLayoutInterface";
            this.tableLayoutInterface.RowCount = 3;
            this.tableLayoutInterface.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutInterface.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutInterface.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutInterface.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutInterface.Size = new System.Drawing.Size(451, 365);
            this.tableLayoutInterface.TabIndex = 1;
            // 
            // tabTimer
            // 
            this.tabTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTimer.Controls.Add(this.tableLayoutPanel1);
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(457, 371);
            this.tabTimer.TabIndex = 2;
            this.tabTimer.Text = "tabTimer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68958F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31042F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAutoScan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelCyclePoll, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 365);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.Controls.Add(this.numericPollInterval, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(182, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 24);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // numericPollInterval
            // 
            this.numericPollInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericPollInterval.Location = new System.Drawing.Point(5, 3);
            this.numericPollInterval.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.numericPollInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPollInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericPollInterval.Name = "numericPollInterval";
            this.numericPollInterval.Size = new System.Drawing.Size(59, 20);
            this.numericPollInterval.TabIndex = 7;
            this.numericPollInterval.Tag = "DevicePollInterval";
            this.numericPollInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPollInterval.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericPollInterval.ValueChanged += new System.EventHandler(this.formElements_ValChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "мс   ( не менее 50мс )";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Интервал опроса между устройствами";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Интервал между полными циклами опроса";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Отслеживание при запуске";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxAutoScan
            // 
            this.checkBoxAutoScan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAutoScan.AutoSize = true;
            this.checkBoxAutoScan.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAutoScan.Location = new System.Drawing.Point(189, 9);
            this.checkBoxAutoScan.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.checkBoxAutoScan.Name = "checkBoxAutoScan";
            this.checkBoxAutoScan.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoScan.TabIndex = 1;
            this.checkBoxAutoScan.Tag = "AutoScan";
            this.checkBoxAutoScan.UseVisualStyleBackColor = true;
            this.checkBoxAutoScan.CheckStateChanged += new System.EventHandler(this.formElements_ValChanged);
            // 
            // tableLayoutPanelCyclePoll
            // 
            this.tableLayoutPanelCyclePoll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelCyclePoll.ColumnCount = 2;
            this.tableLayoutPanelCyclePoll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCyclePoll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanelCyclePoll.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanelCyclePoll.Controls.Add(this.numericCyclePollInterval, 0, 0);
            this.tableLayoutPanelCyclePoll.Location = new System.Drawing.Point(182, 33);
            this.tableLayoutPanelCyclePoll.Name = "tableLayoutPanelCyclePoll";
            this.tableLayoutPanelCyclePoll.RowCount = 1;
            this.tableLayoutPanelCyclePoll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCyclePoll.Size = new System.Drawing.Size(242, 24);
            this.tableLayoutPanelCyclePoll.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "мс   ( не менее 100мс )";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericCyclePollInterval
            // 
            this.numericCyclePollInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericCyclePollInterval.Location = new System.Drawing.Point(5, 3);
            this.numericCyclePollInterval.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.numericCyclePollInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCyclePollInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericCyclePollInterval.Name = "numericCyclePollInterval";
            this.numericCyclePollInterval.Size = new System.Drawing.Size(59, 20);
            this.numericCyclePollInterval.TabIndex = 6;
            this.numericCyclePollInterval.Tag = "CyclePollInterval";
            this.numericCyclePollInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericCyclePollInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericCyclePollInterval.ValueChanged += new System.EventHandler(this.formElements_ValChanged);
            // 
            // tabAutomat
            // 
            this.tabAutomat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAutomat.Controls.Add(this.tableLayoutAutomat);
            this.tabAutomat.Location = new System.Drawing.Point(4, 22);
            this.tabAutomat.Name = "tabAutomat";
            this.tabAutomat.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomat.Size = new System.Drawing.Size(457, 371);
            this.tabAutomat.TabIndex = 3;
            this.tabAutomat.Text = "tabAutomat";
            this.tabAutomat.UseVisualStyleBackColor = true;
            // 
            // tableLayoutAutomat
            // 
            this.tableLayoutAutomat.ColumnCount = 2;
            this.tableLayoutAutomat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.00665F));
            this.tableLayoutAutomat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.99335F));
            this.tableLayoutAutomat.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutAutomat.Name = "tableLayoutAutomat";
            this.tableLayoutAutomat.RowCount = 3;
            this.tableLayoutAutomat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutAutomat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutAutomat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutAutomat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutAutomat.Size = new System.Drawing.Size(451, 365);
            this.tableLayoutAutomat.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(593, 411);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 27);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(507, 411);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 27);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.settingsTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.tabControlSettings.ResumeLayout(false);
            this.tabProgram.ResumeLayout(false);
            this.tableLayoutProgram.ResumeLayout(false);
            this.tableLayoutProgram.PerformLayout();
            this.tabInterface.ResumeLayout(false);
            this.tabTimer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPollInterval)).EndInit();
            this.tableLayoutPanelCyclePoll.ResumeLayout(false);
            this.tableLayoutPanelCyclePoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCyclePollInterval)).EndInit();
            this.tabAutomat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView settingsTreeView;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabInterface;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabAutomat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInterface;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAutomat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAutoScan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCyclePoll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericCyclePollInterval;
        private System.Windows.Forms.NumericUpDown numericPollInterval;
    }
}