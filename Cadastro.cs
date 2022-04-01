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
    public partial class frm_cadastro : Form
    {
        private Pauta pauta = new Pauta();
        public frm_cadastro()
        {
            InitializeComponent();
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btn_dados_Click(object sender, EventArgs e)
        {
            if (pauta.getMatricula() != 0)
            {
                frm_dados dados = new frm_dados(pauta);
                dados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há nada para mostrar!");
            }
        }
        private void btn_cadastro_Click_1(object sender, EventArgs e)
        {
            if (txt_matricula.Text != "" && txt_nome.Text != "" && txt_faltas.Text != "" && txt_nota1.Text != "" && txt_nota2.Text != "")
            {
                pauta.setMatricula(int.Parse(txt_matricula.Text));
                pauta.setNomeAluno(txt_nome.Text);
                pauta.setNumFalta(int.Parse(txt_faltas.Text));
                pauta.setNota1(double.Parse(txt_nota1.Text));
                pauta.setNota2(double.Parse(txt_nota2.Text));
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Prencha todos os campos!");
            }
        }
        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            txt_matricula.Focus();
            txt_matricula.Clear();
            txt_nome.Clear();
            txt_faltas.Clear();
            txt_nota1.Clear();
            txt_nota2.Clear();
        }
        private void btn_media_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Média: " + (pauta.calcularMedia()).ToString("N1"));
        }
        private void btn_resultado_Click(object sender, EventArgs e)
        {
            if (pauta.getMatricula() != 0)
            {
                frm_resultado dados = new frm_resultado(pauta);
                dados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há nada para mostrar!");
            }
        }
        private void btn_faltas_Click(object sender, EventArgs e)
        {
            if (pauta.getNumFalta() > 25)
            {
                MessageBox.Show("Aluno reprovado por falta.");
            }
            else
            {
                MessageBox.Show("Aluno aprovado.");
            }
        }
    }
}
