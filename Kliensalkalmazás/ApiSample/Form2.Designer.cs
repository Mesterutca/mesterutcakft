namespace ApiSample
{
    partial class Form2
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
            this.textBoxDiscountName = new System.Windows.Forms.TextBox();
            this.textBoxDiscountValue = new System.Windows.Forms.TextBox();
            this.buttonCreateDiscount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDiscountName
            // 
            this.textBoxDiscountName.Location = new System.Drawing.Point(12, 55);
            this.textBoxDiscountName.Name = "textBoxDiscountName";
            this.textBoxDiscountName.Size = new System.Drawing.Size(166, 22);
            this.textBoxDiscountName.TabIndex = 0;
            // 
            // textBoxDiscountValue
            // 
            this.textBoxDiscountValue.Location = new System.Drawing.Point(12, 119);
            this.textBoxDiscountValue.Name = "textBoxDiscountValue";
            this.textBoxDiscountValue.Size = new System.Drawing.Size(93, 22);
            this.textBoxDiscountValue.TabIndex = 1;
            // 
            // buttonCreateDiscount
            // 
            this.buttonCreateDiscount.Location = new System.Drawing.Point(12, 164);
            this.buttonCreateDiscount.Name = "buttonCreateDiscount";
            this.buttonCreateDiscount.Size = new System.Drawing.Size(93, 23);
            this.buttonCreateDiscount.TabIndex = 2;
            this.buttonCreateDiscount.Text = "Létrehozás";
            this.buttonCreateDiscount.UseVisualStyleBackColor = true;
            this.buttonCreateDiscount.Click += new System.EventHandler(this.buttonCreateDiscount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Új Akció Neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Új Akció Kedvezménye(%)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateDiscount);
            this.Controls.Add(this.textBoxDiscountValue);
            this.Controls.Add(this.textBoxDiscountName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDiscountName;
        private System.Windows.Forms.TextBox textBoxDiscountValue;
        private System.Windows.Forms.Button buttonCreateDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}