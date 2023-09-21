using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Euclides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Math.Max(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
            int n2 = Math.Min(int.Parse(txtN1.Text), int.Parse(txtN2.Text));

            EuclidesRecursivo(n1, n2);

            gv1.AutoResizeColumns();
            gv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void EuclidesRecursivo(int a, int b)
        {
            int rowCount = gv1.Rows.Add();
            gv1.Rows[rowCount].Cells[0].Value = rowCount + 1;
            gv1.Rows[rowCount].Cells[1].Value = a + " dividido entre " + b + " es " + (a / b) + " y sobran " + (a % b);
            gv1.Rows[rowCount].Cells[2].Value = a + " = " + b + " x " + (a / b) + " + " + (a % b);

            if ((a % b) != 0)
            {
                EuclidesRecursivo(b, a % b);
            }
        }
    }
}