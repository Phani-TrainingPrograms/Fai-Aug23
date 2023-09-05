<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataApp.aspx.cs" Inherits="SampleWebApp.DataApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="grdProducts"></asp:GridView>
        </div>
        <div>
            <p>
                Enter the Product Name: 
                <asp:TextBox runat="server" ID="txtName"/>
            </p>

            <p>
                Enter the Product Cost: 
                <asp:TextBox runat="server" ID="txtCost" TextMode="Number"/>
            </p>

            <p>
                Enter the Product Image: 
                <asp:TextBox runat="server" ID="txtImage"/>
            </p>
            <p>
                <asp:Button Text="Save Changes" ID="btnAdd" runat="server" OnClick="btnAdd_Click" />
            </p>
        </div>
        <div>
            <asp:Label Text="" ForeColor="Red" ID="lblStatus" runat="server" />
        </div>
        <div>
            <asp:Calendar runat="server" />      
        </div>
    </form>
</body>
</html>
