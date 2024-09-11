
namespace Preguntas_y_respuestas
{
    partial class Pregunta2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregunta2));
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Qué tipo de animal es la ballena?";
            // 
            // rbtnOpcion1
            // 
            this.rbtnOpcion1.AutoSize = true;
            this.rbtnOpcion1.Location = new System.Drawing.Point(112, 179);
            this.rbtnOpcion1.Name = "rbtnOpcion1";
            this.rbtnOpcion1.Size = new System.Drawing.Size(70, 17);
            this.rbtnOpcion1.TabIndex = 7;
            this.rbtnOpcion1.TabStop = true;
            this.rbtnOpcion1.Text = "Mamífero";
            this.rbtnOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion2
            // 
            this.rbtnOpcion2.AutoSize = true;
            this.rbtnOpcion2.Location = new System.Drawing.Point(110, 144);
            this.rbtnOpcion2.Name = "rbtnOpcion2";
            this.rbtnOpcion2.Size = new System.Drawing.Size(43, 17);
            this.rbtnOpcion2.TabIndex = 8;
            this.rbtnOpcion2.TabStop = true;
            this.rbtnOpcion2.Text = "Pez";
            this.rbtnOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbtnOpcion3
            // 
            this.rbtnOpcion3.AutoSize = true;
            this.rbtnOpcion3.Location = new System.Drawing.Point(110, 107);
            this.rbtnOpcion3.Name = "rbtnOpcion3";
            this.rbtnOpcion3.Size = new System.Drawing.Size(52, 17);
            this.rbtnOpcion3.TabIndex = 9;
            this.rbtnOpcion3.TabStop = true;
            this.rbtnOpcion3.Text = "Reptil";
            this.rbtnOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContinuar.Location = new System.Drawing.Point(104, 253);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetener.Location = new System.Drawing.Point(256, 253);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 11;
            this.btnDetener.Text = "Detener ";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Pregunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rbtnOpcion3);
            this.Controls.Add(this.rbtnOpcion2);
            this.Controls.Add(this.rbtnOpcion1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregunta2";
            this.Text = "Pregunta 2";
            this.Load += new System.EventHandler(this.Pregunta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnOpcion1;
        private System.Windows.Forms.RadioButton rbtnOpcion2;
        private System.Windows.Forms.RadioButton rbtnOpcion3;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}