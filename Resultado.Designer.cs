namespace Pauta
{
    partial class frm_resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_resultado));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.txt_faltas = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_frequencia = new System.Windows.Forms.Label();
            this.lbl_situacaoFinal = new System.Windows.Forms.Label();
            this.lbl_resultadoFreq = new System.Windows.Forms.Label();
            this.lbl_resultadoFinal = new System.Windows.Forms.Label();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.lbl_resultadoMedia = new System.Windows.Forms.Label();
            this.btn_resultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(185, 578);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(193, 38);
            this.btn_voltar.TabIndex = 32;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(287, 245);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.ReadOnly = true;
            this.txt_nota2.Size = new System.Drawing.Size(100, 29);
            this.txt_nota2.TabIndex = 31;
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(287, 206);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.ReadOnly = true;
            this.txt_nota1.Size = new System.Drawing.Size(100, 29);
            this.txt_nota1.TabIndex = 30;
            // 
            // txt_faltas
            // 
            this.txt_faltas.Location = new System.Drawing.Point(287, 163);
            this.txt_faltas.Name = "txt_faltas";
            this.txt_faltas.ReadOnly = true;
            this.txt_faltas.Size = new System.Drawing.Size(100, 29);
            this.txt_faltas.TabIndex = 29;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(287, 123);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(216, 29);
            this.txt_nome.TabIndex = 28;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(287, 82);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.ReadOnly = true;
            this.txt_matricula.Size = new System.Drawing.Size(100, 29);
            this.txt_matricula.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nota 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nota 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nº de faltas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Matrícula:";
            // 
            // lbl_frequencia
            // 
            this.lbl_frequencia.AutoSize = true;
            this.lbl_frequencia.Location = new System.Drawing.Point(76, 415);
            this.lbl_frequencia.Name = "lbl_frequencia";
            this.lbl_frequencia.Size = new System.Drawing.Size(214, 22);
            this.lbl_frequencia.TabIndex = 33;
            this.lbl_frequencia.Text = "Situação da Frequência:";
            // 
            // lbl_situacaoFinal
            // 
            this.lbl_situacaoFinal.AutoSize = true;
            this.lbl_situacaoFinal.Location = new System.Drawing.Point(157, 483);
            this.lbl_situacaoFinal.Name = "lbl_situacaoFinal";
            this.lbl_situacaoFinal.Size = new System.Drawing.Size(133, 22);
            this.lbl_situacaoFinal.TabIndex = 34;
            this.lbl_situacaoFinal.Text = "Situação Final:";
            // 
            // lbl_resultadoFreq
            // 
            this.lbl_resultadoFreq.AutoSize = true;
            this.lbl_resultadoFreq.Location = new System.Drawing.Point(296, 415);
            this.lbl_resultadoFreq.Name = "lbl_resultadoFreq";
            this.lbl_resultadoFreq.Size = new System.Drawing.Size(0, 22);
            this.lbl_resultadoFreq.TabIndex = 35;
            // 
            // lbl_resultadoFinal
            // 
            this.lbl_resultadoFinal.AutoSize = true;
            this.lbl_resultadoFinal.Location = new System.Drawing.Point(296, 483);
            this.lbl_resultadoFinal.Name = "lbl_resultadoFinal";
            this.lbl_resultadoFinal.Size = new System.Drawing.Size(0, 22);
            this.lbl_resultadoFinal.TabIndex = 37;
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(122, 448);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(168, 22);
            this.lbl_nota.TabIndex = 38;
            this.lbl_nota.Text = "Situação da Notas:";
            // 
            // lbl_resultadoMedia
            // 
            this.lbl_resultadoMedia.AutoSize = true;
            this.lbl_resultadoMedia.Location = new System.Drawing.Point(296, 448);
            this.lbl_resultadoMedia.Name = "lbl_resultadoMedia";
            this.lbl_resultadoMedia.Size = new System.Drawing.Size(0, 22);
            this.lbl_resultadoMedia.TabIndex = 39;
            // 
            // btn_resultados
            // 
            this.btn_resultados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resultados.Location = new System.Drawing.Point(185, 335);
            this.btn_resultados.Name = "btn_resultados";
            this.btn_resultados.Size = new System.Drawing.Size(193, 38);
            this.btn_resultados.TabIndex = 40;
            this.btn_resultados.Text = "Mostrar Situações";
            this.btn_resultados.UseVisualStyleBackColor = true;
            this.btn_resultados.Click += new System.EventHandler(this.btn_resultados_Click);
            // 
            // frm_resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(562, 672);
            this.Controls.Add(this.btn_resultados);
            this.Controls.Add(this.lbl_resultadoMedia);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.lbl_resultadoFinal);
            this.Controls.Add(this.lbl_resultadoFreq);
            this.Controls.Add(this.lbl_situacaoFinal);
            this.Controls.Add(this.lbl_frequencia);
            this.Controls.Add(this.btn_voltar);
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
            this.Name = "frm_resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultado Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.TextBox txt_faltas;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_frequencia;
        private System.Windows.Forms.Label lbl_situacaoFinal;
        private System.Windows.Forms.Label lbl_resultadoFreq;
        private System.Windows.Forms.Label lbl_resultadoFinal;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.Label lbl_resultadoMedia;
        private System.Windows.Forms.Button btn_resultados;
    }
}