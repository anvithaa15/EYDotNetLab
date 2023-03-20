<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_WA_Day_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="city" runat="server">
        <div>
            calculator<br />
            <br />
            <asp:Label ID="Label4" runat="server" BackColor="#FF99CC" BorderColor="#FF66FF" BorderStyle="Double" ForeColor="#003366" Text="enter first number:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label5" runat="server" BackColor="#FF99FF" BorderColor="#FF66FF" BorderStyle="Double" ForeColor="#000066" Text="enter second number:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#00CCFF" BorderColor="#3333CC" BorderStyle="Solid" Height="26px" OnClick="Button1_Click" Text="submit" />
        <br />
        <br />
        <br />
        <img alt="flower" src="https://cdn.pixabay.com/photo/2015/04/19/08/33/flower-729512__340.jpg" style="height: 281px; width: 373px" /><br />
        <br />
        <asp:Image ID="Image1" runat="server" AlternateText="images" DescriptionUrl="~/images/flowers.jpg" Height="296px" ImageUrl="~/images/flowers.jpg" Width="399px" />
        <br />
        <br />
        <br />
        Lists:<br />
        -- dropdown lists:<br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="selected city is:"></asp:Label>
        <br />
        //selected value is:<br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>bangalore</asp:ListItem>
            <asp:ListItem>mysore</asp:ListItem>
            <asp:ListItem>chennai</asp:ListItem>
            <asp:ListItem>hyderabad</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="submit" />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com/search?gs_ssp=eJzj4tDP1TewTDY0N2D04kxKzEtPzMkvSgUAPNgGQQ&amp;q=bangalore&amp;rlz=1C1CHBF_enIN1045IN1045&amp;oq=banga&amp;aqs=chrome.1.69i57j46i67i433j0i67j0i433i512j46i67i175i199i433j0i433i512j46i67i433j46i67i131i433j0i131i433j0i271.6027j0j7&amp;sourceid=chrome&amp;ie=UTF-8">Bangalore</asp:HyperLink>
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
