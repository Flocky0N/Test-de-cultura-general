
namespace Preguntas_y_respuestas
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRespuestasBien = new System.Windows.Forms.Label();
            this.lblRespuestasMal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(263, 225);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 41;
            this.btnDetener.Text = "Cerrar";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(98, 225);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 40;
            this.btnContinuar.Text = "Inicio";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(140, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Respuestas Correctas:";
            // 
            // lblRespuestasBien
            // 
            this.lblRespuestasBien.AutoSize = true;
            this.lblRespuestasBien.Location = new System.Drawing.Point(141, 89);
            this.lblRespuestasBien.Name = "lblRespuestasBien";
            this.lblRespuestasBien.Size = new System.Drawing.Size(10, 13);
            this.lblRespuestasBien.TabIndex = 42;
            this.lblRespuestasBien.Text = ":";
            // 
            // lblRespuestasMal
            // 
            this.lblRespuestasMal.AutoSize = true;
            this.lblRespuestasMal.Location = new System.Drawing.Point(141, 159);
            this.lblRespuestasMal.Name = "lblRespuestasMal";
            this.lblRespuestasMal.Size = new System.Drawing.Size(10, 13);
            this.lblRespuestasMal.TabIndex = 43;
            this.lblRespuestasMal.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(140, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Respuestas Incorrectas:";
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRespuestasMal);
            this.Controls.Add(this.lblRespuestasBien);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Final";
            this.Text = "Final";
            this.Load += new System.EventHandler(this.Final_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespuestasBien;
        private System.Windows.Forms.Label lblRespuestasMal;
        private System.Windows.Forms.Label label2;
    }
}