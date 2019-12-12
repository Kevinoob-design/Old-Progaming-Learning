<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PrincipalContent" Runat="Server">

    <div class="container">
        <div class="row">

            <div class="col-md-6 col-md-push-3">
                <div class="col2">main<h2>main shit</h2>
                    <div class="row">
                        <div class="col-md-4 visible-md visible-lg">
                            <div class="inside">Inside Col</div>
                        </div>
                        <div class="col-md-4 visible-md visible-lg">
                            <div class="inside">Inside Col</div>
                        </div>
                        <div class="col-md-4 visible-md visible-lg">
                            <div class="inside">Inside Col</div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-3 col-md-pull-6">
                <div class="col1">Side Left</div>
            </div>
            <div class="col-md-3">
                <div class="col3">Side Right</div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-3 col-xs-6">
                <div class="col4">col 4</div>
            </div>
            <div class="col-md-3 col-xs-6">
                <div class="col5">col 5</div>
            </div>
            <div class="col-md-3 col-xs-6">
                <div class="col6">col 6</div>
            </div>
            <div class="col-md-3 col-xs-6">
                <div class="col7">col 7</div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4 col-md-offset-4 hidden-xs">
                <div class="col7">OffSet</div>
            </div>
        </div>
    </div>

</asp:Content>

