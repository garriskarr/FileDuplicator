using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDuplicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            string strBrowsePath = ofdOpenFile.FileName;
            string strDestinationPath = sfdSaveFile.FileName;
            FileStream fsBrowseFile = File.Open(strBrowsePath, FileMode.Open, FileAccess.Read);
            FileStream fsDestinationFile = File.Open(strDestinationPath, FileMode.Create, FileAccess.Write); ;
            byte[] aByte = new byte[4096];
            int iByteRead = 0;
            while ((iByteRead = fsBrowseFile.Read(aByte, 0, 4096)) > )
            {
            
                    fsDestinationFile.Write(aByte, 0, iByteRead);
            }
            fsBrowseFile.Close();
            fsDestinationFile.Close();
            MessageBox.Show("File Copied Successfully!");
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofdOpenFile.ShowDialog();
            if(drResult == DialogResult.OK)
            {
                string strBrowsePath = ofdOpenFile.FileName;
                txtSource.Text = strBrowsePath;
            }
        }

        private void btnBB_Click(object sender, EventArgs e)
        {
            DialogResult drResult = sfdSaveFile.ShowDialog();
            if(drResult == DialogResult.OK)
            {
                string strDestinationPath = sfdSaveFile.FileName;
                txtDestination.Text = strDestinationPath;
            }
        }
    }
}
