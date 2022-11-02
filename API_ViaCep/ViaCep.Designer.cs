namespace API_ViaCep
{
    partial class ViaCep
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
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.uf = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pesquisarCep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Via Cep";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "UF:";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(92, 144);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(131, 20);
            this.cep.TabIndex = 5;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(92, 257);
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Size = new System.Drawing.Size(238, 20);
            this.bairro.TabIndex = 6;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(92, 313);
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Size = new System.Drawing.Size(238, 20);
            this.cidade.TabIndex = 7;
            // 
            // uf
            // 
            this.uf.Location = new System.Drawing.Point(92, 367);
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Size = new System.Drawing.Size(50, 20);
            this.uf.TabIndex = 8;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(92, 202);
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Size = new System.Drawing.Size(238, 20);
            this.endereco.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "CEP:";
            // 
            // pesquisarCep
            // 
            this.pesquisarCep.Location = new System.Drawing.Point(229, 139);
            this.pesquisarCep.Name = "pesquisarCep";
            this.pesquisarCep.Size = new System.Drawing.Size(75, 23);
            this.pesquisarCep.TabIndex = 11;
            this.pesquisarCep.Text = "Pesquisar";
            this.pesquisarCep.UseVisualStyleBackColor = true;
            this.pesquisarCep.Click += new System.EventHandler(this.pesquisarCep_Click);
            // 
            // ViaCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 471);
            this.Controls.Add(this.pesquisarCep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViaCep";
            this.Text = "Cep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox uf;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pesquisarCep;
    }
}

