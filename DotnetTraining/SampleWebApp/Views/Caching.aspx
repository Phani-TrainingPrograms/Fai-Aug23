<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="SampleWebApp.Views.Caching" %>

<%--<%@ OutputCache Duration="60" VaryByParam="city" %>--%>
<%@ Register TagPrefix="myCtrls" TagName="TimeControl" Src="~/Controls/TimeControl.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h2>Caching in ASP.NET</h2>
    <hr />
    <div class="row">
        <div class="col-md-4">
            <p>
                The local time:
                <asp:Label ID="lblLocalTime" runat="server" BackColor="Aqua" BorderColor="#CC66FF" BorderStyle="Dotted" Font-Size="XX-Large" Height="151px" Width="150px" />
            </p>

        </div>
        <div class="col-md-4">
            <p>
                Select the City: 
            <asp:DropDownList runat="server" ID="lstCities" AutoPostBack="true" OnSelectedIndexChanged="lstCities_SelectedIndexChanged">
                <asp:ListItem>Select the City</asp:ListItem>
                <asp:ListItem>New Delhi</asp:ListItem>
                <asp:ListItem>New York</asp:ListItem>
                <asp:ListItem>Canbera</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
                <asp:ListItem>Tokyo</asp:ListItem>
            </asp:DropDownList>
            </p>
            <p>
                <asp:Label Text="" ID="lblTime" runat="server" />
            </p>

        </div>

        <div class="col-md-4">
            <myCtrls:TimeControl runat="server" />
        </div>
    </div>

</asp:Content>
