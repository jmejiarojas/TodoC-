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
using Microsoft.VisualBasic;


namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno objA = new Alumno();
            FieldInfo[] myFieldInfo;
            Type myType = typeof(Alumno);

            myFieldInfo = myType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                ListViewItem fila = new ListViewItem(myFieldInfo[i].Name.ToString().
                    Substring(1,myFieldInfo[i].Name.ToString().IndexOf(">")-1));
                fila.SubItems.Add(myFieldInfo[i].FieldType.ToString());
                fila.SubItems.Add(myFieldInfo[i].DeclaringType.ToString());
                lvResultados.Items.Add(fila);
            }
        }
    }
}
