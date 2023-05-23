namespace ApiSample
{
    partial class Form3
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
            this.listBoxAllProducts = new System.Windows.Forms.ListBox();
            this.listBoxCategoryProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAllProducts
            // 
            this.listBoxAllProducts.FormattingEnabled = true;
            this.listBoxAllProducts.ItemHeight = 16;
            this.listBoxAllProducts.Location = new System.Drawing.Point(12, 89);
            this.listBoxAllProducts.Name = "listBoxAllProducts";
            this.listBoxAllProducts.Size = new System.Drawing.Size(150, 308);
            this.listBoxAllProducts.TabIndex = 0;
            this.listBoxAllProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxAllProducts_SelectedIndexChanged);
            // 
            // listBoxCategoryProducts
            // 
            this.listBoxCategoryProducts.FormattingEnabled = true;
            this.listBoxCategoryProducts.ItemHeight = 16;
            this.listBoxCategoryProducts.Location = new System.Drawing.Point(236, 89);
            this.listBoxCategoryProducts.Name = "listBoxCategoryProducts";
            this.listBoxCategoryProducts.Size = new System.Drawing.Size(150, 308);
            this.listBoxCategoryProducts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Összes termék";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiválasztott kategóriába";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "rendelt termékek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Összes termék lista csak azokat a termékeket tartalmazza, ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "melyek egy kategóriához sincsenek rendelve";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCategoryProducts);
            this.Controls.Add(this.listBoxAllProducts);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllProducts;
        private System.Windows.Forms.ListBox listBoxCategoryProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}