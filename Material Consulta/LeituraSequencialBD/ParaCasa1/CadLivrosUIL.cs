using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParaCasa1
{
    public partial class CadLivrosUIL : Form
    {
        Livro umlivro = new Livro();
        public CadLivrosUIL()
        {
            InitializeComponent();
        }

        private void CadLivrosUIL_Load(object sender, EventArgs e)
        {
            LivroBLL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                Application.Exit();
            }
        }

        private void CadLivrosUIL_FormClosed(object sender, FormClosedEventArgs e)
        {
            LivroBLL.desconecta();
        }

         private void button1_Click(object sender, EventArgs e)
        {
             LivroBLL.getProximo(umlivro);
             while (!Erro.getErro())
             {
                 listBox1.Items.Add("Titulo = " + umlivro.getTitulo() + " escrito por " + umlivro.getAutor());
                 LivroBLL.getProximo(umlivro);
             }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
