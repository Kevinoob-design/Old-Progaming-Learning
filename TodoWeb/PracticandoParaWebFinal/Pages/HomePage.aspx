<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainMasterPage.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Pages_HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div id="DivAnuncio" class="carousel slide">

            <ol class="carousel-indicators">
                <li data-target="#DivAnuncio" data-slide-to="0" class="active"></li>
                <li data-target="#DivAnuncio" data-slide-to="1"></li>
                <li data-target="#DivAnuncio" data-slide-to="2"></li>
            </ol>

            <div class="carousel-inner">

                <div class="item active">
                    <img style="width: 100%; height: auto;" class="img-responsive" src="../Imgs/2fac8024-1c0a-405f-9c82-4e17fb31ad3c.jpg" />
                </div>
                <div class="item">
                    <img style="width: 100%; height: auto;" class="img-responsive" src="../Imgs/61d4c1f1-0286-4e9d-aab4-08b951e0cc92.jpg" />
                </div>
                <div class="item">
                    <img style="width: 100%; height: auto;" class="img-responsive" src="../Imgs/967f3f04-2fda-434f-a2b9-ae3c89b74d4e.jpg" />
                </div>
            </div>

            <a class="carousel-control left" href="#DivAnuncio"  data-slide="prev">
                <span class="icon-prev"></span>
            </a>
            
            <a class="carousel-control right" href="#DivAnuncio"  data-slide="next">
                <span class="icon-next"></span>
            </a>
        </div>

        <div id="ContentOpciones">
            <div class="DivOpciones">
                <a href="#">
                <div><img class="Loguitos" src="https://compass-ssl.xbox.com/assets/59/b5/59b55110-f43c-483c-aa6d-891ed8a3848a.svg?n=Homepage-FY18_Home-Icons-0_Consoles_72x56.svg" /></div>
                <div>Consolas</div>
                </a>
            </div>

            <div class="DivOpciones">
                <a href="#">
                <div><img class="Loguitos" src="https://compass-ssl.xbox.com/assets/01/88/0188d0c0-ded9-494f-bc02-5b91459d91a3.svg?n=Homepage-FY18_Home-Icons-0_Games_72x56.svg" /></div>
                <div>Juegos</div>
                </a>
            </div>

            <div class="DivOpciones">
                <a href="#">
                <div><img class="Loguitos" src="https://compass-ssl.xbox.com/assets/8b/76/8b768a46-9bc2-4f47-b019-fbc12e57f39d.svg?n=Homepage-FY18_Home-Icons-0_Accessories_72x56.svg" /></div>
                <div>Accesorios</div>
                </a>
            </div>

            <div class="DivOpciones">
                <a href="#">
                <div><img class="Loguitos" src="https://compass-ssl.xbox.com/assets/16/d6/16d60dd2-3e50-4df9-a0e3-21ccce5217ce.svg?n=Homepage-FY18_Home-Icons-0_Community_72x56.svg" /></div>
                <div>XBOX LIVE</div>
                </a>
            </div>

            <div class="DivOpciones">
                <a href="#">
                <div><img class="Loguitos" src="https://compass-ssl.xbox.com/assets/45/95/45953951-814f-4cdd-86df-b03ee4b511c3.svg?n=Homepage-FY18_Home-Icons-0_Deals_72x56.svg" /></div>
                <div>Ofertas</div>
                </a>
            </div>

            <div class="DivOpciones">
                <a href="#">
                <div><img class="Loguitos" src="https://compass-ssl.xbox.com/assets/95/04/95043aca-52cf-4b7b-8ee2-e3e3a2231abb.svg?n=Homepage-FY18_Home-Icons-0_Sign-In_72x56_02.svg" /></div>
                <div>Iniciar Sesion</div>
                </a>
            </div>
        </div>

        <div id="MainContentContainner">

            <div class="BigContent MyItem">
                <img src="../Imgs/4fd192cd-852a-4032-a190-86b9782a99dd.jpg" />
            </div>

            <div style="background: green;" class="SmallContent MyItem">
            </div>
            
            <div style="background: red;" class="SmallContent MyItem">
            </div>

           <div class="BigContent MyItem">
               <img src="../Imgs/c0566e53-aa06-49f6-ae6e-ddf6237b5f61.jpg" />
            </div>

            <div style="background: blue;" class="SmallContent MyItem">
            </div>
            
            <div style="background: gray;" class="SmallContent MyItem">
            </div>

            <div id="MidContent" class="MyItem">
                <img src="../Imgs/b4ae03f6-3b1d-4f75-b1d3-12ea1d2afd74.jpg" />  
            </div>

            <div style="background: green;" class="SmallContent MyItem">
            </div>
            
            <div style="background: red;" class="SmallContent MyItem">
            </div>

            <div class="BigContent MyItem">
                <img src="../Imgs/d9773e52-4e6f-493b-a135-7873221d8371.jpg" />
            </div>

            <div class="BigContent MyItem">
               <img src="../Imgs/e2d89cfe-469b-4653-a90d-149d3da9b0a2.jpg" />
            </div>

            <div style="background: blue;" class="SmallContent MyItem">
            </div>

            <div style="background: gray;" class="SmallContent MyItem">
            </div>
        </div>
</asp:Content>

