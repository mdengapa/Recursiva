namespace Recursiva
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hijo10");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Padre1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nieto011");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nieto012");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hijo 01", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("SubNieto0211");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nieto021", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hijo 02", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hijo 03");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Padre0", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nieto211");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Hijo21", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Padre2", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Padre3");
            this.myTreeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myTreeView
            // 
            this.myTreeView.CheckBoxes = true;
            this.myTreeView.Location = new System.Drawing.Point(34, 21);
            this.myTreeView.Name = "myTreeView";
            treeNode1.Name = "Hijo10";
            treeNode1.Text = "Hijo10";
            treeNode2.Name = "Padre1";
            treeNode2.Text = "Padre1";
            treeNode3.Name = "Nieto011";
            treeNode3.Text = "Nieto011";
            treeNode4.Name = "Nieto012";
            treeNode4.Text = "Nieto012";
            treeNode5.Name = "Hijo01";
            treeNode5.Text = "Hijo 01";
            treeNode6.Checked = true;
            treeNode6.Name = "SubNieto0211";
            treeNode6.Text = "SubNieto0211";
            treeNode7.Name = "Nieto021";
            treeNode7.Text = "Nieto021";
            treeNode8.Name = "Hijo 02";
            treeNode8.Text = "Hijo 02";
            treeNode9.Name = "Hijo 03";
            treeNode9.Text = "Hijo 03";
            treeNode10.Name = "Padre0";
            treeNode10.Text = "Padre0";
            treeNode11.Checked = true;
            treeNode11.Name = "Nieto211";
            treeNode11.Text = "Nieto211";
            treeNode12.Checked = true;
            treeNode12.Name = "Hijo21";
            treeNode12.Text = "Hijo21";
            treeNode13.Checked = true;
            treeNode13.Name = "Padre2";
            treeNode13.Text = "Padre2";
            treeNode14.Name = "Padre3";
            treeNode14.Text = "Padre3";
            this.myTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode10,
            treeNode13,
            treeNode14});
            this.myTreeView.Size = new System.Drawing.Size(212, 293);
            this.myTreeView.TabIndex = 0;
            this.myTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.myTreeView_AfterSelect);
            this.myTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.myTreeView_NodeMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myTreeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        //void myTreeView_NodeMouseClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        //{
        //    throw new System.NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.TreeView myTreeView;
        private System.Windows.Forms.Button button1;
    }
}

