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
    public partial class Planilla : Form
    {
        LogicaPersona log;
        Persona per;
        public Planilla()
        {
            InitializeComponent();
            
            per = new Persona();

        }
        public Planilla(LogicaPersona logica)
        {
            InitializeComponent();
            this.log = logica;
            per = new Persona();

        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            per = log.buscadorPorCedula(txtBuscar.Text);

            txtNombre.Text = per.nombre + " " + per.apellido;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dateEntrada.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            per.horaEntrada = dateEntrada.Value;

            date2.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            per.horaSalida = dateEntrada.Value;


        }
    }
}
