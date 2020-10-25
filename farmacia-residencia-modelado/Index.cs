using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos_farmacia;

namespace farmacia_residencia_modelado
{
    public partial class Index : Form
    {
        DatosMedicamentos medic = new DatosMedicamentos();

        DataSet ds = new DataSet();
        public Index()
        {
            InitializeComponent();
        }

        #region METODOS
        private void LlenarDgNombre(string cual)
        {
            dg.Rows.Clear();
            if (cual == string.Empty)
            {
                ds = medic.consultarMedicamento("");
            }
            else
            {
                ds = medic.consultarMedicamento(cual);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
            }
        }

        private void LlenarDgVencimiento(int meses)
        {
            dg.Rows.Clear();
            if (meses == 0)
            {
                ds = medic.consultarVencimiento(0);
            }
            else
            {
                ds = medic.consultarVencimiento(meses);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
            }
        }

        private void LlenarDgCodigo(string codigo)
        {
            dg.Rows.Clear();
            if (codigo == "")
            {
                ds = medic.consultarCodigo("");
            }
            else
            {
                ds = medic.consultarCodigo(codigo);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
            }
        }

        private void LlenarDgLabo(string cual)
        {
            dg.Rows.Clear();
            if (cual == "")
            {
                ds = medic.consultarLaboratorio("");
            }
            else
            {
                ds = medic.consultarLaboratorio(cual);
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                }
            }
        }
        #endregion

        #region EVENTOS
        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            LlenarDgNombre(txtNom.Text);
        }

        private void combo_venc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_venc.SelectedIndex != -1)
            {
                LlenarDgVencimiento(combo_venc.SelectedIndex);
            }
            else
            {

            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            LlenarDgCodigo(txt_codigo.Text);
        }
        #endregion

        private void txt_labo_TextChanged(object sender, EventArgs e)
        {
            LlenarDgLabo(txt_labo.Text);
        }
    }
}