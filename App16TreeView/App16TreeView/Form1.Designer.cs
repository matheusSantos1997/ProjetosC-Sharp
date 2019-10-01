namespace App16TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Queijo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Presunto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Salame");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Frios", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Padaria", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Carne");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Frango");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Frios", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Bolacha");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Salgadinhos");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Guloseimas", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Supermercado", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Indent = 25;
            this.treeView1.ItemHeight = 30;
            this.treeView1.Location = new System.Drawing.Point(67, 47);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Queijo";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Presunto";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Salame";
            treeNode4.ForeColor = System.Drawing.Color.Olive;
            treeNode4.Name = "Node1";
            treeNode4.Text = "Frios";
            treeNode5.ForeColor = System.Drawing.Color.Teal;
            treeNode5.Name = "Node0";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "Padaria";
            treeNode6.Name = "Node11";
            treeNode6.Text = "Carne";
            treeNode7.Name = "Node12";
            treeNode7.Text = "Frango";
            treeNode8.ForeColor = System.Drawing.Color.Olive;
            treeNode8.Name = "Node10";
            treeNode8.Text = "Frios";
            treeNode9.Name = "Node14";
            treeNode9.Text = "Bolacha";
            treeNode10.Name = "Node15";
            treeNode10.Text = "Salgadinhos";
            treeNode11.ForeColor = System.Drawing.Color.Olive;
            treeNode11.Name = "Node13";
            treeNode11.Text = "Guloseimas";
            treeNode12.ForeColor = System.Drawing.Color.Teal;
            treeNode12.Name = "Node9";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode12.Text = "Supermercado";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(419, 375);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

