using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Crear_Cuenta : Form
    {
        registrar usuario = new registrar();
        public Crear_Cuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            Form1 seg = new Form1();
            seg.ShowDialog();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            usuario = new registrar();
            /*usuario.ESTADO1 = usuario.Text;*/
            

            usuario.nombre = nombre.Text;
            usuario.apellidos = apellidos.Text;
            usuario.correo= correo.Text;
            usuario.opcion= opcion.Text;
            usuario.fecha = Convert.ToDateTime(fecha.Text);
            usuario.contraseña = contraseña.Text;
            
            
            Cglobal.listaValores.Add(usuario);


            /*ESTADO1.Text = "";*/
            nombre.Text = "";
            apellidos.Text = "";
            correo.Text = "";
            fecha.Text = "";

            contraseña.Text = "";
            opcion.Text = "";
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Crear_Cuenta_Load(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
