using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dg_numeros.DataSource = new List<double>();
            try
            {
                string entrada = tb_entrada.Text.Trim();
                while (entrada.Contains(tb_separador.Text) && !tb_separador.Text.Equals(";"))
                {
                    entrada = entrada.Replace(tb_separador.Text, ";");
                }
                while (entrada.Contains(Environment.NewLine))
                {
                    entrada = entrada.Replace(Environment.NewLine, ";");
                }
                while (entrada.Contains("\n"))
                {
                    entrada = entrada.Replace("\n", ";");
                }
                while (entrada.Contains("  "))
                {
                    entrada = entrada.Replace("  ", " ");
                }
                if(entrada.Contains(" "))
                {
                    entrada = entrada.Replace(" ", ";");
                }
                while (entrada.Contains(";;"))
                {
                    entrada = entrada.Replace(";;", ";");
                }
                if (entrada.Contains("."))
                {
                    entrada = entrada.Replace(".", "");
                }
                string[] strarr = entrada.Split(';');
                double[] arrnum = new double[strarr.Count()];
                List<Numero> numeros = new List<Numero>();
                for (int i = 0; i < strarr.Count(); i++)
                {
                    arrnum[i] = double.Parse(strarr[i]);
                }
                Array.Sort(arrnum);

                foreach (double d in arrnum)
                {
                    Numero num = new Numero();
                    num.Valor = d;
                    numeros.Add(num);
                }
                tb_menor.Text = arrnum[0].ToString();
                tb_maior.Text = arrnum[numeros.Count() - 1].ToString();
                dg_numeros.DataSource = numeros;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dados inválidos, Verifique o separador.");
            }
            
        }
        private void dg_numeros_SelectionChanged(object sender, EventArgs e)
        {
            tx_selecionados.Text = $"Selecionados: {dg_numeros.SelectedRows.Count}";
            if(dg_numeros.SelectedRows.Count > 0)
            {
                double[] selecionados = new double[dg_numeros.SelectedRows.Count];
                for (int i = 0; i < dg_numeros.SelectedRows.Count;i++)
                {
                    selecionados[i] = double.Parse(dg_numeros.SelectedRows[i].Cells[nameof(Numero.Valor)].Value.ToString());
                }
                tx_soma.Text = $" Soma: {selecionados.Sum().ToString()}";
            }
        }
    }
    class Numero
    {
        [DisplayName("Valor")]
        public double Valor { get; set; }
    }
}
