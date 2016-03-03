namespace AgendaXML
{
    partial class FrmAgenda
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelResidencial = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelResidencial = new System.Windows.Forms.TextBox();
            this.lstAgenda = new System.Windows.Forms.ListBox();
            this.txtTelComercial = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblTelComercial = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pnlAlterar = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlID = new System.Windows.Forms.Panel();
            this.pnlSalvar = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlAlterar.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlSalvar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblTelResidencial
            // 
            this.lblTelResidencial.AutoSize = true;
            this.lblTelResidencial.Location = new System.Drawing.Point(25, 116);
            this.lblTelResidencial.Name = "lblTelResidencial";
            this.lblTelResidencial.Size = new System.Drawing.Size(86, 13);
            this.lblTelResidencial.TabIndex = 3;
            this.lblTelResidencial.Text = "Tel. Residencial:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtTelResidencial
            // 
            this.txtTelResidencial.Location = new System.Drawing.Point(25, 141);
            this.txtTelResidencial.Name = "txtTelResidencial";
            this.txtTelResidencial.Size = new System.Drawing.Size(131, 20);
            this.txtTelResidencial.TabIndex = 5;
            // 
            // lstAgenda
            // 
            this.lstAgenda.FormattingEnabled = true;
            this.lstAgenda.Location = new System.Drawing.Point(242, 47);
            this.lstAgenda.Name = "lstAgenda";
            this.lstAgenda.Size = new System.Drawing.Size(257, 238);
            this.lstAgenda.TabIndex = 10;
            // 
            // txtTelComercial
            // 
            this.txtTelComercial.Location = new System.Drawing.Point(25, 201);
            this.txtTelComercial.Name = "txtTelComercial";
            this.txtTelComercial.Size = new System.Drawing.Size(100, 20);
            this.txtTelComercial.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(25, 265);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // lblTelComercial
            // 
            this.lblTelComercial.AutoSize = true;
            this.lblTelComercial.Location = new System.Drawing.Point(25, 175);
            this.lblTelComercial.Name = "lblTelComercial";
            this.lblTelComercial.Size = new System.Drawing.Size(74, 13);
            this.lblTelComercial.TabIndex = 9;
            this.lblTelComercial.Text = "Tel. Comercial";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(25, 235);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 10;
            this.lblCelular.Text = "Celular:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(323, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(424, 314);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 12;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pnlAlterar
            // 
            this.pnlAlterar.Controls.Add(this.btnCancelar);
            this.pnlAlterar.Controls.Add(this.btnAlterar);
            this.pnlAlterar.Location = new System.Drawing.Point(21, 303);
            this.pnlAlterar.Name = "pnlAlterar";
            this.pnlAlterar.Size = new System.Drawing.Size(195, 48);
            this.pnlAlterar.TabIndex = 13;
            this.pnlAlterar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(6, 13);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID";
            this.lblID.UseMnemonic = false;
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.lblID);
            this.pnlID.Location = new System.Drawing.Point(23, 12);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(59, 30);
            this.pnlID.TabIndex = 0;
            this.pnlID.Visible = false;
            // 
            // pnlSalvar
            // 
            this.pnlSalvar.Controls.Add(this.btnSalvar);
            this.pnlSalvar.Location = new System.Drawing.Point(21, 303);
            this.pnlSalvar.Name = "pnlSalvar";
            this.pnlSalvar.Size = new System.Drawing.Size(195, 48);
            this.pnlSalvar.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 378);
            this.Controls.Add(this.pnlSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelComercial);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelComercial);
            this.Controls.Add(this.lstAgenda);
            this.Controls.Add(this.txtTelResidencial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelResidencial);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlID);
            this.Controls.Add(this.pnlAlterar);
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.pnlAlterar.ResumeLayout(false);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlSalvar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelResidencial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelResidencial;
        private System.Windows.Forms.ListBox lstAgenda;
        private System.Windows.Forms.TextBox txtTelComercial;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblTelComercial;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Panel pnlAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSalvar;
        private System.Windows.Forms.Button btnSalvar;
    }
}

