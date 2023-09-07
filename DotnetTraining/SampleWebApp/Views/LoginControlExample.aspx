<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LoginControlExample.aspx.cs" Inherits="SampleWebApp.Views.LoginControlExample" %>
<%@ Register TagPrefix="myCtrls" TagName="LoginControl" Src="~/Controls/LoginControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <myCtrls:LoginControl ID="myLogin" runat="server" Title="Please login here" CreateUserUrl="~/Views/Registration.aspx" ShowCreateUser="True"  />
</asp:Content>
