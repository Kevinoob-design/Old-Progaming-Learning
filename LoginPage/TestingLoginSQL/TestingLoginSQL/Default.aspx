<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Login Page</title>

    <link href="Style/MainStyle.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">

        <div id="MainDiv">

            <div id="LoginDiv">

                <div id="LoginTittle">
                    <h2>Log in into your account</h2>
                </div>

                <div id="LoginBox">

                    <div id="TextContainer">

                       <div id="UsernameBox" class="LoginText">
                            <asp:TextBox ID="UserLogin" runat="server" 
                                placeholder="Username" AutoComplete="off" Font-Size="Larger" CssClass="LoginText"></asp:TextBox>
                        </div>
                        <div id="PasswordBox" class="LoginText">
                            <asp:TextBox ID="PassLogin" runat="server" 
                                placeholder="Password" AutoComplete="off" Font-Size="Larger" CssClass="LoginText"></asp:TextBox>
                        </div>
                    </div>

                    <div id="SubmitContainer">

                       <div id="SubmitButton" class="SubmitLoad">
                            <asp:Button ID="LoginButton" runat="server" Text="Log In" BorderStyle="Outset" CssClass="SubmitLoad" OnClick="LoginButton_Click" />
                        </div>
                        <div id="OverrideButton" class="SubmitLoad">
                            <asp:Button ID="Override" runat="server" Text="Access without Log in" BorderStyle="Outset" CssClass="SubmitLoad" />
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </form>
</body>

<script type="text/javascript">

    function Func() {
        alert("hello!")
    }

</script>
</html>
