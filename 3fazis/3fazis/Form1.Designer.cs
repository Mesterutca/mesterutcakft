﻿namespace _3fazis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxeredetiar = new System.Windows.Forms.TextBox();
            this.textBoxakciosar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxtermekneve = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxkedvezmeny = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Termék hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Akció hozzáadása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 304);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Aktív";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eredeti ár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Akciós ár";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxeredetiar
            // 
            this.textBoxeredetiar.Location = new System.Drawing.Point(381, 141);
            this.textBoxeredetiar.Name = "textBoxeredetiar";
            this.textBoxeredetiar.ReadOnly = true;
            this.textBoxeredetiar.Size = new System.Drawing.Size(125, 27);
            this.textBoxeredetiar.TabIndex = 7;
            // 
            // textBoxakciosar
            // 
            this.textBoxakciosar.Location = new System.Drawing.Point(351, 298);
            this.textBoxakciosar.Name = "textBoxakciosar";
            this.textBoxakciosar.ReadOnly = true;
            this.textBoxakciosar.Size = new System.Drawing.Size(155, 27);
            this.textBoxakciosar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Termék neve:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxtermekneve
            // 
            this.textBoxtermekneve.Location = new System.Drawing.Point(381, 17);
            this.textBoxtermekneve.Name = "textBoxtermekneve";
            this.textBoxtermekneve.ReadOnly = true;
            this.textBoxtermekneve.Size = new System.Drawing.Size(125, 27);
            this.textBoxtermekneve.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kedvezmény";
            // 
            // textBoxkedvezmeny
            // 
            this.textBoxkedvezmeny.Location = new System.Drawing.Point(381, 185);
            this.textBoxkedvezmeny.Name = "textBoxkedvezmeny";
            this.textBoxkedvezmeny.ReadOnly = true;
            this.textBoxkedvezmeny.Size = new System.Drawing.Size(125, 27);
            this.textBoxkedvezmeny.TabIndex = 12;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(512, 469);
            this.Controls.Add(this.textBoxkedvezmeny);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxtermekneve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxakciosar);
            this.Controls.Add(this.textBoxeredetiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxeredetiar;
        private TextBox textBoxakciosar;
        private Label label3;
        private TextBox textBoxtermekneve;
        private Label label4;
        private TextBox textBoxkedvezmeny;
    }
}