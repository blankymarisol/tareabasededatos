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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void buttonPrueba_Click(object sender, EventArgs e) //boton para confirmar la conexion con la base de datos
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

        private void buttonCargar_Click(object sender, EventArgs e) //boton para cargar los datos 
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void buttoncrear_Click(object sender, EventArgs e) //boton para crear un nuevo ingreso de datos
        {
            string nombre = textBoxnombre.Text;
            string raza = comboBoxraza.Text;
            int nivelpoder = (int)numericUpDown1.Value;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxraza.Items.AddRange(razasDragonBall);
        }

        private void Buscarporid() 
        {
            int idpersonajebuscar = int.Parse(textboxid.Text);
            DataTable personajeencontrado = personaje.BuscarPersonajePorId(idpersonajebuscar);
            if (personajeencontrado.Rows.Count > 0)
            {
                string nombre = personajeencontrado.Rows[0]["nombre"].ToString();
                string raza = personajeencontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeencontrado.Rows[0]["nivel_poder"].ToString());
                DateTime FechaCreacion = DateTime.Parse(personajeencontrado.Rows[0]["Fecha_Creacion"].ToString());
                string historia = personajeencontrado.Rows[0]["Historia"].ToString();
                textBoxnombre.Text = nombre;
                comboBoxraza.Text = raza;
                numericUpDown1.Value = nivelPoder;
                dateTimePicker1.Value = FechaCreacion;
                textBoxHistoria.Text = historia;
            }

            else
            {
                MessageBox.Show("no se encontro el codigo");
            }
        }

        private void BuscarNombre()
        {
            string nombrePersonajeBuscar = textBoxnombre.Text;
            DataTable nombreEncontrado = personaje.NombreBuscar(nombrePersonajeBuscar);

            if (nombreEncontrado.Rows.Count > 0)
            {
                int Id = int.Parse(nombreEncontrado.Rows[0]["id"].ToString());
                string raza = nombreEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(nombreEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime FechaCreacion = DateTime.Parse(nombreEncontrado.Rows[0]["Fecha_Creacion"].ToString());
                string historia = nombreEncontrado.Rows[0]["Historia"].ToString();
                textboxid.Text = Id.ToString();
                comboBoxraza.Text = raza;
                numericUpDown1.Value = nivelPoder;
                dateTimePicker1.Value = FechaCreacion;
                textBoxHistoria.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontró el nombre.");
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            Buscarporid();
        }

        private void comboBoxraza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxraza.Text = " ";
            textBoxHistoria.Text = "";
            textboxid.Text = "";
            numericUpDown1.Value = numericUpDown1.Minimum;
            textBoxnombre.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}