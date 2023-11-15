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
    public partial class frmArk2 : Form
    {
        private int moveAmount = 10;
        public frmArk2()
        {
            InitializeComponent();
        }

        private void frmArk2_Load(object sender, EventArgs e)
        {
            // Verificar si se presionó la tecla izquierda
            if (e.KeyCode == Keys.Left)
            {
                if (picNave.Left > 0)
                {
                    picNave.Left -= moveAmount; // Mover hacia la izquierda
                }

            }
            // Verificar si se presionó la tecla derecha
            else if (e.KeyCode == Keys.Right)
            {
                if (picNave.Right < ClientSize.Width)
                {
                    picNave.Left += moveAmount; // Mover hacia la derecha
                }

            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {

        }
    }
}
