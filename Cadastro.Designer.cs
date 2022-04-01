namespace Pauta
{
    partial class frm_cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_faltas = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_dados = new System.Windows.Forms.Button();
            this.btn_media = new System.Windows.Forms.Button();
            this.btn_faltas = new System.Windows.Forms.Button();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nº de faltas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota 2:";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(290, 96);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 29);
            this.txt_matricula.TabIndex = 6;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(290, 137);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(216, 29);
            this.txt_nome.TabIndex = 7;
            // 
            // txt_faltas
            // 
            this.txt_faltas.Location = new System.Drawing.Point(290, 177);
            this.txt_faltas.Name = "txt_faltas";
            this.txt_faltas.Size = new System.Drawing.Size(100, 29);
            this.txt_faltas.TabIndex = 8;
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(290, 220);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 29);
            this.txt_nota1.TabIndex = 9;
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(290, 259);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 29);
            this.txt_nota2.TabIndex = 10;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_cadastro.Location = new System.Drawing.Point(181, 400);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(193, 38);
            this.btn_cadastro.TabIndex = 11;
            this.btn_cadastro.Text = "Cadastrar Aluno";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click_1);
            // 
            // btn_dados
            // 
            this.btn_dados.Location = new System.Drawing.Point(74, 444);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.Size = new System.Drawing.Size(193, 38);
            this.btn_dados.TabIndex = 12;
            this.btn_dados.Text = "Mostrar dados";
            this.btn_dados.UseVisualStyleBackColor = true;
            this.btn_dados.Click += new System.EventHandler(this.btn_dados_Click);
            // 
            // btn_media
            // 
            this.btn_media.Location = new System.Drawing.Point(290, 444);
            this.btn_media.Name = "btn_media";
            this.btn_media.Size = new System.Drawing.Size(193, 38);
            this.btn_media.TabIndex = 13;
            this.btn_media.Text = "Média do Aluno";
            this.btn_media.UseVisualStyleBackColor = true;
            this.btn_media.Click += new System.EventHandler(this.btn_media_Click);
            // 
            // btn_faltas
            // 
            this.btn_faltas.Location = new System.Drawing.Point(74, 488);
            this.btn_faltas.Name = "btn_faltas";
            this.btn_faltas.Size = new System.Drawing.Size(193, 38);
            this.btn_faltas.TabIndex = 14;
            this.btn_faltas.Text = "Situação Frequência";
            this.btn_faltas.UseVisualStyleBackColor = true;
            this.btn_faltas.Click += new System.EventHandler(this.btn_faltas_Click);
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(290, 488);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(193, 38);
            this.btn_resultado.TabIndex = 15;
            this.btn_resultado.Text = "Resultado Final";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(21, 605);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(106, 38);
            this.btn_limpar.TabIndex = 16;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click_1);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.Location = new System.Drawing.Point(430, 605);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(106, 38);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(562, 672);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.btn_faltas);
            this.Controls.Add(this.btn_media);
            this.Controls.Add(this.btn_dados);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.txt_faltas);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_faltas;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_dados;
        private System.Windows.Forms.Button btn_media;
        private System.Windows.Forms.Button btn_faltas;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
    }
}

