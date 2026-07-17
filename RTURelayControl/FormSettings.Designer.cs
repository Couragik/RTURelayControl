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
            this.SuspendLayout();
            // 
            // settingsTreeView
            // 
            this.settingsTreeView.Location = new System.Drawing.Point(12, 12);
            this.settingsTreeView.Name = "settingsTreeView";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Узел4";
            treeNode2.Name = "NodeApp";
            treeNode2.Text = "Программа";
            treeNode3.Name = "NodeInterface";
            treeNode3.Text = "Интерфейс";
            treeNode4.Name = "NodeTimer";
            treeNode4.Text = "Опрос и таймауты";
            treeNode5.Name = "NodeAuto";
            treeNode5.Text = "Автоматизация";
            this.settingsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.settingsTreeView.ShowLines = false;
            this.settingsTreeView.Size = new System.Drawing.Size(202, 426);
            this.settingsTreeView.TabIndex = 0;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView settingsTreeView;
    }
}