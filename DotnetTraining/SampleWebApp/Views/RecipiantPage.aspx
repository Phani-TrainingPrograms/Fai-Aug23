<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecipiantPage.aspx.cs" MasterPageFile="~/Main.Master" Inherits="SampleWebApp.Views.RecipiantPage" Trace="true" %>
<%@ PreviousPageType VirtualPath="~/Views/StateManagement.aspx" %>
<asp:Content ContentPlaceHolderID="mainContent" runat="server">
    <h1>Recipiant Page</h1>
    <div>
        <h2>Data Sharing Method :
            <asp:Label Text="" runat="server" ID="lblMethod" /></h2>
        <asp:Label ID="lblDisplay" runat="server" BorderStyle="Dashed" Width="1000px" Height="400px" BorderColor="Red" />
    </div>
</asp:Content>
