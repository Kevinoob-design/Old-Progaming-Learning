<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deafault.aspx.cs" Inherits="SinglePage.Deafault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/Style.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/AjaxEJ.js"></script>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" id="botonTabla" value="Cargar tabla" />
            <br />
            <table id="tblDatos" class="tblDatos">
                <thead>
                    <tr>
                        <th class="thDatos">Id</th>
                        <th class="thDatos">Nombre</th>
                        <th class="thDatos">Edad</th>
                    </tr>
                </thead>

                <tbody id="contenido"></tbody>
            </table>
        </div>
    </form>
</body>
</html>
