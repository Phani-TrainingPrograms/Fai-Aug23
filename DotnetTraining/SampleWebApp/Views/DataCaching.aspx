<%@ Page MasterPageFile="~/Main.Master" Language="C#" AutoEventWireup="true" CodeBehind="DataCaching.aspx.cs" Inherits="SampleWebApp.Views.DataCaching" %>
<%@ Register TagPrefix="myctrls" TagName="repeater" Src="~/Controls/DataCaching.ascx" %>   
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <myctrls:repeater runat="server" />   
</asp:Content>