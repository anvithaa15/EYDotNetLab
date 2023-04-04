<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="linq5_db.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 443px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="studid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="studid" HeaderText="studid" ReadOnly="True" SortExpression="studid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                    <asp:BoundField DataField="mobile" HeaderText="mobile" SortExpression="mobile" />
                    <asp:BoundField DataField="course_id" HeaderText="course_id" SortExpression="course_id" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EYDatabaseConnectionString %>" SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="insert" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="delete" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="update" />
        </div>
    </form>
</body>
</html>
