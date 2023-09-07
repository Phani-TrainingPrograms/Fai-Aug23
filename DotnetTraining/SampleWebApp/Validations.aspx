<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="Validations.aspx.cs" Inherits="SampleWebApp.Validations" %>
<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <style>
        .jumbo{
            padding:30px;
            margin:5px;
            font-size:38pt;
            text-align:center;
            background-color: lightcoral;
            border-radius:15px;
        }
    </style>
            <h1 class="jumbo">Page Validation Example</h1>
        <hr />
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="row">
                        <div class="col-md-6">
                        Enter the Name:<asp:TextBox CssClass="form-control" runat="server" ID="txtName" />
                        </div>
                        <div class="col-md-6">
                            <asp:RequiredFieldValidator ErrorMessage="Name must be entered" ControlToValidate="txtName" runat="server" ForeColor="IndianRed" />
                        </div>
                    </div>
                    <div>
                        Enter the Email Address:
                        <asp:TextBox CssClass="form-control" TextMode="Email" ID="txtEmail" runat="server" />
                        <asp:RegularExpressionValidator runat="server" ErrorMessage="Invalid Email Format" ControlToValidate="txtEmail" ForeColor="DarkRed" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                    </div>
                    <div>
                        Enter the Password:
                        <asp:TextBox CssClass="form-control"  runat="server" TextMode="Password" ID="txtPwd" />
                        <asp:RequiredFieldValidator ErrorMessage="Password is must" ControlToValidate="txtPwd" runat="server" ForeColor="DarkRed" />
                    </div>
                    <div>
                        ReType the Password:
                        <asp:TextBox CssClass="form-control"  runat="server" TextMode="Password" ID="txtRetype" />
                        <asp:CompareValidator ErrorMessage="Password mismatch" ControlToValidate="txtRetype" ControlToCompare="txtPwd" Type="String" runat="server" ForeColor="DarkRed"/>
                    </div>
                    <div>
                        Enter the Age:
                        <asp:TextBox CssClass="form-control"  runat="server" TextMode="Number" ID="txtAge" />
                        <asp:RangeValidator ErrorMessage="Age must be an Adult" ControlToValidate="txtAge" Type="Integer" ForeColor="DarkRed" MinimumValue="18" MaximumValue="45" runat="server" />
                    </div>
                    <div>
                        <asp:Button CssClass="btn btn-success" Text="Submit" runat="server" ID="btnSave" />
                    </div>
                    <p>
                        <asp:Label Text="" ID="lblDisplay" runat="server" />
                    </p>
                </div>
                <div class="col-md-5">
                    <asp:ValidationSummary runat="server" ForeColor="DarkRed" />
                </div>
            </div>
        </div>

</asp:Content>