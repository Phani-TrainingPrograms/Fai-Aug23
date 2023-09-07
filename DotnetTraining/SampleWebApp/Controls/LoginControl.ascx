<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="SampleWebApp.Controls.LoginControl" %>
<div style="border: 2px solid blue; width:50%">
    <h2><asp:Label ID="lblTitle" runat="server" /></h2>
    <hr />
    <p>
        Enter the UserName: <asp:TextBox runat="server" ID="txtUser"/>
    </p>
    <p>
        Enter the Password: <asp:TextBox runat="server" ID="txtPwd" TextMode="Password"/>
    </p>
    <p>
        <asp:Button Text="Login" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
    </p>
    <p>
        <asp:HyperLink ID="hyperLink" runat="server" Text="New User? Sign Up">

        </asp:HyperLink>
        </p>
    <p>
        <asp:Label ID="lblError" Visible="false" runat="server" ForeColor="Red" />
    </p>
</div>