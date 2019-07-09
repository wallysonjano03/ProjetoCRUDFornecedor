namespace ProjetoCRUDFornecedor
{
    partial class Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cel = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_razao_social = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Fantasia:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(112, 189);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(342, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_add.Location = new System.Drawing.Point(29, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(65, 54);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(79, 219);
            this.txt_tel.Mask = "(99) 000-0000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesquisar Nome:";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(112, 93);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(342, 20);
            this.txt_pesquisa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Celular:";
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(258, 219);
            this.txt_cel.Mask = "(99) 000-0000";
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(100, 20);
            this.txt_cel.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(81, 250);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(392, 20);
            this.txt_email.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(81, 299);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(392, 20);
            this.txt_endereco.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Endereço:";
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_apagar.BackgroundImage")));
            this.btn_apagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_apagar.Location = new System.Drawing.Point(351, 12);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(65, 54);
            this.btn_apagar.TabIndex = 14;
            this.btn_apagar.Text = "APAGAR";
            this.btn_apagar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.Btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editar.Location = new System.Drawing.Point(268, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 54);
            this.btn_editar.TabIndex = 15;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_buscar.Location = new System.Drawing.Point(188, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(65, 54);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_salvar.Location = new System.Drawing.Point(108, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(65, 54);
            this.btn_salvar.TabIndex = 17;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(81, 325);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(55, 20);
            this.txt_num.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nº:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(226, 325);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(247, 20);
            this.txt_bairro.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bairro:";
            // 
            // txt_razao_social
            // 
            this.txt_razao_social.Location = new System.Drawing.Point(112, 163);
            this.txt_razao_social.Name = "txt_razao_social";
            this.txt_razao_social.Size = new System.Drawing.Size(342, 20);
            this.txt_razao_social.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Razão Social:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cep:";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(81, 276);
            this.txt_cep.Mask = "00000-999";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "CNPJ:";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(112, 140);
            this.txt_cnpj.Mask = "00.000.000/9999-99";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(100, 20);
            this.txt_cnpj.TabIndex = 27;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(268, 276);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(205, 20);
            this.txt_cidade.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cidade:";
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 382);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_razao_social);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Fornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_cel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_razao_social;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label12;
    }
}