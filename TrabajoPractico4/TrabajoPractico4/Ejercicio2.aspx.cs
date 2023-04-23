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

        public void llamarProductosIgualA(string idProducto) {
            
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";

                cn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE IdProducto = " + idProducto, cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdProductos.DataSource = dr;
                grdProductos.DataBind();
            
        }

        public void llamarProductosMayorA(string idProducto)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE IdProducto > " + idProducto, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            grdProductos.DataSource = dr;
            grdProductos.DataBind();

        }

        public void llamarProductosMenorA(string idProducto)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";

            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE IdProducto < " + idProducto, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            grdProductos.DataSource = dr;
            grdProductos.DataBind();

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            btnFiltrar_Click(sender, e); 
        }

        protected void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text.Trim() == "")
            {

            }
            else {
                if (ddlIdProducto.SelectedIndex == 0)
                {
                    llamarProductosIgualA(txtIdProducto.Text);
                }
                else if (ddlIdProducto.SelectedIndex == 1){
                    llamarProductosMayorA(txtIdProducto.Text); 
                } else
                {
                    llamarProductosMenorA(txtIdProducto.Text);
                }             
            }                                
        }
    }
}