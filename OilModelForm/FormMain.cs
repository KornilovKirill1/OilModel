using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OilModel.Lib;

namespace OilModelForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void toolStripButtonInfo_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }

        private void toolStripButtonReference_Click(object sender, EventArgs e)
        {
            FormReference reference = new FormReference();
            reference.Show();
        }

        private void toolStripButtonDone_Click(object sender, EventArgs e)
        {
            chartGraph.Series[0].Points.Clear();
            textBoxBorisov.Text = "Q Борисов = ";
            textBoxGeneral.Text = "Q общ = ";
            try
            {
                int L = Convert.ToInt32(textBoxL.Text);
                int N = Convert.ToInt32(textBoxN.Text);
                int h = Convert.ToInt32(textBoxH.Text);
                int Rk = Convert.ToInt32(textBoxRk.Text);
                double plateP = Convert.ToDouble(textBoxPpl.Text);
                double bottomholeP = Convert.ToDouble(textBoxPz.Text);
                double M = Convert.ToDouble(textBoxM.Text);
                double Kh = Convert.ToDouble(textBoxKh.Text);
                double Kv = Convert.ToDouble(textBoxKv.Text);
                double Rc = Convert.ToDouble(textBoxRc.Text);

                double Borisov = ds.flowRateBorisov(Kh, Kv, h, plateP, bottomholeP, M, Rk, L, Rc);
                textBoxBorisov.Text += Borisov.ToString();

                double[,] unknownСoefficients = ds.unknownСoefficients(N, L, M, Kh, Kv, h, Rc, Rk);
                double[,] matrixBarrelP = ds.barrelP(plateP, bottomholeP, N);

                double[,] extendedArray = ds.extendedArray(unknownСoefficients, matrixBarrelP, N);

                double[] result = ds.Gauss(extendedArray);
                int[] x = ds.XHoles(N, L);
                double summQ = 0;

                for (int i = 0; i < result.Length; i++)
                {
                    chartGraph.Series[0].Points.AddXY(x[i] + (100/(2 * N)), result[i]);
                    summQ += result[i];
                }
                double Qgeneral = Math.Round(86400.0 * summQ, 6);
                textBoxGeneral.Text += Qgeneral.ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
