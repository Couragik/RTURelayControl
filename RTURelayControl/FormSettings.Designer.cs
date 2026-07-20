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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Программа", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Интерфейс");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Опрос и таймауты");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Автоматизация");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.settingsTreeView = new System.Windows.Forms.TreeView();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsTreeView
            // 
            this.settingsTreeView.Location = new System.Drawing.Point(12, 12);
            this.settingsTreeView.Name = "settingsTreeView";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Узел4";
            treeNode2.Name = "NodeApp";
            treeNode2.Tag = "SettingsSectionEnum.Program";
            treeNode2.Text = "Программа";
            treeNode3.Name = "NodeInterface";
            treeNode3.Tag = "SettingsSectionEnum.Interface";
            treeNode3.Text = "Интерфейс";
            treeNode4.Name = "NodeTimer";
            treeNode4.Tag = "SettingsSectionEnum.Timer";
            treeNode4.Text = "Опрос и таймауты";
            treeNode5.Name = "NodeAuto";
            treeNode5.Tag = "SettingsSectionEnum.Automat";
            treeNode5.Text = "Автоматизация";
            this.settingsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.settingsTreeView.ShowLines = false;
            this.settingsTreeView.ShowPlusMinus = false;
            this.settingsTreeView.Size = new System.Drawing.Size(194, 426);
            this.settingsTreeView.TabIndex = 0;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Location = new System.Drawing.Point(212, 8);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(465, 390);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}