using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Conexion c = new Conexion();

    protected void Page_Load(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "Func()", true);

        //Response.Write("<script>alert('The page Loaded!')</script>");

    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        if(VerificarLogin(UserLogin.Text, Convert.ToInt32(PassLogin.Text)) == true)
        {
            Response.Write("<script>alert('Te logeaste exitosamente!')</script>");
        }
        else
        {
            Response.Write("<script>alert('Te la mamaste bien grande!')</script>");
        }
    }

    protected bool VerificarLogin(string Usuario, int Pass)
    {
        bool Validacion;

        if ((c.VerificarUsuario(Usuario, Pass) == 1)){

            Validacion = true;

        }
        else{

            Validacion = false;
        }

        return Validacion;
    }
}