<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ASP.NET_WA_Day_1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="empid" HeaderText="empid" SortExpression="empid" />
                <asp:BoundField DataField="empname" HeaderText="empname" SortExpression="empname" />
                <asp:BoundField DataField="empsalary" HeaderText="empsalary" SortExpression="empsalary" />
                <asp:BoundField DataField="emporder" HeaderText="emporder" SortExpression="emporder" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EYDatabaseConnectionString8 %>" SelectCommand="SELECT * FROM [employee]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        lists--<br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        </asp:RadioButtonList>
        <asp:BulletedList ID="BulletedList1" runat="server" >
        </asp:BulletedList>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        insert,update and delete-<br />
        <br />
        <asp:Button ID="txtinsert" runat="server" OnClick="txtinsert_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtdelete" runat="server" Text="delete" OnClick="txtdelete_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtupdate" runat="server" Text="update" OnClick="txtupdate_Click" />
        <br />
        <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                inserting a record:<br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="enter empid:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="enter empname:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="enter emp salary:"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button7" runat="server" Text="insert" OnClick="Button7_Click" />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
            <br />
        <asp:Panel ID="Panel2" runat="server" Visible="False">
            deleting a record:<br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="enter empid:"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="delete" />
            <br />
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" Height="89px" Visible="False">
            updating a record:<br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="update empname"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="update id"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="update" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
