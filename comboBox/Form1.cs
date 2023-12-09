using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBox
{
    public partial class Form1 : Form
    {
        List<Estado> estados = new List<Estado>();
        public Form1()
        {
            InitializeComponent();
            PopularEstados();
            InicializarCampos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void InicializarCampos()
        {
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
            cmbEstados.DataSource = estados;
        }

        public void PopularEstados()
        {
            estados.Add(new Estado("SP", "São Paulo"));
            estados.Add(new Estado("ES", "Espirito Santo"));
            estados.Add(new Estado("MG", "Minas Gerais"));
            estados.Add(new Estado("RJ", "Rio de Janeiro"));
            estados.Add(new Estado("PR", "Paraná"));
            estados.Add(new Estado("RS", "Rio Grande do Sul"));
            estados.Add(new Estado("SC", "Santa Catarina"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
