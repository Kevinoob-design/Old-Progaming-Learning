<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Buttons Boostrap.aspx.cs" Inherits="Pages_Buttons_Boostrap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalContent" Runat="Server">

    <form id="form1" runat="server">

        <asp:Button runat="server" text="Button" CssClass="btn-lg"/>
        <asp:Button runat="server" text="Button" CssClass="btn-sm btn-default"/>
        <asp:Button runat="server" text="Button" CssClass="btn-xl btn-danger"/>
        <asp:Button runat="server" text="Button" CssClass="btn-lg btn-info"/>
        <asp:Button runat="server" text="Button" CssClass="btn-xs btn-primary"/>
        <asp:Button runat="server" text="Button" CssClass="btn btn-success"/>
        <asp:Button runat="server" text="Button" CssClass="btn btn-warning"/>

        <asp:Button runat="server" text="Button"  CssClass="btn-lg btn-warning btn-block"/>

        <asp:Button runat="server" text="Button" CssClass="btn btn-warning disabled"/>

        <br />
        <br />

        <div class="btn-group" role="group">

            <asp:Button runat="server" text="Boton" CssClass="btn btn-success"/>
            <asp:Button runat="server" text="Boton1" CssClass="btn btn-info"/>
            <asp:Button runat="server" text="Boton2" CssClass="btn btn-default"/>
        </div>

        <br />
        <br />

        <div class="btn-group btn-group-lg" role="group">

            <asp:Button runat="server" text="Boton" CssClass="btn btn-success"/>
            <asp:Button runat="server" text="Boton1" CssClass="btn btn-info"/>
            <asp:Button runat="server" text="Boton2" CssClass="btn btn-default"/>
        </div>

        <br />
        <br />

        <div class="btn-group-vertical btn-group-xs" role="group">

            <asp:Button runat="server" text="Boton" CssClass="btn btn-success"/>
            <asp:Button runat="server" text="Boton1" CssClass="btn btn-info"/>
            <asp:Button runat="server" text="Boton2" CssClass="btn btn-default"/>
        </div>

        <br />
        <br />

        <div class="btn-toolbar" role="toolbar" id="ToolBar">

         <div class="btn-group-horizontal btn-group-lg" role="group">

            <asp:Button runat="server" text="1" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="2" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="3" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="4" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="5" CssClass="btn btn-primary"/>
        </div>

        <div class="btn-group-horizontal btn-group-lg" role="group">

            <asp:Button runat="server" text="6" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="7" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="8" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="9" CssClass="btn btn-primary"/>
            <asp:Button runat="server" text="10" CssClass="btn btn-primary"/>
        </div>

        </div>

    </form>
</asp:Content>

