using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SISTEMADECLINICA
{
    public partial class Login : System.Web.UI.Page
    {

        wcf_Service.ServiceClient service = new wcf_Service.ServiceClient();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Lo que está dentro de esta condición se va a ejecutar una sóla vez al cargar este WebForm
            if (!Page.IsPostBack)
            {
                HttpCookie cookieLogin = Request.Cookies["Login"];
                HttpCookie cookiePassword = Request.Cookies["Password"];
                HttpCookie cookieRecordar = Request.Cookies["Recordar"];
                if (cookieRecordar != null)//Si existe la cookie Recordar
                {
                    if (cookieRecordar.Value == "1")
                    {
                        txtLogin.Text = cookieLogin.Value;
                        txtPassword.Text = cookiePassword.Value;
                        chkRecordar.Checked = true;
                    }
                    else
                    {
                        chkRecordar.Checked = false;
                        Session["Login"] = null;
                        Session["Password"] = null;
                    }
                }
            }
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.ToString().Length == 0 || txtPassword.Text.ToString().Length == 0)
            {
                //Validar los datos almacenados en las cookies
                HttpCookie user = Request.Cookies["Login"];
                HttpCookie pass = Request.Cookies["Password"];
                if (chkRecordar.Checked)
                {
                    if (txtPassword.Text.Trim().Length > 0)//Si el usuario ingresa un password
                    {
                        if (pass.Value != txtPassword.Text.Trim())//Si el password digitado es diferente al de la cookie
                        {
                            HttpCookie cookiePassword = new HttpCookie("Password", txtPassword.Text);
                            cookiePassword.Expires = DateTime.Now.AddYears(100);
                            Response.Cookies.Add(cookiePassword);
                            Session["Password"] = txtPassword.Text;
                        }
                    }
                    else
                        Session["Password"] = pass.Value;
                        Session["Login"] = user.Value;
                }
                else
                {
                    string javaScript = "mostrarMensaje('Advertencia','El Login o el Password no pueden estar vacíos');";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                    Session["Login"] = null;
                }
            }

            
            
            //Creación y almacenamiento de las cookies
            if (chkRecordar.Checked)//Recordar usuario y contraseña
            {
                if (Session["Password"] == null)
                {
                    //Creando las cookies para recordar el usuario y contraseña
                    HttpCookie cookieLogin = new HttpCookie("Login", txtLogin.Text);
                    cookieLogin.Expires = DateTime.Now.AddYears(100);
                    Response.Cookies.Add(cookieLogin);//Se almacena la cookie con su valor en la PC del cliente

                    HttpCookie cookiePassword = new HttpCookie("Password", txtPassword.Text);
                    cookiePassword.Expires = DateTime.Now.AddYears(100);
                    Response.Cookies.Add(cookiePassword);

                    HttpCookie cookieRecordar = new HttpCookie("Recordar", "1");
                    cookieRecordar.Expires = DateTime.Now.AddYears(100);
                    Response.Cookies.Add(cookieRecordar);
                }
            }
            else//Vencer automáticamente las cookies de Usuario y Contraseña
            {
                HttpCookie cookieLogin = new HttpCookie("Login", "");
                cookieLogin.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(cookieLogin);//Se almacena la cookie con su valor en la PC del cliente

                HttpCookie cookiePassword = new HttpCookie("Password", "");
                cookiePassword.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(cookiePassword);

                HttpCookie cookieRecordar = new HttpCookie("Recordar", "0");
                cookieRecordar.Expires = DateTime.Now.AddYears(100);
                Response.Cookies.Add(cookieRecordar);
            }
            if (Session["Password"] == null)
            {
                Session["Login"] = txtLogin.Text;
                Session["Password"] = txtPassword.Text;
            }
            if (Session["Login"] != null && Session["Password"] != null)
            {
                //Ejecutar el método del WS para validar el usuario
                ds = service.validarUsuario(Session["Login"].ToString(), Session["Password"].ToString());
                if (ds != null)//Se valida si el DS se ejecutó sin problemas
                {
                    if (ds.Tables.Count > 0)//Valida que el DS tenga al menos un DataTable
                    {
                        if (ds.Tables[0].Rows.Count > 0)//Se valida que el DataTable tenga al menos un registro
                        {
                            if (ds.Tables[0].Rows[0]["IdUsuario"].ToString() != "-1")//Se valida que el usuario exista
                            {
                                if (bool.Parse(ds.Tables[0].Rows[0]["Estado"].ToString()))//Si se encuentra activo lo dejamos entrar al sistema
                                {
                                    Session["TipoUsuario"] = ds.Tables[0].Rows[0]["Privilegio"];
                                    txtLogin.Text = String.Empty;
                                   Response.Redirect("~/index.aspx");
                                }
                                else
                                {
                                    string javaScript = "mostrarMensaje('Advertencia','Usuario inactivo');";
                                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                                    Session["Login"] = null;
                                }
                            }
                            else
                            {
                                string javaScript = "mostrarMensaje('Advertencia','Usuario y Contrase&ntilde;a incorrecta');";
                                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                                Session["Login"] = null;
                            }
                        }
                        else
                        {
                            string javaScript = "mostrarMensaje('Advertencia','Nose encontro registro de usuario');";
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                            Session["Login"] = null;
                        }
                    }
                    else
                    {
                        lblMensajes.Text = "Sin registros!. Favor intente de nuevo.";
                        Session["Login"] = null;
                    }
                }
                else
                {
                    lblMensajes.Text = "No se pudo ejecutar la consulta!. Favor intente de nuevo.";
                    Session["Login"] = null;
                }
            }
            else
            {
                string javaScript = "mostrarMensaje('Advertencia','No hay una sesión activa ');";
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
            }
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
                lblMensajes.Text = "Usuario logueado: " + Session["Login"].ToString();
            else
                lblMensajes.Text = "La sesión a finalizado!";
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}