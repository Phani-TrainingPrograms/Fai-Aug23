<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DataCaching.ascx.cs" Inherits="SampleWebApp.Controls.DataCaching" %>
<div>
    <asp:Repeater runat="server" ID="rpData">
        <HeaderTemplate>
            <table border="1" width="100%">
                <tr>
                    <th>Product ID</th>
                    <th>Product Name</th>
                    <th>Product Price</th>
                    <th>Product Image</th>
                </tr>+
        </HeaderTemplate>
        <ItemTemplate>
            <tr style="background-color: red">
                <td><%#Eval("ProductId")%></td>
                <td><%#Eval("ProductName")%></td>
                <td><%#Eval("ProductPrice")%></td>
                <td><img src="<%#Eval("ProductImage")%>" height="75" width="50" /></td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: lightblue">
                <td><%#Eval("ProductId")%></td>
                <td><%#Eval("ProductName")%></td>
                <td><%#Eval("ProductPrice")%></td>
                <td><img src="<%#Eval("ProductImage")%>" height="75" width="50" /></td>
            </tr>
        </AlternatingItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</div>