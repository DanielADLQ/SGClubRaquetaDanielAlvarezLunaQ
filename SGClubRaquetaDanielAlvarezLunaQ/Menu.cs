using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaDanielAlvarezLunaQ
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClubSocios ventanaSocios = new ClubSocios();
            ventanaSocios.ShowDialog();
        }

        private void pistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClubPistas ventanaPistas = new ClubPistas();
            ventanaPistas.ShowDialog();
        }

        private void rESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "ClubReservas")
                {
                    this.MdiChildren[0].Close();

                    ClubReservas ventanaReservas = new ClubReservas(); //poner frm primero

                    ventanaReservas.MdiParent = this;
                    ventanaReservas.Dock = DockStyle.Fill;
                    ventanaReservas.Show();

                }

            }
            else
            {
                ClubReservas ventanaReservas = new ClubReservas(); //poner frm primero

                ventanaReservas.MdiParent = this;
                ventanaReservas.Dock = DockStyle.Fill;
                ventanaReservas.Show();
            }
        }
    }
}
