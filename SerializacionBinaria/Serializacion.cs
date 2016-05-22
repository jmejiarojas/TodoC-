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
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacionBinaria
{
    public partial class Serializacion : Form
    {
        static int n;
        public Serializacion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno objA = new Alumno();
                objA.codigo = txtCodigo.Text;
                objA.apellidos = txtApellidos.Text;
                objA.nombres = txtNombres.Text;
                objA.email = txtEmail.Text;
                objA.foto = (Bitmap)(pbFoto.Image);

                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Archivo Binario|*.bin";

                if(sv.ShowDialog() == DialogResult.OK)
                {
                    using(FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, objA);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Imagenes JPG|*.jpg";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(op.FileName);
                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Archivo Binario|*.bin";

                if(op.ShowDialog() == DialogResult.OK)
                {
                    using(FileStream fs = new FileStream(op.FileName, FileMode.Open))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        Alumno alumno = (Alumno)(bf.Deserialize(fs));

                        txtCodigo.Text = alumno.codigo;
                        txtApellidos.Text = alumno.apellidos;
                        txtNombres.Text = alumno.nombres;
                        txtEmail.Text = alumno.email;

                        pbFoto.Image = alumno.foto;
                        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
