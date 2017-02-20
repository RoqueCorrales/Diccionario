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
    public partial class Reporte : Form
    {
        LogicaPersona log;
        Persona per;
        public Reporte()
        {
            InitializeComponent();
            per = new Persona();
        }
        public Reporte(LogicaPersona logica)
        {
            InitializeComponent();
            per = new Persona();
            this.log = logica;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            per = log.buscadorPorCedula(textBox1.Text);

            txtNombre.Text = per.nombre + " " + per.apellido;
            lbLista.Items.Add(per + " Hora Entrada " + per.horaEntrada + " Hora Salida " + per.horaSalida);

        }
    }
}
