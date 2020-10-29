using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SISTEMADECLINICA.admin
{
    public partial class GestionarUsuario : System.Web.UI.Page
    {
        wcf_Service.ServiceClient service = new wcf_Service.ServiceClient();
        //dataset general
        DataSet ds = new DataSet();
        //dataset para cargar los empleados
        DataSet dsEmpleados = new DataSet();
        //Datase para cargar los privilegios
        DataSet dsPrivilegios = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                dsEmpleados = service.listarEmpleados();
                if (dsEmpleados != null)
                {
                    if (dsEmpleados.Tables.Count > 0)
                    {
                        if (dsEmpleados.Tables[0].Rows.Count >0)
                        {
                            ddlEmpleado.DataSource = dsEmpleados;
                            ddlEmpleado.DataMember = "listarEmpleados";
                            ddlEmpleado.DataValueField = "CodDoctor";
                            ddlEmpleado.DataTextField = "Nombres";
                            ddlEmpleado.SelectedIndex = -1;
                            ddlEmpleado.DataBind();
                        }
                    }
                }
            }

            if (!IsPostBack)
            {
                dsPrivilegios = service.listarPrivilegios();
                if (dsPrivilegios != null)
                {
                    if (dsPrivilegios.Tables.Count >0)
                    {
                        if (dsPrivilegios.Tables[0].Rows.Count >0)
                        {
                            ddlPrivilegios.DataSource = dsPrivilegios;
                            ddlPrivilegios.DataMember = "ListarPrivilegios";
                            ddlPrivilegios.DataValueField = "IdPrivilegio";
                            ddlPrivilegios.DataTextField = "Privilegio";
                            ddlPrivilegios.SelectedIndex = -1;
                            ddlPrivilegios.DataBind();
                        }
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string javaScript = "";
            try
            {
                ds = service.agregarUsuario(txtLogin.Text, txtContra.Text, int.Parse(ddlPrivilegios.SelectedValue), chEstado.Checked);
                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            javaScript = "mostrarMensaje('Exito','Registro Guardado con Exito');";
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                        }
                        else
                        javaScript = "mostrarMensaje('Advertencia','Error en la recuperación del nuevo IdUsuario. Favor validar datos.');";
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                    }
                    else
                        javaScript = "mostrarMensaje('Advertencia','Error en la creación del usuario. Favor validar datos');";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
                }
                else
                    javaScript = "mostrarMensaje('Advertencia','Error en la ejecución de la consulta!. Favor validar datos.');";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", javaScript, true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}