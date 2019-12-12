<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent1" Runat="Server">

    <div class="contentText"> <br/>

        <form id="theForm" runat="server">
 
            <div class="row">
                <label for="name">Name:</label><input type="text" id="name" name="">&nbsp;
                <br> <br>
            </div>
 
            <div class="row">
                <label for="address">Address:</label>
                <input type="text" id="address" name=""> <br> <br>
            </div>
 
            <div class="row">
                <label for="phone">Phone:</label>
                <input type="tel" id="phone" name=""> <br> <br>
            </div>
 
            <div class="row">
                <label for="email">Email:</label>
                <input type="email" id="email" name="">
            </div>
        </form>

        <div class="row2">

            <label>Aqui el nombre</label>
            <label>Aqui el apellido</label>
            <label>Aqui el numero</label>
            <label>Aqui el email</label>
        </div>
    </div>
</asp:Content>



