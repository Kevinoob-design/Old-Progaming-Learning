<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" Runat="Server">

    <div class="contentText">

    <h1 style="text-align: center; padding-top: 20px;"><b>ASP.Net</b></h1>
 

<br />
<br />

<img src="../../Images/20151215031256_aspnet.jpg" style="margin: 0 auto; width: 100%;"/>
 
        
<br />
<br />

<b>Web Forms:</b> son el principal medio de construccion para el desarrollo de aplicaciones web. Los formularios web estan contenidos en archivos con una extension ASPX. Estos archivos tipicamente contienen etiquetas HTML, y tambien etiquetas definiendo Controles Web que se procesan del lado del servidor y Controles de Usuario donde los desarrolladores colocan todo el código estatico y dinamico requerido por la pagina web.
<br />
<br />

<b>Modelo Code-Behind:</b> Microsoft recomienda que para realizar programacion dinamica se use el modelo Code-Behind, que coloca el codigo en un archivo separado o en una etiqueta Script especialmente diseñada.
Cuando se usa este estilo de programacion, el desarrollador escribe el codigo correspondiente a diferentes eventos, como la carga de la pagina, o el clic de un control, en vez de un recorrido lineal a traves del documento.
<br />
<br />

<b>Controles de Usuario:</b> ASP.Net permite la creacion de componentes reutilizables a traves de la creacion de Controles de Usuario.
Un control de usuario sigue la misma estructura que un formulario web, excepto que los controles derivan de la clase "System.web.UserControl", y son almacenados en archivos ASCX. Y como los ASPX, estos contienen etiquetas HTML, y tambien pueden usar el Modelo Cpde-Behind.
<br />
<br />

<b>Motor de Plantillas:</b> ASP.Net incluye lo que son los motores de plantillas. Esto es un software que esta diseñado para procesar unas plantillas web los cuales contienen toda la parte visual del sitio.
El uso de plantillas web es bastante interesante, ya que permiten al programador separar la logica de control de la logica de vista, lo cual garantiza que si se modifican las plantillas web no se altera la logica de control y en base a esto podemos tener un programador y un diseñador grafico trabajando al mismo tiempo.

</div>

</asp:Content>

