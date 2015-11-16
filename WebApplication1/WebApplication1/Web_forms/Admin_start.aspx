<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_start.aspx.cs" Inherits="WebApplication1.Web_forms.Admin_start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link rel="stylesheet" type="text/css" href="~/Css/Admin_start.css"/>
    <link rel="stylesheet" type="text/css" href="~/Css/Calendar.css"/>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.0/jquery.min.js" type="text/javascript"></script> 
	<script > 
	$(document).ready(function(){
		document.getElementById("calendar").innerHTML='<object id="calendar" type="text/html" data="Calendar.aspx#jan"></object>';
    });
    </script> 

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <div class="outer">
			<div class="header">
				<p id="welcome">Welcome <%:Session["userName"]%></p>
				<a href="http://www.w3schools.com" class="headerRight">Log out</a>
				<a href="http://www.w3schools.com" class="headerRight" >Forum</a>
				<a href="http://www.w3schools.com" class="headerRight" >Mesaje</a>
			</div>
	
			<div class="inner">
				<div id = "utilizatori">  <strong> Utilizatori: </strong> <br/><br/>
					<select multiple class = "users"></select>
				</div>
				<div class = "outerData"> 
					<p id="gestiune"> <strong> Gestiune utilizatori </strong> </p>
					<p> ID Utilizator: <input type="text" name="idUtilizator"/></p>
        			<p> Nume: <input type="text" name="nume"/></p>
        			<p> Prenume: <input type="text" name="prenume"/></p>
        			<p> E-mail: <input type="text" name="e-mail"/></p>
        			<p> Telefon: <input type="text" name="telefon"/></p>
        			<p> Rol: <input type="text" name="rol"/></p>
        			<p> Username: <input type="text" name="userName"/></p>
        			<p> Parola: <input type="text" name="parola"/></p>
				</div>

				<div class="butoane">
					<br/>
					<br/>
					<br/>
					<br/>
					<br/>
					<br/>
					<button class="button" onclick="">Adauga utilizator</button><br/>
					<button class="button" onclick="">Sterge utilizator</button><br/>
					<button class="button" onclick="">Modifica utilizator</button><br/>
				</div>

			</div>
			
		</div>
    <div id="calendar"></div>
</body>
</html>
