﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "Hello!";
            }

            int y = 0;

            for(int i = 0; i < 10; i++)
            {
                y += i;
            }
        }
    }
}