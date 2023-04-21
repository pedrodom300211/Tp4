using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TrabajoPractico4
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                SqlConnection cnViajes = new SqlConnection();
                cnViajes.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
                /// Consulta Provincias Inicio
                SqlCommand cmdProvinciasInicio = new SqlCommand("select * from provincias", cnViajes);
                cnViajes.Open();
                SqlDataReader drProvinciasInicio = cmdProvinciasInicio.ExecuteReader();
                while (drProvinciasInicio.Read())
                {
                    ddlProvinciasInicio.Items.Add(drProvinciasInicio["NombreProvincia"].ToString());
                    ddlProvinciasInicio.DataBind();
                } 
                cnViajes.Close();
                /// Consulta localidades Inicio
                SqlCommand cmdLocalidadesInicio = new SqlCommand("select * from Localidades", cnViajes);
                cnViajes.Open();
                SqlDataReader drLocalidadesInicio = cmdLocalidadesInicio.ExecuteReader();
                while (drLocalidadesInicio.Read())
                {
                    ddlLocalidadInicio.Items.Add(drLocalidadesInicio["NombreLocalidad"].ToString());
                    ddlLocalidadInicio.DataBind();
                }
                cnViajes.Close();
                /// Consulta Provincias Final
                SqlCommand cmdProvinciasFinal = new SqlCommand("select * from Provincias", cnViajes);
                cnViajes.Open();
                SqlDataReader drProvinciasFinal = cmdProvinciasFinal.ExecuteReader();
                while (drProvinciasFinal.Read())
                {
                    ddlProvinciasFinal.Items.Add(drProvinciasFinal["NombreProvincia"].ToString());
                    ddlProvinciasFinal.DataBind();
                }
                cnViajes.Close();
            }

        }
    }
}