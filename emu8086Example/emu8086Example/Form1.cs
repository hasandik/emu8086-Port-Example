using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace emu8086Example
{
    public partial class Form1 : Form
    {
        private static string sIO_FILE;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int gelen = 1;
            gelen = READ_IO_BYTE(100);
            if (gelen == 1)
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }

        }
        public static System.Byte READ_IO_BYTE(long lPORT_NUM)
        {
            StringBuilder sTempDir = new StringBuilder(500);
            string sFilename = null;
            //you should activate the following codes when change the filepath
            sIO_FILE = "filepath";
            sFilename = sIO_FILE;
            //FileStream rdr = new FileStream(sFilename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //rdr.Seek(lPORT_NUM, SeekOrigin.Begin);
            //int ch = rdr.ReadByte();
            //rdr.Close();
            //return (System.Byte)ch;
            return 0;
        }

    }

}
