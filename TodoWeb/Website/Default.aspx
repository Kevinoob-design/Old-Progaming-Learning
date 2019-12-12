<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" Runat="Server">

    <form id="form1" runat="server">

    <div id="box">

        <p class="test" id="testP" runat="server">
 
            <a href="WebPages/Rome/Rome.aspx">
                <img src="Images/asp.net_.png" />
                    </a>
                </p>
 
                <p>
                ​
                   Es un entorno para aplicaciones web desarrollado y comercializado por Microsoft. Es usado por programadores y diseñadores para construir sitios web dinamicos y aplicaciones web. Esta es la tecnologia sucesora de Active Server Pages (ASP). ASP.Net esta construido en el Common Lenguage Runtime, permitiendo a los programadores escribir codigo ASP.Net usando cualquier lenguaje admitido por el .Net Framework.
                </p>
     </div>

        <input type="text" placeholder="just a textbox" runat="server" id="TextBoxPrueba"/>
        
        <asp:TextBox ID="Text2" runat="server" placeholder="just a textbox" AutoComplete="off"></asp:TextBox>

        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick ="SubmitB" />

    </form>
</asp:Content>

