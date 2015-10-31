<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Web_forms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in</title>
    <link rel="stylesheet" href="~/Css/login.css"/>

</head>
<body>
    <section class="container">
    <div class="inner">
      <h1>Log In</h1>
      <form class="login" runat="server">
        <div><input type="text" id="userName" name="userName" placeholder="Username" required></div>
          <br />
        <div><input type="password" id="userPassword" name="userPassword" placeholder="Password" required></div>
          <br />
        <div><asp:Button id="Submit" Text="Log in" runat="server" onclick="btn_login_Click"></asp:Button></div>
      </form>
        <p id="signin"> Don't have an account? <a href="signin.html" class="button" >Sign In</a></p>
    </div>
  </section>
</body>
</html>
