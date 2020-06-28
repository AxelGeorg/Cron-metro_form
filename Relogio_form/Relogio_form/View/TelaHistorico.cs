using Relogio_form.Entities;
using Relogio_form.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio_form.View
{
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();
            ListarHistorico();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            TelaCronometro tela = new TelaCronometro();
            this.Hide();
            tela.ShowDialog();
        }

        public void ListarHistorico()
        {
            CronometroService service = new CronometroService();
            List<Cronometro> historico = new List<Cronometro>();

            historico = service.GetHistorico().GetAwaiter().GetResult();

            for (int i = 0; i < historico.Count; i++)
            {
                listView_historico.Items.Add(historico[i].cro_id);
                listView_historico.Items[i].SubItems.Add(historico[i].cro_data);
                listView_historico.Items[i].SubItems.Add(historico[i].cro_horario);
                listView_historico.Items[i].SubItems.Add(historico[i].cro_tempo);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            CronometroService service = new CronometroService();
            Resposta retorno = new Resposta();

            retorno = service.DeleteHistorico().GetAwaiter().GetResult();
            ListarHistorico();
            MessageBox.Show(retorno.Mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
