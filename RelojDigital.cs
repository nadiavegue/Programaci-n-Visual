using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reloj
{
    public partial class RelojDigital : Form
    {
        private Timer timer;
        private TimeSpan m_DesfaseHorario = new TimeSpan(1, 0, 0);
        private RelojAnalogico m_RelojAnalagico = new RelojAnalogico();

        public RelojDigital()
        {
            InitializeComponent();

            //configurar el timer
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            //Inicializar valor caja de texto
            MostrarHoraActual();

            
            //vincular evento enter caja de texto
            ct_HoraActual.Enter += ct_HoraActual_Enter;

            //vincular evento click de boton bt_Actulizar
            bt_Actualizar.Click += bt_Actualizar_Click;

            //suscribir al evento Shown del formulario
            this.Shown += RelojDigital_Shown;

            //hacer visible  reloj analogico
            m_RelojAnalagico.Show(this);
        }

        private void ct_HoraActual_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ct_HoraActual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToString("HH:mm:ss");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Actualizar_Click(object sender, EventArgs e)
        {
            MostrarHoraActual();
        }

        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalagico.Location = new Point(this.Location.X + 250 + 10, 250);
        }
    }
}
