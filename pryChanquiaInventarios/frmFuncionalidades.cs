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
            clsConexionBD clsConexionBD_V2 = new clsConexionBD();
            clsConexionBD_V2.ConectarBD();
            clsConexionBD_V2.CargarCategorias(cmbCategoría);
            
            clsConexionSQL clsConexionSQL= new clsConexionSQL();
            clsConexionSQL.ConectarSQL();

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pryChanquiaInventarios.clsConexionBD clsConexionBD = new pryChanquiaInventarios.clsConexionBD();
            clsConexionBD.ConectarBD();
            clsConexionBD.cargarDatos(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(cmbCategoría.Text), Convert.ToString(txtNombre.Text), Convert.ToString(txtDescripción.Text));
        }
    }
    }
