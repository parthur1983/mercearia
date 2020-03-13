using Nucleo.Modelo;
using Nucleo.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerceariaSantana
{
    public partial class FormMenu : Form
    {
      
        public FormMenu()
        {
            InitializeComponent();
            EscondeBotoes();
            AbrirFormNoPanel<FormLogin>();
        }

        private void EscondeBotoes()
        {
            pnlAcoes.Hide();
        }

        private void panelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormProduto>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormVendas>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormUsuario>();
        }

        private void btnPrecos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormHistoricoPrecos>();
        }

        private void AbrirFormNoPanel<Forms>() where Forms: Form, new()
        {
            Form formulario;
            formulario = pnlConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                pnlConteudo.Controls.Add(formulario);
                pnlConteudo.Tag = formulario;

                formulario.FormClosed += new FormClosedEventHandler(ExibeBotoes);
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

                formulario.BringToFront();
            }

        }

        private void ExibeBotoes(object sender, FormClosedEventArgs e)
        {
            pnlAcoes.Show();
        }

        
    }
}
