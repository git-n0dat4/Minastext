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
    public partial class Solicitar_Mantenimiento : Form
    {
        Connection _con = new Connection();
        string fechaSolicitud = DateTime.Now.ToShortDateString();
        string tipoMantenimiento = "preventivo";
        string Solicitante = "Operador1";
        string Maquina = "maquina1";
        public Solicitar_Mantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insertar Solicitud Operador
                _con.InsertData("insert into Solicitud (fechaSolicitud,tipoMantenimiento,solicitante,maquina,fechaAtencion, estado,idTecnico,nameTecnico)" +
               "values('" +fechaSolicitud+"','"+tipoMantenimiento+ "','"+Solicitante+"','"+Maquina+"','En espera de asignacion','Solicitado','','')");
        }
    }
}
