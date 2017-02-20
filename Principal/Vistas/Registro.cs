using Principal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Registro : Form
    {
        LogicaPersona log;
        Persona pers;
        public Registro()
        {
            InitializeComponent();
            this.TranslateUI();
            log = new LogicaPersona();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TranslateUI() {
            this.lblBienvenida.Text = Program.translator.translate(this.lblBienvenida.Name);
            this.lblApellido.Text = Program.translator.translate(this.lblApellido.Name);
            this.lblCedula.Text = Program.translator.translate(this.lblCedula.Name);
            this.lblDigitar.Text = Program.translator.translate(this.lblDigitar.Name);
            this.lblGenero.Text = Program.translator.translate(this.lblGenero.Name);
            this.lblNombre.Text = Program.translator.translate(this.lblNombre.Name);
            this.btnBorrar.Text = Program.translator.translate(this.btnBorrar.Name);
            this.btnBuscar.Text = Program.translator.translate(this.btnBuscar.Name);
            this.btnGuardar.Text = Program.translator.translate(this.btnGuardar.Name);
            this.btnModificar.Text = Program.translator.translate(this.btnModificar.Name);
            this.rbMasculino.Text = Program.translator.translate(this.rbMasculino.Name);
            this.rbFemenino.Text = Program.translator.translate(this.rbFemenino.Name);
            this.lblDigitar.Text = Program.translator.translate(this.lblDigitar.Name);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            lista.Items.Add(log.buscadorPorCedula(txtCedulaBuscar.Text));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.nombre = txtNombre.Text.ToString();
            p.apellido = txtApellido.Text.ToString();
            p.cedula = txtCedula.Text.ToString();

           if (rbMasculino.Checked)
            {
                p.genero = "Masculino";
            }
            else
            {
                p.genero = "Femenino";
            }

            log.agregarPersona(p);
            cargarLista();
            limpiar();

        }

        public void cargarLista()
        {
            lista.Items.Clear();
            List<Persona> pers = new List<Persona>();
            pers = log.listaPersonas();

            foreach (Persona p in pers)
            {
                lista.Items.Add(p);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            log.buscarPersona(lista.SelectedItem.ToString());
           
            cargarLista();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtApellido.Text = "";
        }

       

        private void btnModificar_Click(object sender, EventArgs e)
        {
            log.eliminarPersona(pers.cedula);
            Persona p = new Persona();
            p.nombre = txtNombre.Text.ToString();
            p.apellido = txtApellido.Text.ToString();
            p.cedula = txtCedula.Text.ToString();

            if (rbMasculino.Checked)
            {
                p.genero = "Masculino";
            }
            else
            {
                p.genero = "Femenino";
            }

            log.agregarPersona(p);
            cargarLista();
            limpiar();






        }

        private void lista_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cargarDatosenAplicacion();


        }

        public Persona cargarDatosenAplicacion()
        {
             pers = new Persona();
            pers = log.llenarDatos(lista.SelectedItem.ToString());
            txtNombre.Text = pers.nombre;
            txtApellido.Text = pers.apellido;
            txtCedula.Text = pers.cedula;
            if (pers.genero.Equals("Masculino"))
            {
                rbMasculino.Select();
            }
            else
            {
                rbFemenino.Select();
            }
            return pers;
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            Planilla pla = new Planilla(log);
            pla.Show();
          
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reporte re = new Reporte(log);
            re.Show();
        }
    }


}
