﻿namespace p4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyPressedTbx = new System.Windows.Forms.TextBox();
            this.ScanCodeTbx = new System.Windows.Forms.TextBox();
            this.StatusTbx = new System.Windows.Forms.TextBox();
            this.KeyReleasedTbx = new System.Windows.Forms.TextBox();
            this.EntryTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mouse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Right-Click";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Middle-Click";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(408, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 239);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Keyboard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Key Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Key Pressed / ScanCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Left-Click";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Key Released";
            // 
            // KeyPressedTbx
            // 
            this.KeyPressedTbx.Location = new System.Drawing.Point(62, 171);
            this.KeyPressedTbx.Name = "KeyPressedTbx";
            this.KeyPressedTbx.ReadOnly = true;
            this.KeyPressedTbx.Size = new System.Drawing.Size(43, 20);
            this.KeyPressedTbx.TabIndex = 19;
            // 
            // ScanCodeTbx
            // 
            this.ScanCodeTbx.Location = new System.Drawing.Point(136, 171);
            this.ScanCodeTbx.Name = "ScanCodeTbx";
            this.ScanCodeTbx.ReadOnly = true;
            this.ScanCodeTbx.Size = new System.Drawing.Size(45, 20);
            this.ScanCodeTbx.TabIndex = 18;
            // 
            // StatusTbx
            // 
            this.StatusTbx.Location = new System.Drawing.Point(62, 324);
            this.StatusTbx.Name = "StatusTbx";
            this.StatusTbx.ReadOnly = true;
            this.StatusTbx.Size = new System.Drawing.Size(100, 20);
            this.StatusTbx.TabIndex = 17;
            // 
            // KeyReleasedTbx
            // 
            this.KeyReleasedTbx.Location = new System.Drawing.Point(62, 255);
            this.KeyReleasedTbx.Name = "KeyReleasedTbx";
            this.KeyReleasedTbx.ReadOnly = true;
            this.KeyReleasedTbx.Size = new System.Drawing.Size(163, 20);
            this.KeyReleasedTbx.TabIndex = 16;
            // 
            // EntryTbx
            // 
            this.EntryTbx.Location = new System.Drawing.Point(62, 87);
            this.EntryTbx.Name = "EntryTbx";
            this.EntryTbx.Size = new System.Drawing.Size(163, 20);
            this.EntryTbx.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyPressedTbx);
            this.Controls.Add(this.ScanCodeTbx);
            this.Controls.Add(this.StatusTbx);
            this.Controls.Add(this.KeyReleasedTbx);
            this.Controls.Add(this.EntryTbx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyPressedTbx;
        private System.Windows.Forms.TextBox ScanCodeTbx;
        private System.Windows.Forms.TextBox StatusTbx;
        private System.Windows.Forms.TextBox KeyReleasedTbx;
        private System.Windows.Forms.TextBox EntryTbx;
    }
}

