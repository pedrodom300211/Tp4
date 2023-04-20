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
                SqlCommand cmd = new SqlCommand("select * from provincias", cnViajes);
                cnViajes.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ddlProvinciasInicio.DataSource = dr;
                ddlProvinciasInicio.DataTextField = "NombreProvincia";
                ddlProvinciasInicio.DataValueField = "Idprovincia";
                ddlProvinciasInicio.DataBind();
                cnViajes.Close();
            }

        }
    }
}