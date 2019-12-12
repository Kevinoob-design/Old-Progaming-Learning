<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DropDown Menu.aspx.cs" Inherits="Pages_DropDown_Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalContent" Runat="Server">
    <form runat="server">
        <div class="dropdown">
       
            <asp:Button runat="server" Text="Seleccione"  CssClass="btn btn-primary dropdown-toggle" data-toggle="dropdown"/>

            <ul class="dropdown-menu" role="menu">
                <li class="dropdown-header">Header1</li>
                <li><a href="#">Opcion1</a></li>
                <li><a href="#">Opcion2</a></li>

                <li class="divider"></li>
                
                <li class="dropdown-header">Header2</li>
                <li><a href="#">Opcion3</a></li>
                <li><a href="#">Opcion4</a></li>
                <li><a href="#">Opcion5</a></li>
            </ul>  
        </div>
    </form>
</asp:Content>

