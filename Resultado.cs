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
    public partial class frm_resultado : Form
    {
        private Pauta pautaDados;
        public frm_resultado(Object p)
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

        private void btn_resultados_Click(object sender, EventArgs e)
        {
            if (pautaDados.calcularMedia() >= 7 && pautaDados.getNumFalta() <= 25)
            {
                lbl_resultadoFinal.ForeColor = Color.Green;
                lbl_resultadoFinal.Text = "APROVADO";
            }
            else
            {
                lbl_resultadoFinal.ForeColor = Color.Red;
                lbl_resultadoFinal.Text = "REPROVADO";
            }
            if(pautaDados.calcularMedia() >= 7)
            {
                lbl_resultadoMedia.ForeColor = Color.Green;
                lbl_resultadoMedia.Text = "APROVADO";
            }
            else
            {
                lbl_resultadoMedia.ForeColor = Color.Red;
                lbl_resultadoMedia.Text = "REPROVADO";
            }
            if(pautaDados.getNumFalta() <= 25)
            {
                lbl_resultadoFreq.ForeColor = Color.Green;
                lbl_resultadoFreq.Text = "APROVADO";
            }
            else
            {
                lbl_resultadoFreq.ForeColor = Color.Red;
                lbl_resultadoFreq.Text = "REPROVADO";
            }
        }
    }
}
