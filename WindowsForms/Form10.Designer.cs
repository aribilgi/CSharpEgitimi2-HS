
namespace WindowsForms
{
    partial class Form10
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C#");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("OOP");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Yazılım", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sql Server");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Veritabanı", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Html");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Css");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("JavaScript");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Jquery");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Web Tasarım", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(250, 88);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node7";
            treeNode1.Text = "C#";
            treeNode2.Name = "Node8";
            treeNode2.Text = "OOP";
            treeNode2.ToolTipText = "Nesne yönelimli programlama";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Yazılım";
            treeNode4.Name = "Node9";
            treeNode4.Text = "Sql Server";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Veritabanı";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Html";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Css";
            treeNode8.Name = "Node5";
            treeNode8.Text = "JavaScript";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Jquery";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Web Tasarım";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(247, 203);
            this.treeView1.TabIndex = 0;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}