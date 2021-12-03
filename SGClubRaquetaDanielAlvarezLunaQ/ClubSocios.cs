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
    public partial class ClubSocios : Form
    {

        public ClubSocios()
        {
            InitializeComponent();
        }

        private void cargarComboSocios()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var qConsulta1 = from soc in objBD.socios
                                 orderby soc.apellidos, soc.nombre
                                 select new
                                 {
                                     soc.DNI
                                 };

                var lista = qConsulta1.ToList();

                foreach (var resultado in lista)
                {
                    cboListaDni.Items.Add(resultado.DNI);
                }

            }
        }

        private void cargarDgvSocios()
        {
            //Mostrar socios
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                socios objSoc = new socios();

                var qConsultaSocios = from s in objBD.socios
                                      orderby s.apellidos,s.nombre
                                      select new
                                      {
                                          s.DNI,
                                          s.apellidos,
                                          s.nombre,
                                          s.telefono,
                                          s.email
                                      };

                dgvSocios.DataSource = qConsultaSocios.ToList();
            }
        }

        private void ClubSocios_Load(object sender, EventArgs e)
        {
            cargarComboSocios();
        }

        private void cboListaDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var qConsultaDatosSocio = from soc in objBD.socios
                                          where soc.DNI == cboListaDni.Text
                                         select new
                                         {
                                             soc.DNI,
                                             soc.nombre,
                                             soc.apellidos,
                                             soc.domicilio,
                                             soc.telefono,
                                             soc.cuentaCorriente,
                                             soc.email
                                         };

                var lista = qConsultaDatosSocio.ToList();

                foreach (var resultado in lista)
                {
                    txtDniSelec.Text = resultado.DNI;
                    txtNombre.Text = resultado.nombre;
                    txtApellidos.Text = resultado.apellidos;
                    txtDireccion.Text = resultado.domicilio;
                    txtEmail.Text = resultado.email;
                    mtxtTelefono.Text = resultado.telefono;
                    mtxtCCC.Text = resultado.cuentaCorriente;
                }

            }
        }

        private void btnModSoc_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                socios objSoc = objBD.socios.Find(txtDniSelec.Text);


                if (objSoc != null)
                {
                    if (txtNombre.Text.Length != 0)
                    {
                        objSoc.nombre = txtNombre.Text;
                    }

                    if (txtApellidos.Text.Length != 0)
                    {
                        objSoc.apellidos = txtApellidos.Text;
                    }

                    if (txtDireccion.Text.Length != 0)
                    {
                        objSoc.domicilio = txtDireccion.Text;
                    }

                    if (mtxtTelefono.MaskFull)
                    {
                        objSoc.telefono = mtxtTelefono.Text;
                    }

                    if (mtxtCCC.MaskFull)
                    {
                        objSoc.cuentaCorriente = mtxtCCC.Text;
                    }

                    if (txtEmail.Text.Length != 0)
                    {
                        objSoc.email = txtEmail.Text;
                    }


                    //guardar cambios
                    objBD.SaveChanges(); //aqui se guarda en la base de datos
                    MessageBox.Show("Socio actualizado correctamente");

                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    mtxtTelefono.Text = "";
                    txtDireccion.Text = "";
                    mtxtCCC.Text = "";
                    txtEmail.Text = "";

                    //Volver a cargar dgv con los cambios
                    cargarDgvSocios();

                }
                else
                {
                    MessageBox.Show("No se ha encontrado el socio");
                }

            }
        }

        private void btnEliminarSoc_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                socios objSoc = objBD.socios.Find(txtDniSelec.Text);

                if (objSoc != null)
                {
                    //Comprobar si el socio tiene reservas
                    var qReservasSocio = from r in objBD.reservas
                                         where r.socio == txtDniSelec.Text
                                         select new
                                         {
                                             r.idReserva
                                         };

                    var listaRes = qReservasSocio.ToList();

                    if(listaRes.Count > 0)
                    {
                        MessageBox.Show("No se puede eliminar el socio porque tiene reservas","Borrado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        objBD.socios.Remove(objSoc);

                        //guardar cambios
                        objBD.SaveChanges(); //aqui se guarda en la base de datos
                        MessageBox.Show("Socio eliminado correctamente");
                        //Volver a cargar comboBox y el dgv
                        cboListaDni.Items.Clear();
                        cargarComboSocios();
                        cargarDgvSocios();

                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el socio");
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cargarDgvSocios();
        }

        private void btnCrearSoc_Click(object sender, EventArgs e)
        {
            //INSERTAR SOCIO

            //Comprobar que campos esten rellenos correctamente antes de insertar

            if (!mtxtDniNuevoSoc.MaskFull)
            {
                MessageBox.Show("Error. DNI incompleto");
            }
            else
            {
                //Compruebo que no existe ya un socio con el mismo DNI

                bool dniNuevo = true;

                for (int i = 0; i < cboListaDni.Items.Count; i++)
                {
                    if (cboListaDni.Items[i].ToString() == mtxtDniNuevoSoc.Text.ToUpper())
                    {
                        dniNuevo = false;
                    }
                }

                if (!dniNuevo)
                {
                    MessageBox.Show("Error. Ese socio ya esta registrado");
                }
                else
                {
                    //Si hay algun campo vacio o mascara incompleta
                    if (!mtxtTelefono.MaskFull || !mtxtCCC.MaskFull || txtNombre.Text.Length == 0 || txtApellidos.Text.Length == 0 || txtDireccion.Text.Length == 0 || txtEmail.Text.Length == 0)
                    {
                        MessageBox.Show("Error. Rellena todos los datos correctamente");
                    }
                    else
                    {
                        //Comprobaciones correctas. Se realiza la insercion en la BD
                        using (clubraquetaEntities objBD = new clubraquetaEntities())
                        {
                            //creamos el objeto categoria
                            socios objSoc = new socios(); //objCat es objeto de la clase categoria que sirve para mapear los elementos

                            objSoc.DNI = mtxtDniNuevoSoc.Text.ToUpper();
                            objSoc.nombre = txtNombre.Text;
                            objSoc.apellidos = txtApellidos.Text;
                            objSoc.domicilio = txtDireccion.Text;
                            objSoc.telefono = mtxtTelefono.Text;
                            objSoc.cuentaCorriente = mtxtCCC.Text;
                            objSoc.email = txtEmail.Text;

                            //se añade el objeto a la tabla, para incluirlo
                            objBD.socios.Add(objSoc);

                            //guardar cambios
                            objBD.SaveChanges(); //aqui se guarda en la base de datos
                            MessageBox.Show("Socio insertado correctamente");

                            //Volver a cargar comboBox y dgv
                            cboListaDni.Items.Clear();
                            cargarComboSocios();
                            cargarDgvSocios();

                            txtNombre.Text = "";
                            txtApellidos.Text = "";
                            mtxtTelefono.Text = "";
                            txtDireccion.Text = "";
                            mtxtCCC.Text = "";
                            txtEmail.Text = "";

                        }
                    }
                }

            }

        }
    }
}
