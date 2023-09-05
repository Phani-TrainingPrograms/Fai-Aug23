<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataDemo.aspx.cs" Inherits="SampleWebApp.DataDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Demo for ASP.NET Features</h1>
            <hr />
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="empId" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." Height="389px" Width="1660px">
            <Columns>
                <asp:BoundField DataField="empId" HeaderText="empId" ReadOnly="True" SortExpression="empId" />
                <asp:BoundField DataField="empName" HeaderText="empName" SortExpression="empName" />
                <asp:BoundField DataField="empAddress" HeaderText="empAddress" SortExpression="empAddress" />
                <asp:BoundField DataField="empSalary" HeaderText="empSalary" SortExpression="empSalary" />
                <asp:BoundField DataField="DeptId" HeaderText="DeptId" SortExpression="DeptId" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FaiTrainingConnectionString1 %>" DeleteCommand="DELETE FROM [Emptable] WHERE [empId] = @empId" InsertCommand="INSERT INTO [Emptable] ([empName], [empAddress], [empSalary], [DeptId]) VALUES (@empName, @empAddress, @empSalary, @DeptId)" ProviderName="<%$ ConnectionStrings:FaiTrainingConnectionString1.ProviderName %>" SelectCommand="SELECT [empId], [empName], [empAddress], [empSalary], [DeptId] FROM [Emptable]" UpdateCommand="UPDATE [Emptable] SET [empName] = @empName, [empAddress] = @empAddress, [empSalary] = @empSalary, [DeptId] = @DeptId WHERE [empId] = @empId">
            <DeleteParameters>
                <asp:Parameter Name="empId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="empName" Type="String" />
                <asp:Parameter Name="empAddress" Type="String" />
                <asp:Parameter Name="empSalary" Type="Decimal" />
                <asp:Parameter Name="DeptId" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="empName" Type="String" />
                <asp:Parameter Name="empAddress" Type="String" />
                <asp:Parameter Name="empSalary" Type="Decimal" />
                <asp:Parameter Name="DeptId" Type="Int32" />
                <asp:Parameter Name="empId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="empId" DataSourceID="SqlDataSource2" Height="149px" Width="498px">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="empId" HeaderText="empId" InsertVisible="False" ReadOnly="True" SortExpression="empId" />
                <asp:BoundField DataField="empName" HeaderText="empName" SortExpression="empName" />
                <asp:BoundField DataField="empAddress" HeaderText="empAddress" SortExpression="empAddress" />
                <asp:BoundField DataField="empSalary" HeaderText="empSalary" SortExpression="empSalary" />
                <asp:BoundField DataField="DeptId" HeaderText="DeptId" SortExpression="DeptId" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:FaiTrainingConnectionString1 %>" DeleteCommand="DELETE FROM [Emptable] WHERE [empId] = @original_empId AND [empName] = @original_empName AND [empAddress] = @original_empAddress AND [empSalary] = @original_empSalary AND (([DeptId] = @original_DeptId) OR ([DeptId] IS NULL AND @original_DeptId IS NULL))" InsertCommand="INSERT INTO [Emptable] ([empName], [empAddress], [empSalary], [DeptId]) VALUES (@empName, @empAddress, @empSalary, @DeptId)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Emptable] WHERE ([empId] = @empId)" UpdateCommand="UPDATE [Emptable] SET [empName] = @empName, [empAddress] = @empAddress, [empSalary] = @empSalary, [DeptId] = @DeptId WHERE [empId] = @original_empId AND [empName] = @original_empName AND [empAddress] = @original_empAddress AND [empSalary] = @original_empSalary AND (([DeptId] = @original_DeptId) OR ([DeptId] IS NULL AND @original_DeptId IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_empId" Type="Int32" />
                <asp:Parameter Name="original_empName" Type="String" />
                <asp:Parameter Name="original_empAddress" Type="String" />
                <asp:Parameter Name="original_empSalary" Type="Decimal" />
                <asp:Parameter Name="original_DeptId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="empName" Type="String" />
                <asp:Parameter Name="empAddress" Type="String" />
                <asp:Parameter Name="empSalary" Type="Decimal" />
                <asp:Parameter Name="DeptId" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" DefaultValue="1000" Name="empId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="empName" Type="String" />
                <asp:Parameter Name="empAddress" Type="String" />
                <asp:Parameter Name="empSalary" Type="Decimal" />
                <asp:Parameter Name="DeptId" Type="Int32" />
                <asp:Parameter Name="original_empId" Type="Int32" />
                <asp:Parameter Name="original_empName" Type="String" />
                <asp:Parameter Name="original_empAddress" Type="String" />
                <asp:Parameter Name="original_empSalary" Type="Decimal" />
                <asp:Parameter Name="original_DeptId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
