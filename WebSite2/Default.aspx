<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link href="https://fonts.googleapis.com/css?family=Cinzel+Decorative|Oswald" rel="stylesheet">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="StyleSheet.css" type="text/css" rel="stylesheet"/>
</head>
<body class="bodyBack">
    <form id="form1" runat="server">
         <div class="row">
             <div class="jumbotron banner">
                     <h1>ROT13 cypher!</h1>
            </div>
            </div> <!-- closing tag for row-->
    <div class="container">
           


            <div class="row">
                    <div class="col-sm-6">
                            <asp:Label ID="EncryptInfo" runat="server" Text="Please enter the text you would like to encrypt: "></asp:Label>
                    </div> <!-- closing tag for column-->                         
            </div> <!--closing tag for row-->


            <div class="row">
                    <div class="col-sm-6">
                             <asp:TextBox ID="EncryptText" runat="server" Rows="10" Height="150px" Width="100%"></asp:TextBox> 
                    </div><!--closing tag for column -->
                    <div class="col-sm-6 textBoxInfo">
                             <asp:Label ID="Label1" runat="server" Text="the Caesar cypher is one of the earliest cyphers to exist. This cypher takes a plain text message and shifts the letters to make its coded message.The letter 'A', for example, canbe put in the plain text message, and the cypher shifts its position 13 places which results in the letter'N' in the coded message. For it's time, it was a revolutionary breakthrough in communication. It is, however, easily breakable."></asp:Label>
                    </div> <!-- closing tag for column-->                
            </div> <!--closing tag for row-->


            <div class="row">          
                <div class="col-sm-offset-2">
                             <asp:Button CssClass="btn" ID="ButtonEncrypt" runat="server" Text="Encrypt/Decrypt" OnClick="ButtonEncrypt_Click" />
                </div> <!-- closing tag for column-->
            </div> <!-- closing tag for row-->


            <div class="row">
                <div class="col-sm-6">
                        <asp:Label  ID="DecryptInfo" runat="server" Text="Please enter the text you would like to decrypt: "></asp:Label> 
                    </div> <!-- closing tag for column-->
            </div><!--closing tag for row-->
          

            <div class="row">  
                     <div class="col-sm-6">
                            <asp:TextBox ID="DecryptText" runat="server" Height="150px" Width="100%"></asp:TextBox>   
                     </div><!--closing tag for column-->
                    <div class="col-sm-6 textBoxInfo">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </div><!--closing tag for column-->
            </div><!--closing tag for row-->                            
    </div>  <!-- closing tag for container -->   
    </form>
</body>
</html>
