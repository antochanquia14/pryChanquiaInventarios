using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChanquiaInventarios
{
    public partial class frmFuncionalidades : Form
    {
        public frmFuncionalidades()
        {
            InitializeComponent();
        }

        private void frmFuncionalidades_Load(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.ConectarBD();
        }
    }
}
