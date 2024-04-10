using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace p6_S1_ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher mosDisks = new
           ManagementObjectSearcher
            ("SELECT * FROM Win32_DiskDrive WHERE Model = '" +
           cmb.SelectedItem + "'");
            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                type.Text = "Type: " + moDisk["MediaType"].ToString();
                model.Text = "Model: " + moDisk["Model"].ToString();
                serial.Text = "Serial: " + moDisk["SerialNumber"].ToString();
                interf.Text = "Interface: " + moDisk["InterfaceType"].ToString();
                capacity.Text = "Capacity: " + moDisk["Size"].ToString() +
                    " bytes (" + Math.Round(((((double)Convert.ToDouble(moDisk["Size"])
                    / 1024) / 1024) / 1024), 2) + "GB)";
                partitions.Text = "Partitions: " + moDisk["Partitions"].ToString();
                //signature.Text = "Signature: " + moDisk["Signature"].ToString();
                firmware.Text = "Firmware: " + moDisk["FirmwareRevision"].ToString();
                cylinders.Text = "Cylinders: " + moDisk["TotalCylinders"].ToString();
                sectors.Text = "Sectors: " + moDisk["TotalSectors"].ToString();
                bytesSector.Text = "Bytes per Sector: " + moDisk["BytesPerSector"].ToString();
                sectorsTrack.Text = "Sectors per Track: " + moDisk["SectorsPerTrack"].ToString();
                trackCylinder.Text = "Tracks per Cylinder: " + moDisk["TracksPerCylinder"].ToString();
                heads.Text = "Heads: " + moDisk["TotalHeads"].ToString();
                tracks.Text = "Tracks: " + moDisk["TotalTracks"].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher mosDisks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject moDisk in mosDisks.Get())
            {
                cmb.Items.Add(moDisk["Model"].ToString());
            }
        }
    }
}

