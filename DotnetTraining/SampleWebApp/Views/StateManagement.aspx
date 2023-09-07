<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="StateManagement.aspx.cs" Inherits="SampleWebApp.Views.StateManagement" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div>
        <h1>State Management in ASP.NET</h1>
        <hr />
        <div>
            <p>Enter the Name :
                <asp:TextBox runat="server" ID="txtName" /></p>
            <p>Enter the Email :
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" /></p>
            <p>
                <%--<asp:Button Text="Save State" runat="server" ID="btnSave" OnClick="btnSave_Click" PostBackUrl="~/Views/RecipiantPage.aspx"/>--%>
                <asp:Button Text="Save State" runat="server" ID="btnSave" OnClick="btnSave_Click" />
            </p>
        </div>
    </div>
</asp:Content>
