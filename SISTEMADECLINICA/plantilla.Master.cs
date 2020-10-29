using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SISTEMADECLINICA
{
    public partial class principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Todo lo que está dentro de la sección del IsPostBack se ejecuta una sóla vez al cargar el WebForm
            if (!Page.IsPostBack)
            {
                if (Session["Login"] == null)
                    Response.Redirect("~/Login.aspx");
                else
                {
                    lblUsuarioRegistrado.Text = Session["Login"].ToString();
                }

            }
            else
            {
                if (Session["Login"] == null)
                    Response.Redirect("~/Login.aspx");
            }
        }
    }
}