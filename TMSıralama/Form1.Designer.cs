﻿namespace TMSıralama
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
            this.txtDiziBoyutu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiziBoyutu
            // 
            this.txtDiziBoyutu.Location = new System.Drawing.Point(207, 24);
            this.txtDiziBoyutu.Name = "txtDiziBoyutu";
            this.txtDiziBoyutu.Size = new System.Drawing.Size(152, 20);
            this.txtDiziBoyutu.TabIndex = 0;
            this.txtDiziBoyutu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiziBoyutu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sıralama Yapılacak Dizi Boyutu :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "DİZİYİ OLUŞTUR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(423, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiziBoyutu);
            this.MaximumSize = new System.Drawing.Size(439, 187);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 187);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design to Turing Machine ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiziBoyutu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

