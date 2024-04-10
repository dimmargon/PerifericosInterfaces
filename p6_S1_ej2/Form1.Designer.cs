namespace p6_S1_ej2
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
            this.cmb = new System.Windows.Forms.ComboBox();
            this.selectDrive = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.serial = new System.Windows.Forms.Label();
            this.interf = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.partitions = new System.Windows.Forms.Label();
            this.heads = new System.Windows.Forms.Label();
            this.tracks = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.Label();
            this.firmware = new System.Windows.Forms.Label();
            this.cylinders = new System.Windows.Forms.Label();
            this.sectors = new System.Windows.Forms.Label();
            this.bytesSector = new System.Windows.Forms.Label();
            this.sectorsTrack = new System.Windows.Forms.Label();
            this.trackCylinder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(58, 46);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(249, 21);
            this.cmb.TabIndex = 0;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // selectDrive
            // 
            this.selectDrive.AutoSize = true;
            this.selectDrive.Location = new System.Drawing.Point(58, 30);
            this.selectDrive.Name = "selectDrive";
            this.selectDrive.Size = new System.Drawing.Size(66, 13);
            this.selectDrive.TabIndex = 1;
            this.selectDrive.Text = "Select drive:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(12, 102);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 2;
            this.type.Text = "Type";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(12, 126);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(36, 13);
            this.model.TabIndex = 3;
            this.model.Text = "Model";
            // 
            // serial
            // 
            this.serial.AutoSize = true;
            this.serial.Location = new System.Drawing.Point(12, 150);
            this.serial.Name = "serial";
            this.serial.Size = new System.Drawing.Size(43, 13);
            this.serial.TabIndex = 4;
            this.serial.Text = "Serial #";
            // 
            // interf
            // 
            this.interf.AutoSize = true;
            this.interf.Location = new System.Drawing.Point(12, 173);
            this.interf.Name = "interf";
            this.interf.Size = new System.Drawing.Size(49, 13);
            this.interf.TabIndex = 5;
            this.interf.Text = "Interface";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(12, 197);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(48, 13);
            this.capacity.TabIndex = 6;
            this.capacity.Text = "Capacity";
            // 
            // partitions
            // 
            this.partitions.AutoSize = true;
            this.partitions.Location = new System.Drawing.Point(12, 219);
            this.partitions.Name = "partitions";
            this.partitions.Size = new System.Drawing.Size(50, 13);
            this.partitions.TabIndex = 7;
            this.partitions.Text = "Partitions";
            // 
            // heads
            // 
            this.heads.AutoSize = true;
            this.heads.Location = new System.Drawing.Point(188, 288);
            this.heads.Name = "heads";
            this.heads.Size = new System.Drawing.Size(38, 13);
            this.heads.TabIndex = 8;
            this.heads.Text = "Heads";
            // 
            // tracks
            // 
            this.tracks.AutoSize = true;
            this.tracks.Location = new System.Drawing.Point(188, 312);
            this.tracks.Name = "tracks";
            this.tracks.Size = new System.Drawing.Size(40, 13);
            this.tracks.TabIndex = 9;
            this.tracks.Text = "Tracks";
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Location = new System.Drawing.Point(12, 243);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(52, 13);
            this.signature.TabIndex = 10;
            this.signature.Text = "Signature";
            // 
            // firmware
            // 
            this.firmware.AutoSize = true;
            this.firmware.Location = new System.Drawing.Point(12, 267);
            this.firmware.Name = "firmware";
            this.firmware.Size = new System.Drawing.Size(49, 13);
            this.firmware.TabIndex = 11;
            this.firmware.Text = "Firmware";
            // 
            // cylinders
            // 
            this.cylinders.AutoSize = true;
            this.cylinders.Location = new System.Drawing.Point(12, 288);
            this.cylinders.Name = "cylinders";
            this.cylinders.Size = new System.Drawing.Size(49, 13);
            this.cylinders.TabIndex = 12;
            this.cylinders.Text = "Cylinders";
            // 
            // sectors
            // 
            this.sectors.AutoSize = true;
            this.sectors.Location = new System.Drawing.Point(12, 312);
            this.sectors.Name = "sectors";
            this.sectors.Size = new System.Drawing.Size(43, 13);
            this.sectors.TabIndex = 13;
            this.sectors.Text = "Sectors";
            // 
            // bytesSector
            // 
            this.bytesSector.AutoSize = true;
            this.bytesSector.Location = new System.Drawing.Point(12, 336);
            this.bytesSector.Name = "bytesSector";
            this.bytesSector.Size = new System.Drawing.Size(85, 13);
            this.bytesSector.TabIndex = 14;
            this.bytesSector.Text = "Bytes per Sector";
            // 
            // sectorsTrack
            // 
            this.sectorsTrack.AutoSize = true;
            this.sectorsTrack.Location = new System.Drawing.Point(12, 358);
            this.sectorsTrack.Name = "sectorsTrack";
            this.sectorsTrack.Size = new System.Drawing.Size(92, 13);
            this.sectorsTrack.TabIndex = 15;
            this.sectorsTrack.Text = "Sectors per Track";
            // 
            // trackCylinder
            // 
            this.trackCylinder.AutoSize = true;
            this.trackCylinder.Location = new System.Drawing.Point(12, 380);
            this.trackCylinder.Name = "trackCylinder";
            this.trackCylinder.Size = new System.Drawing.Size(98, 13);
            this.trackCylinder.TabIndex = 16;
            this.trackCylinder.Text = "Tracks per Cylinder";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::p6_S1_ej2.Properties.Resources.HDDIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackCylinder);
            this.Controls.Add(this.sectorsTrack);
            this.Controls.Add(this.bytesSector);
            this.Controls.Add(this.sectors);
            this.Controls.Add(this.cylinders);
            this.Controls.Add(this.firmware);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.tracks);
            this.Controls.Add(this.heads);
            this.Controls.Add(this.partitions);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.interf);
            this.Controls.Add(this.serial);
            this.Controls.Add(this.model);
            this.Controls.Add(this.type);
            this.Controls.Add(this.selectDrive);
            this.Controls.Add(this.cmb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label selectDrive;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label serial;
        private System.Windows.Forms.Label interf;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label partitions;
        private System.Windows.Forms.Label heads;
        private System.Windows.Forms.Label tracks;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.Label firmware;
        private System.Windows.Forms.Label cylinders;
        private System.Windows.Forms.Label sectors;
        private System.Windows.Forms.Label bytesSector;
        private System.Windows.Forms.Label sectorsTrack;
        private System.Windows.Forms.Label trackCylinder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

