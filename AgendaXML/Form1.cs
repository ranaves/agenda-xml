using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaXML
{
    public partial class FrmAgenda : Form
    {
        Contatos contatos = null;

        public FrmAgenda()
        {
            InitializeComponent();
        }

        #region Methods

        private void ListarAgenda(List<Contato> lcontato)
        {
            lstAgenda.DataSource = lcontato;
            lstAgenda.DisplayMember = "Nome";
            lstAgenda.ValueMember = "Id";
        }

        private int nextId()
        {
            int next;

            if (contatos.Contato.Count > 0)
            {
                next = contatos.Contato[contatos.Contato.Count - 1].Id + 1;
            }
            else
            {
                next = contatos.Contato.Count + 1;
            }

            return next;
        }

        private void limparCampos()
        {
            txtNome.Text = txtTelResidencial.Text = txtTelComercial.Text = txtCelular.Text = String.Empty;
        }

        private void modoSalvar()
        {
            pnlSalvar.Visible = true;
            pnlAlterar.Visible = false;
            pnlID.Visible = false;
            limparCampos();
        }

        private void modoEditar()
        {
            pnlSalvar.Visible = false;
            pnlAlterar.Visible = true;
            pnlID.Visible = true;
        }

        private void modoDeletar()
        {
            pnlID.Visible = false;
            limparCampos();
        }

        #endregion

        #region Events

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Id = this.nextId();
            contato.Nome = txtNome.Text.Trim();
            contato.Telefone = new List<Telefone>();
            contato.Telefone.Add(new Telefone(TiposTelefone.Residencial.ToString(), txtTelResidencial.Text.Trim()));
            contato.Telefone.Add(new Telefone(TiposTelefone.Comercial.ToString(), txtTelComercial.Text.Trim()));
            contato.Telefone.Add(new Telefone(TiposTelefone.Celular.ToString(), txtCelular.Text.Trim()));

            contatos.Contato.Add(contato);
            SContatos.Write(contatos);            
            this.ListarAgenda(SContatos.Read().Contato);            
            limparCampos();
            MessageBox.Show("Item salvo com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }       

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            this.ListarAgenda(contatos.Contato);
        }
                
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lstAgenda.SelectedIndex > -1)
            {
                DialogResult resultadoDialogo = MessageBox.Show("Deseja deletar o item selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoDialogo == DialogResult.Yes) 
                {
                    Contato c = contatos.Contato.Find(p => p.Id == (int) lstAgenda.SelectedValue);
                    contatos.Contato.Remove(c);
                    SContatos.Write(contatos);
                    this.ListarAgenda(SContatos.Read().Contato);
                    modoDeletar();
                    MessageBox.Show("Item removido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
                              
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstAgenda.SelectedIndex > -1)
            {
                modoEditar();
                Contato c = contatos.Contato.Find(p => p.Id == (int) lstAgenda.SelectedValue);
                txtNome.Text = c.Nome;

                if (c.Telefone.Count > 0)
                {
                    txtTelResidencial.Text = c.Telefone[(int)TiposTelefone.Residencial].Numero;
                    txtTelComercial.Text = c.Telefone[(int)TiposTelefone.Comercial].Numero;
                    txtCelular.Text = c.Telefone[(int)TiposTelefone.Celular].Numero;
                }

                lblID.Text = c.Id.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modoSalvar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblID.Text);

            Contato c = contatos.Contato.Find(p => p.Id == id);

            c.Nome = txtNome.Text;
            c.Telefone[(int)TiposTelefone.Residencial].Numero = txtTelResidencial.Text;
            c.Telefone[(int)TiposTelefone.Comercial].Numero = txtTelComercial.Text;
            c.Telefone[(int)TiposTelefone.Celular].Numero = txtCelular.Text;

            SContatos.Write(contatos);            
            this.ListarAgenda(SContatos.Read().Contato);
            this.modoSalvar();
            MessageBox.Show("Item alterado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }

        #endregion        
        
    }
}
