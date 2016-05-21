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
using System.IO.Compression;


namespace CompresionFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.Write(txtEditor.Text);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo Zipeado|*.zip";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                //Emviando la informacion a espacio de memoria
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(txtEditor.Text);
                sw.Flush();

                //Comprimir los datos de la memoria
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                GZipStream zip = new GZipStream(fs,CompressionMode.Compress);
                zip.Write(ms.ToArray(), 0, ms.ToArray().Length);
                zip.Close();
                fs.Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo Zipeado|*.zip";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                GZipStream zip = new GZipStream(fs,CompressionMode.Decompress);

                byte[] datos = new byte[4096];
                zip.Read(datos, 0, datos.Length);
                MemoryStream ms = new MemoryStream();
                ms.Write(datos, 0, datos.Length);

                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                txtEditor.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
