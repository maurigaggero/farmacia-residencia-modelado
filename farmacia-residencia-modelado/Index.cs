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
        private void LlenarDg(string medicamento, string labo, string codigo, int tiempo)
        {
            dg.Rows.Clear();
            ds = medic.consultarMedicamento(medicamento, labo, codigo, tiempo);

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
            LlenarDg(txtNom.Text, txt_labo.Text, txt_codigo.Text,combo_venc.SelectedIndex);
        }

        private void combo_venc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarDg(txtNom.Text, txt_labo.Text, txt_codigo.Text, combo_venc.SelectedIndex);
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            LlenarDg(txtNom.Text, txt_labo.Text, txt_codigo.Text, combo_venc.SelectedIndex);
        }
        #endregion

        private void txt_labo_TextChanged(object sender, EventArgs e)
        {
            LlenarDg(txtNom.Text, txt_labo.Text, txt_codigo.Text, combo_venc.SelectedIndex);
        }
    }
}