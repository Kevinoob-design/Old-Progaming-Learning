<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Pages_HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="row">
        <div id="Superior" class="col-md-12 text-center"><a href="#"><h1>Welcome</h1></a></div>
    </div>

    <div class="row">
        <a href="#"><div id="Col1" class="col-md-3 text-center">Columna1</div></a>
        <a href="#"><div id="Col2" class="col-md-3 text-center">Columna2</div></a>
        <a href="#"><div id="Col3" class="col-md-3 text-center">Columna3</div></a>
        <a href="#"><div id="Col4" class="col-md-3 text-center">Columna4</div></a>
    </div>

    <div class="row">
        <a class="LinkDiv" href="#"><div id="Col5" class="col-md-6 text-center">Columna5</div></a>
        <a class="LinkDiv" href="#"><div id="Col6" class="col-md-6 text-center">Columna6</div></a>
    </div>

    <div class="row" id="Col7">
       <div class="col-md-12 text-center">Columna7</div>
    </div>

</asp:Content>

