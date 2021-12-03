using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaDanielAlvarezLunaQ
{
    public partial class ClubPistas : Form
    {
        public ClubPistas()
        {
            InitializeComponent();
        }

        private void pistasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pistasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clubraquetaDataSet);

        }

        private void ClubPistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clubraquetaDataSet.pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro de que quiere borrar la pista?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //Comprueba si tiene reservas la pista
                reservasTableAdapter1.FillByPista(clubraquetaDataSet.reservas, int.Parse(idPistaLabel1.Text));

                if (clubraquetaDataSet.reservas.Count > 0)
                {
                    //Prohibimos borrarla
                    DialogResult dr2 = MessageBox.Show("La pista tiene reservas. No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.pistasTableAdapter.DeletePista(int.Parse(idPistaLabel1.Text));
                    MessageBox.Show("Pista borrada con exito");
                    this.pistasTableAdapter.Fill(this.clubraquetaDataSet.pistas);

                }
            }

            clubraquetaDataSet.Clear();
            pistasTableAdapter.Fill(clubraquetaDataSet.pistas);

        }

        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            //Suponemos que ofdExaminar es un OpenFileDialog incorporado al formulario
            ofdExaminar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = ofdExaminar.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //para guardar la ruta al fichero con la imagen en un TextBox (por si se quiere mostrar)
            var RutaFichero = ofdExaminar.FileName;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            //picFoto.Image = Image.FromFile(ofdExaminar.FileName);


            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco, suponiendo que esa ruta se muestra en el campo txtRutaFichero
            FileStream stream = new FileStream(RutaFichero, FileMode.Open, FileAccess.Read);
            //Se inicializa un vector de Bytes del tamaño de la imagen
            byte[] binData = new byte[stream.Length];
            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
            stream.Read(binData, 0, Convert.ToInt32(stream.Length));

            //Si tuviésemos un pictureBox, podríamos mostrar la imagen obtenida desde el flujo de datos
            fotoPictureBox.Image = Image.FromStream(stream);

            //AHORA LLEGA LA PARTE DE INSERCIÓN EN LA BD
            this.pistasTableAdapter.UpdateFoto(binData, int.Parse(idPistaLabel1.Text.ToString()));

        }
    }
}
