using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FTPManager;
using FileTransferProtocolLib;

namespace FTPManagerApp
{
    public partial class Form1 : Form
    {
        FTPManagerClass client;
        FTP manager;
        public Form1()
        {
            InitializeComponent();
        }

        string[] files;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string a = dgV.Rows[e.RowIndex].Cells[0].Value.ToString();

            if( a == "." || a == "..")
            {
                string[] b = tbHost.Text.Split('/');
                tbHost.Text = "ftp://";
                for (int i = 2; i < b.Length - 2; i++)
                {
                    if (b[i] == "")
                        continue;
                    tbHost.Text += b[i] + "/";
                }
            }
            else
                tbHost.Text += a + "/";

            files = manager.FilesOnServer(dgV.Rows[e.RowIndex].Cells[0].Value.ToString());
            dgV.Rows.Clear();
            foreach (string file in files)
            {
                dgV.Rows.Add(file);
            }

            client = new FTPManagerClass(tbN.Text, tbPass.Text, tbHost.Text );
            manager = new FTP(tbHost.Text, tbN.Text, tbPass.Text);
            ods();
        }
 

        private void ods(object sender, EventArgs e)
        {
            dgV.Rows.Clear();
            files = manager.FilesOnServer("");
            foreach (string filename in files)
            {
                dgV.Rows.Add(filename);
            }
        }

        private void login(object sender, EventArgs e)
        {
            client = new FTPManagerClass(tbN.Text, tbPass.Text, tbHost.Text);
            manager = new FTP(tbHost.Text, tbN.Text, tbPass.Text);
            ods();
        }

        private void rename(object sender, EventArgs e)
        {
            manager.ReName(tbRp.Text, tbRn.Text);
            ods();
        }

        private void btnCreateF(object sender, EventArgs e)
        {
            manager.CreateDirectory(tbF.Text);
            ods();
        }

        public void ods()
        {
                dgV.Rows.Clear();
                files = manager.FilesOnServer("");
                foreach (string filename in files)
                {
                    dgV.Rows.Add(filename);
                }
            }
        }
}
