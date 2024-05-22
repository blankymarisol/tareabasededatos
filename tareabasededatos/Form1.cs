using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tareabasededatos.DATA.DataAccess;

namespace tareabasededatos
{
    public partial class Form1 : Form
    {
        //definimos una variable de instancia ref a la Clase PersonajesDB
        private PersonajesBD personaje;
        // Lista de razas
        private string[] razasDragonBall = {
    "Android",
    "Bio-Android",
    "Humana",
    "Humano",
    "Majin",
    "Namekuseijin",
    "Saiyajin",
    "Saiyajin/Humano",
    "Saiyajin/Saiyajin"
    };
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajesBD();
        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Simoncho!!!!");
            }
            else
            {
                MessageBox.Show("Nel Pastel");
            }

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            string raza = comboBoxRaza.Text;
            int nivelpoder = (int)numericUpDownpower.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelpoder);
            if (respuesta > 0)
            {
                MessageBox.Show("Creado con Exito");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("La cagaste");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBoxRaza.Items.AddRange(razasDragonBall);
        }

        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(label1.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelpoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());

                textBoxnombre.Text = nombre;
                comboBoxRaza.Text = raza;
                numericUpDownpower.Value = nivelpoder;

            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void id_Leave(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        
    }
}