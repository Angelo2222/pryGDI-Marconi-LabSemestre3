using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGDI_Marconi_LabSemestre3
{
    public partial class frmArk : Form
    {
        public frmArk()
        {
            InitializeComponent();
        }

        private void frmArk_Load(object sender, EventArgs e)
        {
            picNave.Hide();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            btnJugar.Hide();
            picNave.Show();
            //lienzo = contenedor.CreateGraphics();
            //lienzo.DrawRectangle(lapiz, 230, 320, 150, 70);
            temporizador.Enabled = true;
        }
        int ejeX, ejeY = 0;
        Random aleatorioX = new Random();
        Random aleatorioY = new Random();

        private void temporizador_Tick(object sender, EventArgs e)
        {
            ejeX = aleatorioX.Next(0, 500);

            picNave.Location = new Point(ejeX, 376);

            //lienzo = new Point(ejeX, 400);
            //lienzo.DrawRectangle(lapiz, ejeX, ejeY, 150, 700);
        }

        private void picNave_Click(object sender, EventArgs e)
        {

        }
    }
}
