<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Default_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <script src="../JQueryLibrary/jquery-3.2.1.js"></script>
    <script>

        $(document).ready(function () {

            $("#ProductSections .LinkSections").click(function () {

                var link = $(this).attr("href");

                $("#Adesplegar").load(link + " #MainSectionContainer")

                return false;
            });
        });

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div id="Adesplegar">

    <div id="ProductSections">
        <a class="LinkSections" href="../Pages/Seccion_Hogar.aspx"><div class="Sections" id="Section1"><div>
            <img class="img" src="../IMGs/Categorias/Home.png" /></div><div style="color:white;" id="Desc1" class="Descripcion">Hogar</div></div></a>

        <a class="LinkSections" href="../Pages/Seccion_Electronicos.aspx"><div class="Sections" id="Section2"><div>
            <img class="img" src="../IMGs/Categorias/Electronics.png" /></div><div style="color:white;" id="Desc2" class="Descripcion">Electronicos</div></div></a>

        <a class="LinkSections" href="../Pages/Seccion_Herramientas.aspx"><div class="Sections" id="Section3"><div>
            <img class="img" src="../IMGs/Categorias/Tools.png" /></div><div style="color:white;" id="Desc3" class="Descripcion">Herramientas</div></div></a>

        <a class="LinkSections" href="../Pages/Seccion_Libros.aspx"><div class="Sections" id="Section4"><div>
            <img class="img" src="../IMGs/Categorias/Books.png" /></div><div style="color:white;" id="Desc4" class="Descripcion">Libros</div></div></a>

        <a class="LinkSections" href="../Pages/Seccion_Juegos.aspx"><div class="Sections" id="Section5"><div>
            <img class="img" src="../IMGs/Categorias/GameBoy.png" /></div><div style="color:white;" id="Desc5" class="Descripcion">Video Juegos</div></div></a>

        <div style="clear:both;" id="DivAnuncio" class="carousel slide">

            <ol class="carousel-indicators">
                <li data-target="#DivAnuncio" data-slide-to="0" class="active"></li>
                <li data-target="#DivAnuncio" data-slide-to="1"></li>
                <li data-target="#DivAnuncio" data-slide-to="2"></li>
            </ol>

            <div class="carousel-inner">

                <div class="item active">
                    <img style="width: 100%; height: auto;" class="img-responsive" src="../IMGs/Anuncios/BlackFriday.jpg" />
                </div>
                <div class="item">
                    <img style="width: 100%; height: auto;" class="img-responsive" src="../IMGs/Anuncios/Home.jpg" />
                </div>
                <div class="item">
                    <img style="width: 100%; height: auto;" class="img-responsive" src="../IMGs/Anuncios/Special.jpg" />
                </div>
            </div>

            <a class="carousel-control left" href="#DivAnuncio"  data-slide="prev">
                <span class="icon-prev"></span>
            </a>
            
            <a class="carousel-control right" href="#DivAnuncio"  data-slide="next">
                <span class="icon-next"></span>
            </a>
        </div>
    </div>

    <div style="background-color: #405772; color: white; text-align: center; float: left; width: 100%; "><h2>¡LO MAS VENDIDO!</h2></div>

    <div id="Products-Row">

        <div id="Products-Row-1">

            <div><h3 style="background-color: #5c7da3; color: white; text-align: center; width: 100%; ">ELECTRONICOS</h3></div>

            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 300px; height: 175px;" src="/IMGs/Electronics/Electronico17.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 160px; height: 175px;" src="/IMGs/Electronics/Electronico4.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 240px; height: 175px;" src="/IMGs/Electronics/Electronico10.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Electronics/Electronico7.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 320px; height: 175px;" src="/IMGs/Electronics/Electronico18.png" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
        </div>
       
        <div id="Products-Row-2">
            
            <div><h3 style="background-color: #5c7da3; color: white; text-align: center; width: 100%; ">HOME</h3></div>

            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 300px; height: 175px;" src="/IMGs/Home/Home1.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 300px; height: 175px;" src="/IMGs/Home/Home2.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 300px; height: 175px;" src="/IMGs/Home/Home3.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 300px; height: 175px;" src="/IMGs/Home/Home4.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 300px; height: 175px;" src="/IMGs/Home/Home5.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
        </div>                              
        <div id="Products-Row-3">
            
            <div><h3 style="background-color: #5c7da3; color: white; text-align: center; width: 100%; ">HERRAMIENTAS</h3></div>

            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 50px; height: 175px;" src="/IMGs/Tools/Tools1.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Tools/Tools2.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Tools/Tools3.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Tools/Tools4.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 150px; height: 175px;" src="/IMGs/Tools/Tools5.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
        </div>                              
        <div id="Products-Row-4">
            
            <div><h3 style="background-color: #5c7da3; color: white; text-align: center; width: 100%; ">VIDEO JUEGOS</h3></div>

            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/VideoGames/Game1.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/VideoGames/Game2.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/VideoGames/Game3.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 150px; height: 175px;" src="/IMGs/VideoGames/Game4.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/VideoGames/Game5.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
        </div>
        <div id="Products-Row-5">
            
            <div><h3 style="background-color: #5c7da3; color: white; text-align: center; width: 100%; ">LIBROS</h3></div>

            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Books/Libro1.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Books/Libro2.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Books/Libro3.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 150px; height: 175px;" src="/IMGs/Books/Libro4.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
            <a style="text-decoration: none;" href="#" class="Products-Row-C"><div><div class="ImgC"><img style="width: 200px; height: 175px;" src="/IMGs/Books/Libro5.jpg" /></div><div class="DescripcionP">Click Aqui Para Ver Producto</div></div></a>
        </div>
    </div>

</div>
</asp:Content>

