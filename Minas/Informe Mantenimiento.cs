using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minas
{
    public partial class Informe_Mantenimiento : Form
    {
        Connection _con = new Connection();
        int idSolicitud = 0;
        public Informe_Mantenimiento()
        {
            InitializeComponent();
        }

        private void dataSolicitudes_MouseEnter(object sender, EventArgs e)
        {
            var data = _con.SelectData("select * from Solicitud Solicitud where idTecnico ='1'");
            dataSolicitudes.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _con.InsertData("update Solicitud set estado ='En atencion' where codigo = '" + idSolicitud + "'");
            dataSolicitudes_MouseEnter(sender, e);
        }

        // Update Inicio Tecnico de Mantenimiento 
        private void dataSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string dataID = dataSolicitudes.Rows[n].Cells[0].Value.ToString();
                if (dataID != null && dataID != "")
                {
                    Console.WriteLine(idSolicitud = Convert.ToInt32(dataID));

                }
            }
        }
        // Update Fin Tecnico de Mantenimiento
        private void button2_Click(object sender, EventArgs e)
        {
            _con.InsertData("update Solicitud set estado ='Finalizado' where codigo = '" + idSolicitud + "'");
            dataSolicitudes_MouseEnter(sender, e);
        }
        
    }
}
