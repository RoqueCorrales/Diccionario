using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate;

namespace Principal
{
    public partial class btnOK : Form
    {
        public btnOK()
        {
            InitializeComponent();
            cargarComboIdioma();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cargarComboIdioma()
        {
            cbIdioma.DataSource = Enum.GetValues(typeof(EnumIdiomas));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
            if (cbIdioma.SelectedItem.ToString().Equals("English")){
                Program.translator = new Ingles();
                this.Close();
            }else
            {
                Program.translator = new Espannol();
                this.Close();
            }
            
        }
    }
}
