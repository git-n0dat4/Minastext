using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minas
{
    public partial class Gestion_Mantenimiento : Form
    {
        Connection _con = new Connection();
      
        int idSolicitud = 0;
        string estado = "Solicitado";
        string fechaatencion = "en espera"; // cambia cuando el gestor diga
        // operador crea solicitado, gestorMantenimiento update a aprobada, operador inicio update  atencion - finaliza Finalizado
        // tipo de mantenimiento preventivo, no se xd
        int idTecnico = 0;
        string nameTecnico = "";
        public Gestion_Mantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer Solicitudes Gestor Mantenimiento
                var data = _con.SelectData("select * from Solicitud");
                 datat.DataSource = data;
        }
        // Obtener ID Solicitud dek datagriewview 1
        private void datat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if(n!= -1 )
            {
                string dataID = datat.Rows[n].Cells[0].Value.ToString();
                if (dataID != null && dataID != "") 
                {
                    idSolicitud =  Convert.ToInt32(dataID);
                    
                }
            }
        }
        // Obtener ID Tecnico dek datagriewview 1
        private void datat1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool disp = false;
            int n = e.RowIndex;
            if (n != -1)
            {
                string dataID = datat1.Rows[n].Cells[0].Value.ToString();
                if (dataID != null && dataID != "")
                {
                    disp = (bool)datat1.Rows[n].Cells[2].Value;
                    if (disp.Equals(true))
                    {
                        idTecnico = Convert.ToInt32(dataID);
                        nameTecnico = datat1.Rows[n].Cells[1].Value.ToString();
                    }
                    else
                    {
                         idSolicitud = 0;
                         idTecnico = 0;
                         nameTecnico = "";
                    }
                
                }
            }
        }

        // Update Gestor de Mantenimiento
        private void button2_Click(object sender, EventArgs e)
        {
                 fechaatencion = "22-11-23"; estado = "En espera";
                 // Update fecha Atencion - Estado Gestor de Mantenimiento
                if (idSolicitud != 0 && idTecnico != 0 && nameTecnico != null)
                 {
                     _con.InsertData("update Solicitud set fechaAtencion = '" + fechaatencion + "', estado = '" + estado + "'" +
                         ", idTecnico = '" + idTecnico + "', nameTecnico = '" + nameTecnico + "' where codigo = '" + idSolicitud + "'");
                 }
                 else
                     Console.WriteLine("nada");   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Leer Tecnicos Gestor Mantenimiento
               var data = _con.SelectData("select * from tecnicoM");
              datat1.DataSource = data;
        }
    }
}
