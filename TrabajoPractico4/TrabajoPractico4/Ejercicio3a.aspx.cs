﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico4
{
    public partial class Ejercicio3a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnVerLibros_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio3B.aspx");
        }
    }
}