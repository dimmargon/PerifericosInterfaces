namespace p2
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
            this.btn_DatosSis = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Acerca = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_DatosSis
            // 
            this.btn_DatosSis.Location = new System.Drawing.Point(109, 61);
            this.btn_DatosSis.Name = "btn_DatosSis";
            this.btn_DatosSis.Size = new System.Drawing.Size(103, 23);
            this.btn_DatosSis.TabIndex = 0;
            this.btn_DatosSis.Text = "Datos del Sistema";
            this.btn_DatosSis.UseVisualStyleBackColor = true;
            this.btn_DatosSis.Click += new System.EventHandler(this.btn_DatosSis_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(585, 61);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Acerca
            // 
            this.btn_Acerca.Location = new System.Drawing.Point(585, 289);
            this.btn_Acerca.Name = "btn_Acerca";
            this.btn_Acerca.Size = new System.Drawing.Size(75, 23);
            this.btn_Acerca.TabIndex = 2;
            this.btn_Acerca.Text = "Acerca de...";
            this.btn_Acerca.UseVisualStyleBackColor = true;
            this.btn_Acerca.Click += new System.EventHandler(this.btn_Acerca_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(109, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(551, 193);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Acerca);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_DatosSis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DatosSis;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Acerca;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

