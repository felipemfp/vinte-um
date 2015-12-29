namespace Postero.VinteUm.View.WinApp
{
    partial class Form1
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
            this.btnParar = new System.Windows.Forms.Button();
            this.btnTirar = new System.Windows.Forms.Button();
            this.lbxMaoJogador = new System.Windows.Forms.ListBox();
            this.lblPontosDaMesa = new System.Windows.Forms.Label();
            this.lblPontosDoJogador = new System.Windows.Forms.Label();
            this.lbxMaoMesa = new System.Windows.Forms.ListBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.btnApostar10 = new System.Windows.Forms.Button();
            this.lblAposta = new System.Windows.Forms.Label();
            this.btnApostar50 = new System.Windows.Forms.Button();
            this.btnApostar100 = new System.Windows.Forms.Button();
            this.lblMesaCartaVirada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnParar
            // 
            this.btnParar.Enabled = false;
            this.btnParar.Location = new System.Drawing.Point(99, 144);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 0;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnTirar
            // 
            this.btnTirar.Enabled = false;
            this.btnTirar.Location = new System.Drawing.Point(184, 144);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(75, 23);
            this.btnTirar.TabIndex = 1;
            this.btnTirar.Text = "Tirar";
            this.btnTirar.UseVisualStyleBackColor = true;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // lbxMaoJogador
            // 
            this.lbxMaoJogador.FormattingEnabled = true;
            this.lbxMaoJogador.Location = new System.Drawing.Point(139, 12);
            this.lbxMaoJogador.Name = "lbxMaoJogador";
            this.lbxMaoJogador.Size = new System.Drawing.Size(120, 95);
            this.lbxMaoJogador.TabIndex = 2;
            // 
            // lblPontosDaMesa
            // 
            this.lblPontosDaMesa.AutoSize = true;
            this.lblPontosDaMesa.Location = new System.Drawing.Point(12, 111);
            this.lblPontosDaMesa.Name = "lblPontosDaMesa";
            this.lblPontosDaMesa.Size = new System.Drawing.Size(0, 13);
            this.lblPontosDaMesa.TabIndex = 3;
            // 
            // lblPontosDoJogador
            // 
            this.lblPontosDoJogador.AutoSize = true;
            this.lblPontosDoJogador.Location = new System.Drawing.Point(136, 111);
            this.lblPontosDoJogador.Name = "lblPontosDoJogador";
            this.lblPontosDoJogador.Size = new System.Drawing.Size(0, 13);
            this.lblPontosDoJogador.TabIndex = 4;
            // 
            // lbxMaoMesa
            // 
            this.lbxMaoMesa.ForeColor = System.Drawing.Color.White;
            this.lbxMaoMesa.FormattingEnabled = true;
            this.lbxMaoMesa.Location = new System.Drawing.Point(12, 38);
            this.lbxMaoMesa.Name = "lbxMaoMesa";
            this.lbxMaoMesa.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxMaoMesa.Size = new System.Drawing.Size(120, 69);
            this.lbxMaoMesa.TabIndex = 5;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 144);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.BackColor = System.Drawing.Color.GreenYellow;
            this.lblCaixa.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(266, 13);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(139, 42);
            this.lblCaixa.TabIndex = 7;
            this.lblCaixa.Text = "R$ 50,00";
            this.lblCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApostar10
            // 
            this.btnApostar10.Location = new System.Drawing.Point(363, 111);
            this.btnApostar10.Name = "btnApostar10";
            this.btnApostar10.Size = new System.Drawing.Size(38, 23);
            this.btnApostar10.TabIndex = 8;
            this.btnApostar10.Text = "10";
            this.btnApostar10.UseVisualStyleBackColor = true;
            this.btnApostar10.Click += new System.EventHandler(this.btnApostar10_Click);
            // 
            // lblAposta
            // 
            this.lblAposta.BackColor = System.Drawing.Color.Red;
            this.lblAposta.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAposta.Location = new System.Drawing.Point(265, 65);
            this.lblAposta.Name = "lblAposta";
            this.lblAposta.Size = new System.Drawing.Size(139, 42);
            this.lblAposta.TabIndex = 9;
            this.lblAposta.Text = "R$ 0,00";
            this.lblAposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApostar50
            // 
            this.btnApostar50.Location = new System.Drawing.Point(314, 111);
            this.btnApostar50.Name = "btnApostar50";
            this.btnApostar50.Size = new System.Drawing.Size(38, 23);
            this.btnApostar50.TabIndex = 10;
            this.btnApostar50.Text = "50";
            this.btnApostar50.UseVisualStyleBackColor = true;
            this.btnApostar50.Click += new System.EventHandler(this.btnApostar50_Click);
            // 
            // btnApostar100
            // 
            this.btnApostar100.Location = new System.Drawing.Point(266, 111);
            this.btnApostar100.Name = "btnApostar100";
            this.btnApostar100.Size = new System.Drawing.Size(38, 23);
            this.btnApostar100.TabIndex = 11;
            this.btnApostar100.Text = "100";
            this.btnApostar100.UseVisualStyleBackColor = true;
            this.btnApostar100.Click += new System.EventHandler(this.btnApostar100_Click);
            // 
            // lblMesaCartaVirada
            // 
            this.lblMesaCartaVirada.AutoSize = true;
            this.lblMesaCartaVirada.Location = new System.Drawing.Point(15, 19);
            this.lblMesaCartaVirada.Name = "lblMesaCartaVirada";
            this.lblMesaCartaVirada.Size = new System.Drawing.Size(0, 13);
            this.lblMesaCartaVirada.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 178);
            this.Controls.Add(this.lblMesaCartaVirada);
            this.Controls.Add(this.btnApostar100);
            this.Controls.Add(this.btnApostar50);
            this.Controls.Add(this.lblAposta);
            this.Controls.Add(this.btnApostar10);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbxMaoMesa);
            this.Controls.Add(this.lblPontosDoJogador);
            this.Controls.Add(this.lblPontosDaMesa);
            this.Controls.Add(this.lbxMaoJogador);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.btnParar);
            this.Name = "Form1";
            this.Text = "Vinte e um";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.ListBox lbxMaoJogador;
        private System.Windows.Forms.Label lblPontosDaMesa;
        private System.Windows.Forms.Label lblPontosDoJogador;
        private System.Windows.Forms.ListBox lbxMaoMesa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Button btnApostar10;
        private System.Windows.Forms.Label lblAposta;
        private System.Windows.Forms.Button btnApostar50;
        private System.Windows.Forms.Button btnApostar100;
        private System.Windows.Forms.Label lblMesaCartaVirada;
    }
}

