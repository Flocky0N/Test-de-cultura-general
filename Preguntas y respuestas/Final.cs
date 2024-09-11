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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {
            // Mostrar el puntaje final usando label
            lblRespuestasBien.Text = "Una cantidad de: " + Form1.respuestaCorrecta;
            lblRespuestasMal.Text = "Una cantidad de: " + Form1.respuestaIncorrecta;


        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Crear la instancia del siguiente formulario
            Form1 form1 = new Form1();

            // Configurar la posición del siguiente formulario
            form1.StartPosition = FormStartPosition.Manual;       // Usar posición manual
            form1.Location = this.Location;                      // Posicionar en la misma ubicación

            // Abrir el siguiente formulario
            form1.Show();
            this.Hide();
        }
    }
}
