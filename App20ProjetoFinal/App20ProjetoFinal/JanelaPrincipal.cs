using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App20ProjetoFinal
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            cb_Status.SelectedItem = null; //para não começar já checado
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //se for diferende de uma letra e de um modificador
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if(ChecarDados())
            {
                AddRelatorio(); //adicionando a funçao relatorio
                LimparDados();  //adicionando a funçao limpar dados

            }
            else
            {
                MessageBox.Show("Você não completou todos os dados corretamente!","Erro:");
                //avisar ao usuario
            }
            
        }
        private bool ChecarDados()
        {
            if (!string.IsNullOrEmpty(tb_ID.Text) && !string.IsNullOrEmpty(tb_Nome.Text) && !string.IsNullOrEmpty(tb_Sobrenome.Text) && 
                !string.IsNullOrEmpty(mtb_Telefone.Text) && !string.IsNullOrEmpty(mtb_CEP.Text) &&
                !string.IsNullOrEmpty(mtb_Valor.Text) && cb_Status.SelectedItem != null) 
                //se a string nao estiver vazia e o campo status for de diferente de nulo(vazio)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
        private void AddRelatorio() //criou a funçao relatorio
        {
            ListViewItem relatorio = new ListViewItem(tb_ID.Text);
            relatorio.SubItems.Add(tb_Nome.Text);
            relatorio.SubItems.Add(tb_Sobrenome.Text);
            relatorio.SubItems.Add(mtb_Telefone.Text);
            relatorio.SubItems.Add(mtb_CEP.Text);
            relatorio.SubItems.Add(cb_Status.Text);

            relatorio.SubItems.Add(gb_novoCliente.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text); //radiobutton novo cliente

            relatorio.SubItems.Add(mtb_Valor.Text);
            relatorio.SubItems.Add(dtp_Data.Text);

            string anotacoes = String.Empty; //definiu a string como vazia
            if (cb_HComercial.Checked == true)
            {
                anotacoes += cb_HComercial.Text + "  ";
            }
            else if (cb_Condominio.Checked == true)
            {
                anotacoes += cb_Condominio.Text + "  ";
            }
            else if (cb_AvisoPrevio.Checked == true)
            {
                anotacoes += cb_AvisoPrevio.Text;
            }
            relatorio.SubItems.Add(anotacoes); //CHECKBOX anotações    

            lv_Relatorio.Items.Add(relatorio);
        }
        private void LimparDados() //limpando os dados
        {
            tb_ID.Text = null;
            tb_Nome.Text = null;
            tb_Sobrenome.Text = null;
            mtb_Telefone.Text = null;
            mtb_CEP.Text = null;
            cb_Status.Text = null;
            cb_Status.SelectedItem = null;
            rb_Sim.Checked = true;
            mtb_Valor.Text = null;
            dtp_Data.Text = null;
            cb_AvisoPrevio.Checked = false;
            cb_Condominio.Checked = false;
            cb_HComercial.Checked = false;

        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }
    }
}
