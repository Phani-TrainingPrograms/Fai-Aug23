<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SampleWebApp.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContent" runat="server">
    <h1>Please login here!!!</h1>
    <hr />
    <asp:Login runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" CreateUserText="New User?Sign Up" Font-Names="Lucida Calligraphy" Font-Size="Medium" ForeColor="#333333" Height="302px" UserNameLabelText="Login Name:" Width="713px" LoginButtonText="Sign In" ID="loginCtrl" OnAuthenticate="Unnamed1_Authenticate" CreateUserUrl="Registration.aspx">
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
        <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
    </asp:Login>

    <div class="row">
        <div class="col-md-5">
            The OTP generated is: 
            <asp:Label runat="server" ID="lblOtp" />
        </div>

        <div class="col-md-5">
            Enter the Otp: 
            <asp:TextBox runat="server" ID="txtOtp"/>
            <asp:Button Text="Send" ID="btnSend" runat="server" OnClick="btnSend_Click" />
        </div>

    </div>
</asp:Content>
