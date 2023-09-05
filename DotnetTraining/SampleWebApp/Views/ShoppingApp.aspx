<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingApp.aspx.cs" Inherits="SampleWebApp.Views.ShoppingApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">

                <div class="col-md-4 m2">
                    <h1>List of Products with Us: </h1>
                    <asp:ListBox runat="server" ID="lstProducts" Height="613px" Width="430px" OnSelectedIndexChanged="lstProducts_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                </div>
                <div class="col-md-2"></div>
                <div class="col-md-6 m5">
                    <h2>Details of the selected Product</h2>
                    <p>
                        Product Id:
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
                    </p>
                    <p>
                        Product Name:
                <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
                    </p>
                    <p>
                        Product Price:
                <asp:TextBox runat="server" ID="txtPrice" CssClass="form-control" />
                    </p>
                    <p>
                        Product Image:
                <asp:Image ID="imgProduct" runat="server" Height="306px" Width="383px" />
                    </p>
                </div>
            </div>
            <div class="row">
                <asp:DataList ID="dlRecent" runat="server" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <div style="margin:5px">
                            <h3><%#Eval("ProductName")%></h3>
                            <hr />
                            <p>
                                <img src="<%#Eval("Image")%>" style="width:200px; height:100px"/>
                            </p>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </form>
</body>
</html>
