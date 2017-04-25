using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_03_Registo__de__Participantes
{
    public partial class Form1 : Form



    {
        List<Personal> Personal = new List<Personal>();





        public Form1()
        {
            InitializeComponent();
        }



        void Listado()
        {
            lvparticipante.Items.Clear();
            foreach(Personal reg in Personal)
            {
                ListViewItem it = new ListViewItem(reg.dni);
                it.SubItems.Add(reg.nombre);
                it.SubItems.Add(reg.apellido);
                it.SubItems.Add(reg.telefono);
                it.SubItems.Add(reg.telefono);
                it.SubItems.Add(reg.email);
                it.SubItems.Add(reg.Fecha.ToString());
                lvparticipante.Items.Add(it);


               

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Personal reg = new Personal();
            reg.dni = txtdni.Text;
            reg.nombre = txtnombre.Text;
            reg.apellido = txtape.Text;
            reg.telefono = txttelefono.Text;
            reg.email = txtemail.Text;
            reg.Fecha = DateTime.Parse(txtFecha.Text);


            Personal.Add(reg);

            Listado();


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach(Personal reg in Personal)
            {
                if(reg.dni==txtdni.Text)
                {
                    reg.nombre = txtnombre.Text;
                    reg.apellido = txtape.Text;
                    reg.telefono = txttelefono.Text;
                    reg.email = txtemail.Text;
                    reg.Fecha = DateTime.Parse(txtFecha.Text);
                    break;
                }
            }
            Listado();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtdni.Clear();
            txtnombre.Clear();
            txtape.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtFecha.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Personal reg in Personal)
            {
                if (reg.dni == txtdni.Text)
                {
                    Personal.Remove(reg);
                    break;
                }
            }
            Listado();
        }

        private void lvparticipante_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListViewItem it = lvparticipante.SelectedItems[0];
            reg.dni = txtdni.Text;
            reg.nombre = txtnombre.Text;
            reg.apellido = txtape.Text;
            reg.telefono = txttelefono.Text;
            reg.email = txtemail.Text;
            reg.Fecha = DateTime.Parse(txtFecha.Text);

        }
    }
}
