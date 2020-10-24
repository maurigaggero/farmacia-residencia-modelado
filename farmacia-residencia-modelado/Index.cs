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
        public Index()
        {
            InitializeComponent();
        }

        private void LlenarDg(string cual)
        {
            DatosMedicamentos medic = new DatosMedicamentos();

            dg.Rows.Clear();
            if (cual == "Todos")
            {
                DataSet ds = new DataSet();
                ds = medic.consultarMedicamento("todos");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                    }
                }
            }
            else
            {
                DataSet ds = new DataSet();
                ds = medic.consultarMedicamento(cual);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dg.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
                    }
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            LlenarDg(txtNom.Text);
        }
    }
}
