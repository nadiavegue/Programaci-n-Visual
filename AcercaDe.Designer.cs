using System;
using System.Windows.Forms;

namespace reloj
{
    partial class AcercaDe
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
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.pictureBoxAcercaDe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Aceptar.Location = new System.Drawing.Point(116, 170);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 0;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(100, 125);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(102, 13);
            this.lblCreditos.TabIndex = 1;
            this.lblCreditos.Text = "Programación Visual\nPráctica1\n2024";
            this.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAcercaDe
            // 
            this.pictureBoxAcercaDe.Image = global::reloj.Properties.Resources.uah;
            this.pictureBoxAcercaDe.Location = new System.Drawing.Point(75, 12);
            this.pictureBoxAcercaDe.Name = "pictureBoxAcercaDe";
            this.pictureBoxAcercaDe.Size = new System.Drawing.Size(150, 100);
            this.pictureBoxAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAcercaDe.TabIndex = 2;
            this.pictureBoxAcercaDe.TabStop = false;
            // 
            // AcercaDe
            // 
            this.AcceptButton = this.bt_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.pictureBoxAcercaDe);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.bt_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcercaDe";
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcercaDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Aceptar;
        private Label lblCreditos;
        private PictureBox pictureBoxAcercaDe;
    }
}