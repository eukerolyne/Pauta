using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pauta
{
    internal class Pauta
    {
        private int matricula;
        private string nomeAluno;
        private int falta;
        private double nota1;
        private double nota2;

        public Pauta()
        {
            this.matricula = 0;
            this.nomeAluno = "";
            this.falta = 0;
            this.nota1 = 0;
            this.nota2 = 0;
        }
        public Pauta(int m, string n, int nf, double n1, double n2)
        {
            this.matricula = m;
            this.nomeAluno = n;
            this.falta = nf;
            this.nota1 = n1;
            this.nota2 = n2;
        }
        public void setMatricula(int novo)
        {
            this.matricula = novo;
        }
        public void setNomeAluno(string novo)
        {
            this.nomeAluno = novo;
        }
        public void setNumFalta(int novo)
        {
            this.falta = novo;
        }
        public void setNota1(double novo)
        {
            this.nota1 = novo;
        }
        public void setNota2(double novo)
        {
            this.nota2 = novo;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
        public string getNomeAluno()
        {
            return this.nomeAluno;
        }
        public int getNumFalta()
        {
            return this.falta;
        }
        public double getNota1()
        {
            return this.nota1;
        }
        public double getNota2()
        {
            return this.nota2;
        }
        public string toString()
        {
            return this.matricula + " " + this.nomeAluno + " " + this.falta + " " +
                this.nota1 + " " + this.nota2;
        }
        public double calcularMedia()
        {
            return (this.nota1 + this.nota2) / 2;
        }
    }
}
