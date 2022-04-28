<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CodeFirstEFDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" ReadOnly="true" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender"></asp:BoundField>
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary"></asp:BoundField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" Width="125px">
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetEmployee" TypeName="CodeFirstEFDemo.EmployeeRepo" DataObjectTypeName="CodeFirstEFDemo.Employee" DeleteMethod="DeleteEmployee" InsertMethod="InsertEmployee" UpdateMethod="UpdateEmployee"></asp:ObjectDataSource>
    </form>
</body>
</html>
