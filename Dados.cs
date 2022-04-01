using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pauta
{
    public partial class frm_dados : Form
    {
        private Pauta pautaDados; //cria um objeto do tipo pauta
        public frm_dados(Object p)
        {
            InitializeComponent();
            pautaDados = (Pauta)p;
            txt_matricula.Text = Convert.ToString(pautaDados.getMatricula());
            txt_nome.Text = pautaDados.getNomeAluno();
            txt_faltas.Text = Convert.ToString(pautaDados.getNumFalta());
            txt_nota1.Text = Convert.ToString(pautaDados.getNota1());
            txt_nota2.Text = Convert.ToString(pautaDados.getNota2());
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
