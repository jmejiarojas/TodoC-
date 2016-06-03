using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Modelo3
{
    public partial class Reflection : Form
    {
        public Reflection()
        {
            InitializeComponent();
        }

        private void Reflection_Load(object sender, EventArgs e)
        {

        }

        private void lbClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvElementos.Items.Clear();

            if (lbClases.SelectedIndex == 0)
            {
                //Alumnos
                Alumno objAl = new Alumno();
                FieldInfo[] myFieldInfo;
                Type myType = typeof(Alumno);

                //Leemos la informacion y llenamos el arreglo myFieldInfo
                myFieldInfo = myType.GetFields(BindingFlags.NonPublic|
                    BindingFlags.Instance|BindingFlags.Public);

                for (int i = 0; i < myFieldInfo.Length; i++)
                {
                    ListViewItem fila = new ListViewItem(myFieldInfo[i].Name.ToString()
                        .Substring(1,myFieldInfo[i].Name.ToString()
                        .IndexOf(">")-1));
                    fila.SubItems.Add(myFieldInfo[i].FieldType.ToString());
                    fila.SubItems.Add(myFieldInfo[i].DeclaringType.ToString());
                    lvElementos.Items.Add(fila);
                }
            }
            else
            {
                Notas objAl = new Notas();
                FieldInfo[] myFieldInfo;
                Type myType = typeof(Notas);

                //Leemos la informacion y llenamos el arreglo myFieldInfo
                myFieldInfo = myType.GetFields(BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.Public);

                for (int i = 0; i < myFieldInfo.Length; i++)
                {
                    ListViewItem fila = new ListViewItem(myFieldInfo[i].Name.ToString()
                        .Substring(1, myFieldInfo[i].Name.ToString()
                        .IndexOf(">") - 1));
                    fila.SubItems.Add(myFieldInfo[i].FieldType.ToString()
                        .Substring(0, myFieldInfo[i].FieldType.ToString()
                        .IndexOf(".")));
                    fila.SubItems.Add(myFieldInfo[i].DeclaringType.ToString());
                    lvElementos.Items.Add(fila);
                }
            }
        }
    }
}
