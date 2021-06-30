using ListaTutores.DATOS;
using ListaTutores.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTutores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID_TUTOR.Text.Trim() == "")
            {
                MessageBox.Show(" DEBE INGRESAR UN ID VALIDO");
            }else if (txtNOMBRES.Text.Trim().Length < 5)
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE MAS LARGO");
            }
            else
            {
                try
                {
                    Tutor eM = new Tutor();
                    eM.ID_TUTOR1 = txtID_TUTOR.Text.Trim().ToUpper();
                    eM.NOMBRES1 = txtNOMBRES.Text.Trim().ToUpper();
                    eM.APELLIDOS1 = txtAPELLIDOS.Text.Trim().ToUpper();
                    eM.TITULO_ACADEMICO1 = txtTITULO_ACADEMICO.Text.Trim().ToUpper();
                    eM.DIRECCION1 = txtDIRECCION.Text.Trim().ToUpper();
                    eM.FECHA_NACIMIENTO1 = txtFNACIMIENTO.Value.Year+"-"+ txtFNACIMIENTO.Value.Month + "-"+ txtFNACIMIENTO.Value.Day;
                    if (TutorCAD.Guardar(eM))
                    {
                        llenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("DATOS DE TUTOR GUARDADOS CORRECTAMENTE");
                    }
                    else
                    {
                        MessageBox.Show("YA EXISTE OTRO TUTOR CON LA MISMA ID");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }
        
        private void llenarGrid()
        {
            DataTable datos = TutorCAD.Listar();
            if (datos== null)
            {
                MessageBox.Show("NO SE PUDO ACCEDER A LOS DATOS ");
            }
            else
            {
                dgLista.DataSource = datos.DefaultView;
            }

        }
        private void LimpiarCampos()
        {
            txtID_TUTOR.Text = "";
            txtNOMBRES.Text = "";
            txtAPELLIDOS.Text = "";
            txtTITULO_ACADEMICO.Text = "";
            txtDIRECCION.Text = "";
            txtFNACIMIENTO.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        bool consultado = false;

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID_TUTOR.Text.Trim() == "")
            {
                MessageBox.Show(" DEBE INGRESAR UN ID ");
            }
            else 
            {
                Tutor eM = TutorCAD.Consultar(txtID_TUTOR.Text.Trim());
                if (eM == null)
                {
                    MessageBox.Show("No existe el Tutor con ID" + txtID_TUTOR.Text);
                    LimpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtID_TUTOR.Text = eM.ID_TUTOR1;
                    txtNOMBRES.Text = eM.NOMBRES1;
                    txtAPELLIDOS.Text = eM.APELLIDOS1;
                    txtTITULO_ACADEMICO.Text = eM.TITULO_ACADEMICO1;
                    txtDIRECCION.Text = eM.DIRECCION1;
                    txtFNACIMIENTO.Text = eM.FECHA_NACIMIENTO1;
                    consultado = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (consultado== false)
            {
                MessageBox.Show(" DEBE CONSULTAR EL TUTOR");
            }
            else if (txtID_TUTOR.Text.Trim() == "")
            {
                MessageBox.Show(" DEBE INGRESAR UN ID VALIDO");
            }
            else if (txtNOMBRES.Text.Trim().Length < 5)
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE MAS LARGO");
            }
            else
            {
                try
                {
                    Tutor eM = new Tutor();
                    eM.ID_TUTOR1 = txtID_TUTOR.Text.Trim().ToUpper();
                    eM.NOMBRES1 = txtNOMBRES.Text.Trim().ToUpper();
                    eM.APELLIDOS1 = txtAPELLIDOS.Text.Trim().ToUpper();
                    eM.TITULO_ACADEMICO1 = txtTITULO_ACADEMICO.Text.Trim().ToUpper();
                    eM.DIRECCION1 = txtDIRECCION.Text.Trim().ToUpper();
                    eM.FECHA_NACIMIENTO1 = txtFNACIMIENTO.Value.Year + "-" + txtFNACIMIENTO.Value.Month + "-" + txtFNACIMIENTO.Value.Day;
                    if (TutorCAD.Actualizar(eM))
                    {
                        llenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("DATOS DE TUTOR ACTUALIZADOS CORRECTAMENTE");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("NO SE LOGRO ACTUALIZAR ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show(" DEBE CONSULTAR EL TUTOR");
            }
            else if (txtID_TUTOR.Text.Trim() == "")
            {
                MessageBox.Show(" DEBE INGRESAR UN ID VALIDO");
            }
            else if (DialogResult.Yes==MessageBox.Show(null,"REALMENTE DESEA ELIMINAR DATOS DEL TUTOR?","CONFIRMACION",MessageBoxButtons.YesNo))
            {
                try
                {
                  
                    if (TutorCAD.Eliminar(txtID_TUTOR.Text.Trim()))
                    {
                        llenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("DATOS DE EMPLEADO ELIMINADO CORRECTAMENTE");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("NO SE ELIMINO ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
