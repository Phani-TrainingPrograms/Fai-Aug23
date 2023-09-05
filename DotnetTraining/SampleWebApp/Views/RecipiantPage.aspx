<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecipiantPage.aspx.cs" Inherits="SampleWebApp.Views.RecipiantPage" Trace="true" %>
<%@ PreviousPageType VirtualPath="~/Views/StateManagement.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Recipiant Page</h1>
    <form id="form1" runat="server">
        <div>
            <h2>Data Sharing Method : <asp:Label Text="" runat="server" ID="lblMethod"/></h2>
            <asp:Label ID="lblDisplay" runat="server" BorderStyle="Dashed" Width="1000px" Height="400px" BorderColor="Red"/>
        </div>
    </form>
</body>
</html>
