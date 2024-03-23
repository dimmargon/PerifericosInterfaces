using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hyperic.Sigar;

namespace SigarGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cPUInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sigar sigar = new Sigar();

            Hyperic.Sigar.CpuInfo[] infos =
                sigar.CpuInfoList();

            textBox1.AppendText(infos.Length + " total CPUs..\r\n");

            foreach (Hyperic.Sigar.CpuInfo info in infos)
            {
                textBox1.AppendText("Vendor........" + info.Vendor + "\r\n");
                textBox1.AppendText("Model........." + info.Model + "\r\n");
                textBox1.AppendText("Mhz..........." + info.Mhz + "\r\n\r\n");
            }
        }

        private void dfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sigar sigar = new Sigar();

            foreach (FileSystem fs in sigar.FileSystemList())
            {
                FileSystemUsage usage;
                long used, avail, total, pct;

                try
                {
                    usage = sigar.FileSystemUsage(fs.DirName);

                    used = usage.Total - usage.Free;
                    avail = usage.Avail;
                    total = usage.Total;
                    pct = (long)(usage.UsePercent * 100);
                }
                catch (SigarException)
                {
                    used = avail = total = pct = 0;
                    continue;
                }

                string usePct;
                if (pct == 0)
                {
                    usePct = "-";
                }
                else
                {
                    usePct = pct + "%";
                }

                textBox1.AppendText(fs.DevName + "\t" +
                                         Sigar.FormatSize(total * 1024) + "\t" +
                                         Sigar.FormatSize(used * 1024) + "\t" +
                                         Sigar.FormatSize(avail * 1024) + "\t" +
                                         usePct + "\t" +
                                         fs.DirName + "\t" +
                                         fs.SysTypeName + "/" + fs.TypeName + "\r\n");
            }
        }

        private void freeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sigar sigar = new Sigar();

            Mem mem = sigar.Mem();
            Swap swap = sigar.Swap();

            textBox1.AppendText("\tTotal\t\tUsed\t\tFree\r\n");

            textBox1.AppendText("Mem:\t" +
                                     mem.Total / 1024 + "\t" +
                                     mem.Used / 1024 + "\t\t" +
                                     mem.Free / 1024 + "\r\n");

            textBox1.AppendText("Swap:\t" +
                                     swap.Total / 1024 + "\t" +
                                     swap.Used / 1024 + "\t" +
                                     swap.Free / 1024 + "\r\n");

            textBox1.AppendText("RAM:\t" + mem.Ram + "MB\r\n");
        }

        private void ifconfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sigar sigar = new Sigar();

            foreach (String name in sigar.NetInterfaceList())
            {
                NetInterfaceConfig ifconfig =
                sigar.NetInterfaceConfig(name);
                long flags = ifconfig.Flags;

                String hwaddr = "";
                if (!Sigar.NULL_HWADDR.Equals(ifconfig.Hwaddr))
                {
                    hwaddr = " HWaddr " + ifconfig.Hwaddr;
                }

                textBox1.AppendText(ifconfig.Name + "\t" +
                        "Link encap:" + ifconfig.Type +
                        hwaddr + "\r\n");

                String ptp = "";
                if ((flags & Sigar.IFF_POINTOPOINT) > 0)
                {
                    ptp = "  P-t-P:" + ifconfig.Destination;
                }

                String bcast = "";
                if ((flags & Sigar.IFF_BROADCAST) > 0)
                {
                    bcast = "  Bcast:" + ifconfig.Broadcast;
                }

                textBox1.AppendText("\t" +
                        "inet addr:" + ifconfig.Address +
                        ptp + //unlikely
                        bcast +
                        "  Mask:" + ifconfig.Netmask + "\r\n");

                textBox1.AppendText("\t" +
                        ifconfig.FlagsString() +
                        " MTU:" + ifconfig.Mtu +
                        "  Metric:" + ifconfig.Metric + "\r\n");
                try
                {
                    NetInterfaceStat ifstat =
                        sigar.NetInterfaceStat(name);

                    textBox1.AppendText("\t" +
                            "RX packets:" + ifstat.RxPackets +
                            " errors:" + ifstat.RxErrors +
                            " dropped:" + ifstat.RxDropped +
                            " overruns:" + ifstat.RxOverruns +
                            " frame:" + ifstat.RxFrame + "\r\n");

                    textBox1.AppendText("\t" +
                            "TX packets:" + ifstat.TxPackets +
                            " errors:" + ifstat.TxErrors +
                            " dropped:" + ifstat.TxDropped +
                            " overruns:" + ifstat.TxOverruns +
                            " carrier:" + ifstat.TxCarrier + "\r\n");
                    textBox1.AppendText("\t" + "collisions:" +
                            ifstat.TxCollisions + "\r\n");

                    long rxBytes = ifstat.RxBytes;
                    long txBytes = ifstat.TxBytes;

                    textBox1.AppendText("\t" +
                            "RX bytes:" + rxBytes +
                            " (" + Sigar.FormatSize(rxBytes) + ")" +
                            "  " +
                            "TX bytes:" + txBytes +
                            " (" + Sigar.FormatSize(txBytes) + ")\r\n\r\n");
                }
                catch (SigarException) { }

                
            }
        }
    }
}
