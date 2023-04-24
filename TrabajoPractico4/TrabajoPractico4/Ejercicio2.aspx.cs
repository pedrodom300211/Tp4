using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient; 

namespace TrabajoPractico4
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {     
        protected void Page_Load(object sender, EventArgs e)
        {            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            grdProductos.DataSource = dr;
            grdProductos.DataBind();
        }
        private String generarStringConsulta() /// genera sentencia sql
        {
            /// variable auxiliar para devolver sentencia
            String sentenciaSQL = "";
            /// Se analizan los valores en los controladores de texto y ddl
            if (txtIdCategoria.Text.Trim() != "" && txtIdProducto.Text.Trim() != "")
            {
                /// Filtros de textos IdProdcuto, Categoria y ddlIdProducto y ddlCategoria
                sentenciaSQL += "SELECT * FROM Productos WHERE IdProducto " + ddlIdProducto.SelectedValue + " " + txtIdProducto.Text;
                sentenciaSQL += " AND IdCategoría " + ddlIdCategoria.SelectedValue + " " + txtIdCategoria.Text;
            }
            else
            {
                if (txtIdProducto.Text.Trim() != "")
                {
                    /// Filtros de textos IdProdcuto y ddlIdProducto
                    sentenciaSQL += ("SELECT * FROM Productos WHERE IdProducto " + ddlIdProducto.SelectedValue + " " + txtIdProducto.Text);
                }
                else
                {
                    if (txtIdCategoria.Text.Trim() != "")
                    {
                        /// Filtros de textos IdCategoria y ddlIdCategoria
                        sentenciaSQL += ("SELECT * FROM Productos WHERE IdCategoría " + ddlIdCategoria.SelectedValue + " " + txtIdCategoria.Text);
                    }
                    else
                    {
                        /// Sin filtros
                        sentenciaSQL += ("SELECT * FROM Productos");
                    }
                }
            }
            /// Retorno la sentencia a ejecutar
            return sentenciaSQL;
        }
        private void consultarBaseDeDatos(String sentenciaSQL) /// ejecuta sentencia sql
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sentenciaSQL, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            grdProductos.DataSource = dr;
            grdProductos.DataBind();
            cn.Close();
        }
        private void limpiarFiltros() /// limpia y reinica filtros txt y ddl
        {
            txtIdProducto.Text = ""; /// limpia TextBox ID de producto
            txtIdCategoria.Text = ""; /// limpia TextBox ID de categoria
            ddlIdProducto.SelectedIndex = 0; /// se selecciona el valor = de DropDownList ID prodcuto {=, >, <}
            ddlIdCategoria.SelectedIndex = 0; /// se selecciona el valor = de DropDownList ID categoria {=, >, <}
        }
        protected void btnFiltrar_Click(object sender, EventArgs e) /// evento boton click
        {
            /// Variable donde estara la consulta es return de funcion generarStringConsulta()
            /// LLamo funcion que genera consulta analizando los filtros retorna un string sentenciaSQL
            /// LLamo funcion que ejecuta la consulta recive un string sentenciaSQL y ejecuta la consulta
            consultarBaseDeDatos(generarStringConsulta());
            /// limpio los filtros txt "" y ddl index 0
            limpiarFiltros();
        }
    }
}