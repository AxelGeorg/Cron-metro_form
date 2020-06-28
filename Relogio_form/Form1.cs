using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Relogio_form
{
    public partial class form_cronometro : Form
    {
        private Stopwatch stopwatch; 
        public form_cronometro()
        {
            InitializeComponent();
            timerDataTime.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //hora e data canto superior esquerdo
            lbl_data.Text = DateTime.Now.ToShortDateString();
            lbl_horario.Text = DateTime.Now.ToLongTimeString();
        }
        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            //cronometro
            //this.lbl_cronometro.Text = stopwatch.Elapsed.ToString();
            this.lbl_cronometro.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            timerCronometro.Start();
            stopwatch.Start();
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btn_zerar_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
    }
}
