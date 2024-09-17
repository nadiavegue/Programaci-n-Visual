using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reloj
{
    public partial class RelojAnalogico : Form
    {
        private Point m_Centro = new Point();
        private int m_Radio;
        private DateTime m_Hora;



        public RelojAnalogico()
        {
            InitializeComponent();

            //Actualizar dimensiones
            ActualizarDimensiones();

            //evento resize
            this.Resize += RelojAnalogico_Resize;
            this.Paint += RelojAnalógico_Paint;

            //evento FormClosing
            this.FormClosing += RelojAnalogico_FormClosing;
        }

        //metodo publico para mostrar el reloj analogico
        public void Show(Form parent)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(parent.Right + 10, parent.Top); //mostrar al lado del forulario principal
            this.ShowDialog(parent);    //mostrar como dialogo modal
        }

        private void RelojAnalogico_Load(object sender, EventArgs e)
        {

        }

        public DateTime Hora
        {
            set { m_Hora = value;
                Invalidate();
            }
        }

        private void ActualizarDimensiones()
        {
            m_Centro = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            m_Radio = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 2 - 10;
        }

        private void RelojAnalogico_Resize(object sender, EventArgs e)
        {
            ActualizarDimensiones();

            Invalidate();
        }

        private void RelojAnalogico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Focused)
            {
                e.Cancel = true;
                MessageBox.Show("El reloj analógico no se puede cerrar usando Alt+F4");

            }
        }

        private void RelojAnalógico_Paint(object sender, PaintEventArgs e)
        {
            if (m_Radio <= 10)
                return;

            Graphics gfx = e.Graphics;
            Pen lápizNormal = new Pen(Color.Black, 1);
            Pen lápizGordoNegro = new Pen(Color.Black, 2);
            Pen lápizGordoRojo = new Pen(Color.Red, 2);
            Pen lápizMuyGordoAzul = new Pen(Color.Blue, 4);
            HatchBrush brochaGris = new HatchBrush(HatchStyle.Sphere, Color.Gray, Color.Gray);


            float alfa, x, y;

            Matrix matriz = new Matrix(1, 0, 0, -1, m_Centro.X, m_Centro.Y);
            gfx.Transform = matriz;

            //Esfera
            float radioEsfera = m_Radio * .95f;
            gfx.DrawEllipse(lápizNormal, -radioEsfera, -radioEsfera,
            radioEsfera * 2, radioEsfera * 2);
            // Marcas de los minutos
            for (int i = 0; i < 60; i++)
            {
                alfa = (float)(i * Math.PI * 2 / 60);
                x = (float)(Math.Sin(alfa) * m_Radio);
                y = (float)(Math.Cos(alfa) * m_Radio);
                if (i % 5 == 0)
                    gfx.DrawLine(lápizGordoNegro, x * .85f, y * .85f,
                    x * .95f, y * .95f);
                else
                    gfx.DrawLine(lápizNormal, x * .9f, y * .9f,
                    x * .95f, y * .95f);
            }
            // Manecilla de las horas
            alfa = (float)((m_Hora.Hour % 12) * Math.PI * 2 / 12);
            alfa += (float)((m_Hora.Minute) * Math.PI * 2 / 12 / 60);
            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);
            gfx.DrawLine(lápizMuyGordoAzul, 0, 0, x * .5f, y * .5f);
            // Manecilla de los minutos con lápiz negro...
            alfa = (float)((m_Hora.Minute % 60) * Math.PI * 2 / 60);
            alfa += (float)((m_Hora.Second) * Math.PI * 2 / 60 / 60);
            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);
            gfx.DrawLine(lápizGordoNegro, 0, 0, x * .75f, y * .75f);

            // Manecilla de los segundos con lápiz rojo...
            alfa = (float)((m_Hora.Second % 60) * Math.PI * 2 / 60);
            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);
            gfx.DrawLine(lápizGordoRojo, 0, 0, x * .9f, y * .9f);


            // Botón Central
            float radioBotón = m_Radio * .1f / 2;
            gfx.DrawEllipse(lápizGordoNegro, -radioBotón, -radioBotón,
            radioBotón * 2, radioBotón * 2);
            gfx.FillEllipse(brochaGris, -radioBotón, -radioBotón,
            radioBotón * 2, radioBotón * 2);
        }

    }
}
