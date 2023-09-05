<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SampleWebApp.HomePage" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #3366FF;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1" style="text-align: center">Welcome to ASP.NET Training</h1>
        </div>
    <p class="auto-style2">
        Welcome to ASP.NET Web App Development. It is a server side Web Technology that allows to develop Web Applications in an OOP manner using the .NET Technology</p>

        <div>
            <p>
                Enter the Name: <asp:TextBox runat="server" ID="txtName" />
            </p>
            <p>
                Enter the Email Address:
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Click" runat="server" OnClick="Unnamed1_Click" />
            </p>
            <p>
                <asp:Label ID="lblDisplay" runat="server" BackColor="LightBlue" BorderColor="#6600FF" BorderStyle="Dotted" ForeColor="White" Height="122px" Width="504px" />
            </p>
        </div>
    </form>

</body>
</html>
