<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Navigation Bar.aspx.cs" Inherits="Pages_Navigation_Bar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalContent" Runat="Server">

    <form runat="server">
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">

                    <asp:Button runat="server" CssClass="navbar-toggle" data-toggle="collapse" data-target="#NavCollapse" Text="Expand"/>

                    <button type="button" runat="server" class="navbar-toggle" data-toggle="collapse" data-target="#NavCollapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>

                    <a class="navbar-brand" href="#">Hector M</a>
                </div>

                <div class="collapse navbar-collapse" id="NavCollapse">
                    <ul class="nav navbar-nav">
                       <li class="active"><a href="#">Home</a></li>
                       <li><a href="#">News</a></li>
                       <li><a href="#">Life Style</a></li>
                       <li><a href="#">Entretaiment</a></li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                       <li><a href="#"> <span class="glyphicon glyphicon-envelope"></span> Contact Us</a></li>
                       <li><a href="#"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
                    </ul>

                    <div class="navbar-form navbar-right">
                        <div class="form-group">
                           <asp:TextBox runat="server" placeholder="Search" CssClass="form-control"></asp:TextBox>

                            <asp:Button runat="server" Text="Submit" CssClass="btn btn-danger" />
                        </div>
                    </div>
                </div>
            </div>
        </nav>
    </form>
</asp:Content>

