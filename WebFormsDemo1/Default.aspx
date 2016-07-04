<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Coding Tasks</h1>

       <h2 style="height: 27px"> My very first ASP.NET Web Forms page </h2>
        
           <asp:Label ID="Label1" runat="server" Text="Please type in your name: "></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Click me!" OnClick="Button1_Click" />       
    <br /><br />
         <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Please check or uncheck the box:"></asp:Label>
    <br /><br />
        <asp:CheckBox ID="Check1" runat="server" />
    <br /><br />
        <asp:Button ID="Button2" runat="server" Text="Check Box Button" OnClick="Button2_Click" />
    <br /><br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <br /><br />
        <asp:Label ID="Label5" runat="server" Text="Please click the radio button:"></asp:Label>
    <br /><br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>One</asp:ListItem>
            <asp:ListItem>Two</asp:ListItem>
            <asp:ListItem>Three</asp:ListItem>
        </asp:RadioButtonList>
    <br /><br />
        <asp:Button ID="Button3" runat="server" Text="RadioButton Button" OnClick="Button3_Click" />
    <br /><br />
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    <br /><br />


        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
    <br /><br />
        <asp:Label ID="ResponsiveRadioLabel" runat="server" Text="Label"></asp:Label>
    <br /><br />


        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="http://www.netflix.com">LinkButton</asp:LinkButton>
    <br /><br />

    
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/himura.jpg" Width="100" Visible="True" Height="100" PostBackUrl="http://www.bbc.co.uk" />
    <br /><br />


        <asp:TextBox ID="charCheckTextBox" runat="server" Height="50px" Rows="5" Width="300px"></asp:TextBox>
    <br /> <br />
        <asp:Button ID="checkChar" runat="server" Text="Submit" OnClick="checkChar_Click" />
    <br /> <br />
        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
    <br /> <br />
        <asp:Label ID="Label8" runat="server" Text="Please enter your email address:"></asp:Label>
    <br /> <br />
        <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" CausesValidation="True" TextMode="Email"></asp:TextBox><asp:Button ID="Button4" runat="server" Text="Button" />
         <br /> <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
          <br /> <br />
        <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
          <br /> <br />
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>















        <h1>Project Component Ideas</h1>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>ROT13</asp:ListItem>
            <asp:ListItem>ROT5</asp:ListItem>
        </asp:DropDownList>
    <br /><br />
        <asp:Button ID="DropDownbutton" runat="server" Text="Button" OnClick="DropDownbutton_Click" />
    <br /><br />
        <asp:Label ID="DropDownListLabel" runat="server" Text=""></asp:Label>
    <br /><br />
        <textarea id="TextArea1" cols="20" rows="2"></textarea>
    <br /><br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="100px" Width="250px"></asp:TextBox>
    </div>
    
           
     
        
    </form>
</body>
</html>
