﻿using Portal_aukcyjny.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portal_aukcyjny.Accounts
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (MyPresenter.IsUserLoggedIn())
            {
                Response.Redirect(Page.ResolveUrl("~/Default.aspx"));
            }
        }
    }
}