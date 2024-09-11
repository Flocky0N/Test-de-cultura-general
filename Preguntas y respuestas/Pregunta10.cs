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
    public partial class Pregunta10 : Form
    {
        public Pregunta10()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!rbtnOpcion1.Checked && !rbtnOpcion2.Checked && !rbtnOpcion3.Checked)
            {
                // Si ninguna opción está seleccionada, mostrar un mensaje y no continuar
                MessageBox.Show("Seleccione una opción antes de continuar.");
                return; // Salir del evento para evitar que el usuario continúe
            }

            // Verificar si la Opción 1 fue seleccionada (correcta)
            if (rbtnOpcion1.Checked)
            {
                Form1.respuestaCorrecta++;
                MessageBox.Show("Respuesta correcta");
            }
            else
            {
                Form1.respuestaIncorrecta++;
                MessageBox.Show("Respuesta incorrecta");
            }

            // Crear la instancia del siguiente formulario
            Final final= new Final();

            // Configurar la posición del siguiente formulario
            final.StartPosition = FormStartPosition.Manual;       // Usar posición manual
            final.Location = this.Location;                      // Posicionar en la misma ubicación

            // Abrir el siguiente formulario
            final.Show();
            this.Hide();
        }

        private void btnDetener_Click(object sender, EventArgs e)
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

        private void Pregunta10_Load(object sender, EventArgs e)
        {
            rbtnOpcion1.TabStop = false;
            rbtnOpcion2.TabStop = false;
            rbtnOpcion3.TabStop = false;
        }
    }
}
