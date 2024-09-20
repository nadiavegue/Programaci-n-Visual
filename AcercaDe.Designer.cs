using System.Drawing;

namespace prac_1
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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxAcercaDe = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcercaDe)).BeginInit();
			this.SuspendLayout();
			// 
			// bt_Aceptar
			// 
			this.bt_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bt_Aceptar.Location = new System.Drawing.Point(110, 155);
			this.bt_Aceptar.Name = "bt_Aceptar";
			this.bt_Aceptar.Size = new System.Drawing.Size(80, 25);
			this.bt_Aceptar.TabIndex = 0;
			this.bt_Aceptar.Text = "Aceptar";
			this.bt_Aceptar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(100, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Programación Visual\nPráctica 1\n2024";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			// 
			// pictureBoxAcercaDe
			// 
			this.pictureBoxAcercaDe.Image = global::prac_1.Properties.Resources.uah_i;
			this.pictureBoxAcercaDe.Location = new System.Drawing.Point(75, 15);
			this.pictureBoxAcercaDe.Name = "pictureBoxAcercaDe";
			this.pictureBoxAcercaDe.Size = new System.Drawing.Size(150, 75);
			this.pictureBoxAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAcercaDe.TabIndex = 2;
			this.pictureBoxAcercaDe.TabStop = false;
			this.pictureBoxAcercaDe.Click += new System.EventHandler(this.pictureBox1_Click_1);
			// 
			// AcercaDe
			// 
			this.AcceptButton = this.bt_Aceptar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 200);
			this.Controls.Add(this.pictureBoxAcercaDe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_Aceptar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AcercaDe";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AcercaDe";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAcercaDe)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_Aceptar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBoxAcercaDe;
	}
}