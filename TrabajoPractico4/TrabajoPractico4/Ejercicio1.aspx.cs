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
            if (IsPostBack == false)
            {
                SqlConnection cnViajes = new SqlConnection();
                cnViajes.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";

                SqlCommand cmdProvinciasInicio = new SqlCommand("select * from provincias", cnViajes);
                cnViajes.Open();
                SqlDataReader drProvinciasInicio = cmdProvinciasInicio.ExecuteReader();
                while (drProvinciasInicio.Read())
                {
                    ddlProvinciasInicio.Items.Add(drProvinciasInicio["NombreProvincia"].ToString());
                    ddlProvinciasInicio.DataBind();
                }
                cnViajes.Close();
            }
        }

        protected void ddlProvinciasInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///////////////////////////////////// 
            /// DropDownList LocalidadInicio

            ddlLocalidadInicio.Items.Clear(); /// Se limpia el dropDownList para que quede vacío

            ddlLocalidadInicio.Items.Add("--Seleccionar--"); /// Se agrega el valor predeterminado --Seleccionar--

            string valor = ddlProvinciasInicio.SelectedIndex.ToString(); /// Se determina el valor del indice seleccionado
                                                                         /// en el DropDownList ProvinciasInicio

            SqlConnection cnViajes = new SqlConnection(); /// Se establece la coneccion con el servidor para realizar el filtrado de los datos

            cnViajes.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            SqlCommand cmdLocalidadesInicio = new SqlCommand("select * from Localidades WHERE IdProvincia = " + valor, cnViajes);
            cnViajes.Open();
            SqlDataReader drLocalidadesInicio = cmdLocalidadesInicio.ExecuteReader();
            while (drLocalidadesInicio.Read())
            {
                ddlLocalidadInicio.Items.Add(drLocalidadesInicio["NombreLocalidad"].ToString());
                ddlLocalidadInicio.DataBind();
            }
            cnViajes.Close();

            ddlLocalidadFinal.Items.Clear();
            ddlLocalidadFinal.Items.Add("--Seleccionar--");

            ///////////////////////////////////// 
            /// DropDownList ProvinciasFinal

            ddlProvinciasFinal.Items.Clear();
            ddlProvinciasFinal.Items.Add("--Seleccionar--");
            SqlCommand cmdProvinciasFinal = new SqlCommand("select * from Provincias WHERE IdProvincia !=  " + valor, cnViajes);
            cnViajes.Open();
            SqlDataReader drProvinciaFinal = cmdProvinciasFinal.ExecuteReader();
            while (drProvinciaFinal.Read())
            {
                ddlProvinciasFinal.Items.Add(drProvinciaFinal["NombreProvincia"].ToString());
                ddlProvinciasFinal.DataBind();
            }
            cnViajes.Close();
        }

        protected void ddlProvinciasFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlLocalidadFinal.Items.Clear(); /// Se limpia el dropDownList para que quede vacío
            ddlLocalidadFinal.Items.Add("--Seleccionar--"); /// Se agrega el valor predeterminado --Seleccionar--
            string valor;
            valor = ddlProvinciasFinal.SelectedItem.Text.ToString();
            if (ddlProvinciasFinal.SelectedItem.Text.ToString().ToUpper() == "BUENOS AIRES")
            {
                valor = "1";
            }
            else
            {
                if (ddlProvinciasFinal.Text.ToString().ToUpper() == "ENTRE RIOS")
                {
                    valor = "2";
                }
                else
                {
                    valor = "3";
                }
            }
            SqlConnection cnViajes = new SqlConnection(); /// Se establece la coneccion con el servidor para realizar el filtrado de los datos
            cnViajes.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            SqlCommand cmdLocalidadesFinal = new SqlCommand("select * from Localidades WHERE IdProvincia = " + valor, cnViajes);
            cnViajes.Open();
            SqlDataReader drLocalidadesFinal = cmdLocalidadesFinal.ExecuteReader();
            while (drLocalidadesFinal.Read())
            {
                ddlLocalidadFinal.Items.Add(drLocalidadesFinal["NombreLocalidad"].ToString());

                ddlLocalidadFinal.DataBind();
            }
            cnViajes.Close();
        }
    }
}