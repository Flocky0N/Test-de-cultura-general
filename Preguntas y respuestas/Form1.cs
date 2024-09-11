using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preguntas_y_respuestas
{
    public partial class Form1 : Form
    {
        // Contador para respuestas correctas e incorrectas
        public static int respuestaCorrecta = 0;  
        public static int respuestaIncorrecta = 0;    
        public Form1() 
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Crear la instancia del siguiente formulario
            Pregunta1 pregunta1 = new Pregunta1();

            // Configurar la posición del siguiente formulario
            pregunta1.StartPosition = FormStartPosition.Manual;       // Usar posición manual
            pregunta1.Location = this.Location;                      // Posicionar en la misma ubicación

            // Abrir el siguiente formulario
            pregunta1.Show();
            this.Hide();  
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
