using System;
using System.Collections;
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
    public partial class ClubReservas : Form
    {

        //ArrayList listaApeNom = new ArrayList();
        ArrayList listaDni = new ArrayList();
        public ClubReservas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ClubReservas_Load(object sender, EventArgs e)
        {
            //Cargar comboBox socios
            clubraquetaDataSetTableAdapters.sociosTableAdapter taSocios = new clubraquetaDataSetTableAdapters.sociosTableAdapter();
            taSocios.FillByApeNomAsc(clubraquetaDataSet1.socios);

            for (int i = 0; i < clubraquetaDataSet1.socios.Count; i++)
            {
                //CARGAR NOMBRE Y APELLIDO EN COMBOBOX PERO USAR DNI POR DEBAJO

                //Creo arraylist para relacionar los registros por posicion y acceder a ellos aunque no se muestren en el comboBox
                //listaApeNom.Add(clubraquetaDataSet1.socios[i].apellidos + ", " + clubraquetaDataSet1.socios[i].nombre);
                listaDni.Add(clubraquetaDataSet1.socios[i].DNI);
                //Cargo el combo con el dato que quiero mostrar
                this.cboSocios.Items.Add(clubraquetaDataSet1.socios[i].apellidos + ", " + clubraquetaDataSet1.socios[i].nombre);
            }

            //Cargar comboBox pistas
            clubraquetaDataSetTableAdapters.pistasTableAdapter taPistas = new clubraquetaDataSetTableAdapters.pistasTableAdapter();
            taPistas.FillByNombreAsc(clubraquetaDataSet1.pistas);
            for (int i = 0; i < clubraquetaDataSet1.pistas.Count; i++)
            {
                this.cboPistas.Items.Add(clubraquetaDataSet1.pistas[i].nombre);
            }

            dtpFecha.MinDate = DateTime.Today;

        }

        private void cboSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet1.socios.Clear();
            //sociosTableAdapter1.FillByDNI(clubraquetaDataSet1.socios, cboSocios.Text);
            sociosTableAdapter1.FillByDNI(clubraquetaDataSet1.socios, listaDni[cboSocios.SelectedIndex].ToString());

            this.txtDni.Text = clubraquetaDataSet1.socios[0].DNI.ToString();
            this.txtNombre.Text = clubraquetaDataSet1.socios[0].nombre.ToString();
            this.txtApellidos.Text = clubraquetaDataSet1.socios[0].apellidos.ToString();
            this.txtDireccion.Text = clubraquetaDataSet1.socios[0].domicilio.ToString();
            this.mtxtTelefono.Text = clubraquetaDataSet1.socios[0].telefono.ToString();
            this.txtEmail.Text = clubraquetaDataSet1.socios[0].email.ToString();
            this.mtxtCCC.Text = clubraquetaDataSet1.socios[0].cuentaCorriente.ToString();

            this.cboPistas.Enabled = true;
            this.dtpFecha.Enabled = true;
            this.nudHora.Enabled = true;
            this.nudMinuto.Enabled = true;
            //this.btnReservar.Enabled = true;
            this.btnPagar.Enabled = true;
            //this.dgvReservasSocio.Enabled = true;

            clubraquetaDataSet1.reservas.Clear();
            reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, txtDni.Text);

        }

        private void cboPistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet1.pistas.Clear();
            this.pistasTableAdapter1.FillByNomPista(this.clubraquetaDataSet1.pistas, this.cboPistas.Text);

            this.txtIdPista.Text = clubraquetaDataSet1.pistas[0].idPista.ToString();

            if (clubraquetaDataSet1.pistas.Rows.Count > 0)
            {
                //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                //En este ejemplo nos quedamos con la primera
                DataRow myRow = clubraquetaDataSet1.pistas.Rows[0];

                //Se almacena el campo foto de la tabla en el array de bytes
                byte[] MyData = (byte[])myRow["foto"];
                //Se inicializa un flujo en memoria del array de bytes
                MemoryStream stream = new MemoryStream(MyData);
                //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                //el cual contiene el array de bytes
                picPistaSelec.Image = Image.FromStream(stream);
            }

            if (cboPistas.Text == "")
            {
                btnReservar.Enabled = false;
            }
            else
            {
                btnReservar.Enabled = true;
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, txtDni.Text);

            //Comprobar que no tiene reservas sin pagar

            bool sinPagar = false;
            for (int i = 0; i < clubraquetaDataSet1.reservas.Count; i++)
            {
                //Console.WriteLine(clubraquetaDataSet1.reservas[i].pagado);
                if (clubraquetaDataSet1.reservas[i].pagado.Equals("No"))
                {
                    sinPagar = true;
                }

            }
            if (sinPagar)
            {
                DialogResult msgSinPagar = MessageBox.Show("Tiene una reserva sin pagar", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                clubraquetaDataSet1.reservas.Clear();
                //Comprobar que la pista esta disponible en esa franja de 1 hora y 30 minutos
                this.reservasTableAdapter1.FillByPistaFecha(clubraquetaDataSet1.reservas, int.Parse(txtIdPista.Text), dtpFecha.Text);

                TimeSpan horaNuevaRes = new TimeSpan(int.Parse(nudHora.Value.ToString()), int.Parse(nudMinuto.Value.ToString()), 0); //Hora de la nueva reserva
                TimeSpan horaReservaAnterior; //Usare esta variable para comparar las horas de reservar con la que quiero hacer nueva
                                              //No se podra hacer si hay una reserva en el rango de una hora antes o despues de la que quiero para la nueva reserva

                TimeSpan horaComprobaciones;

                Boolean disponible = true;

                for (int i = 0; i < clubraquetaDataSet1.reservas.Count; i++)
                {
                    horaReservaAnterior = clubraquetaDataSet1.reservas[i].hora;

                    for (int m = -60; m <= 60; m = m + 30)
                    {
                        horaComprobaciones = horaNuevaRes.Add(TimeSpan.FromMinutes(m));
                        if (horaComprobaciones == horaReservaAnterior)
                        {
                            disponible = false;
                        }
                    }

                }

                if (!disponible)
                {
                    DialogResult horaNoDisp = MessageBox.Show("Esa pista ya esta reservada para esa hora", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Pista libre. Se pide mensaje de confirmación

                    DialogResult confRes = MessageBox.Show("Pista disponible. Confirmar reserva?", "Nueva reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (confRes == DialogResult.OK)
                    {
                        //Inserta reserva en BBDD
                        reservasTableAdapter1.InsertReserva(
                            dtpFecha.Text,
                            (new TimeSpan(int.Parse(nudHora.Value.ToString()), int.Parse(nudMinuto.Value.ToString()), 0)).ToString(),
                            int.Parse(txtIdPista.Text),
                            txtDni.Text,
                            "No",
                            Decimal.Multiply(clubraquetaDataSet1.pistas[0].precioHora, Decimal.Parse("1,5"))
                        );

                        MessageBox.Show("Reservado. Esperamos que disfrute su visita");

                        clubraquetaDataSet1.reservas.Clear();
                        reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, txtDni.Text);


                    }
                    else
                    {
                        MessageBox.Show("Reserva cancelada");
                    }

                }

            }



        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvReservasSocio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva");
            }
            else //Hay una reserva selecionada (en azul)
            {
                if (dgvReservasSocio.SelectedRows[0].Cells[5].Value.ToString().Equals("Si"))
                {
                    MessageBox.Show("La reserva seleccionada ya esta pagada");
                }
                else
                {
                    reservasTableAdapter1.UpdateQueryPagar(int.Parse(dgvReservasSocio.SelectedRows[0].Cells[0].Value.ToString()));
                    MessageBox.Show("Pago realizado con éxito");

                    //Recargar datagridview
                    clubraquetaDataSet1.reservas.Clear();
                    reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, txtDni.Text);
                }
            }
        }
    }
}
