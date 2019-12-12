using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBoxPrueba.Visible = true;

        TextBoxPrueba.Attributes.Add("style", "border: solid 2px #000;;");

        Text2.Text = "this is tu madre";

        Text2.Attributes.Add("style", "border: solid 2px #000;;");
    }

    protected void SubmitB(object sender, EventArgs e)
    {
        Text2.Text = "se fue tu madre";
    }
}