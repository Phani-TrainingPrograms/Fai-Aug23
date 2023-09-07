<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SampleWebApp.Views.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h2>Registration Page</h2>
    <hr />
    <div class="row">
        <div class="col-md-6">
        <p>
            Enter the User Name: <asp:TextBox ID="txtUser" runat="server" CssClass="form-control"/>
            <asp:RequiredFieldValidator ErrorMessage="User Name is mandatory" ControlToValidate="txtUser" runat="server" />
        </p>

        <p>
            Enter the Password: <asp:TextBox ID="txtPwd" runat="server" CssClass="form-control" TextMode="Password"/>
            <asp:RequiredFieldValidator ErrorMessage="Password is must" ControlToValidate="txtPwd" runat="server" />
        </p>
        <p>
            ReEnter the Password: <asp:TextBox ID="txtRetype" runat="server" CssClass="form-control" TextMode="Password"/>
            <asp:CompareValidator ErrorMessage="Password mismatch" ControlToValidate="txtRetype" ControlToCompare="txtPwd" Type="String" runat="server" />
        </p>
        <p>
            <asp:Button Text="Register" runat="server" ID="btnSave" OnClick="btnSave_Click"/>
        </p>
    </div>
        <div class="col-md-5">
            <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
        </div>
    </div>

</asp:Content>
