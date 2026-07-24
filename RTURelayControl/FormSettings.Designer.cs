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
            this.tabInterface = new System.Windows.Forms.TabPage();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.tabAutomat = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControlSettings.SuspendLayout();
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
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(457, 371);
            this.tabProgram.TabIndex = 0;
            this.tabProgram.Text = "tabProgram";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // tabInterface
            // 
            this.tabInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInterface.Location = new System.Drawing.Point(4, 22);
            this.tabInterface.Name = "tabInterface";
            this.tabInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterface.Size = new System.Drawing.Size(457, 371);
            this.tabInterface.TabIndex = 1;
            this.tabInterface.Text = "tabInterface";
            this.tabInterface.UseVisualStyleBackColor = true;
            // 
            // tabTimer
            // 
            this.tabTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTimer.Location = new System.Drawing.Point(4, 22);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(457, 371);
            this.tabTimer.TabIndex = 2;
            this.tabTimer.Text = "tabTimer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // tabAutomat
            // 
            this.tabAutomat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAutomat.Location = new System.Drawing.Point(4, 22);
            this.tabAutomat.Name = "tabAutomat";
            this.tabAutomat.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomat.Size = new System.Drawing.Size(457, 371);
            this.tabAutomat.TabIndex = 3;
            this.tabAutomat.Text = "tabAutomat";
            this.tabAutomat.UseVisualStyleBackColor = true;
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
    }
}