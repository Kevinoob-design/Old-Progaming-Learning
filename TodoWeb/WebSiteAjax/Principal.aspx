<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="Principal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<style>
#noticias li {
	display: inline-block;
	margin-right: 30px;
}
#noticias li a {
	padding: 5px 10px; 
	background-color: white;
	color: black;
	text-decoration: none;	
}
#noticias li a:hover {
	background-color: rgb(255,153,0);
	color: white;
}
#contenidos_externos, #noticia {
	margin-top: 10px;
	padding: 20px;
	border: 1px solid white;	
}
</style>

<script src="jquery-3.2.1.js"></script>
<script>

$(document).ready(function() {

	$("#noticias a").click(function(){

		$("#contenidos_externos").load("deportivas.html")


	});

			
}); 
</script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="cabecera">
		<p class="logo">Píldoras informáticas. Función load()</p>
	</div>

	<div class="contenido">
		<div class="principal">
			<h1>Noticias varias</h1>
			<ul id="noticias">
				<li><a href="Generales.aspx">Noticias Generales</a></li>
				<li><a href="Deportivas.aspx">Noticias Deportivas</a></li>
				<li><a href="Tiempo.aspx">Noticias del Tiempo</a></li>
			</ul>
			<div id="contenidos_externos"></div>
		</div>
	</div>
</asp:Content>

