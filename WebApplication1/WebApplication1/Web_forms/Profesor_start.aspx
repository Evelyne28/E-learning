<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor_start.aspx.cs" Inherits="WebApplication1.Web_forms.Profesor_start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profesor</title>
    <link rel="stylesheet" type="text/css" href="~/Css/Profesor_start.css"/>
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
				<p id="welcome"> Welcome <%:Session["userName"]%> </p>
				<a href="http://www.w3schools.com" class="headerRight">Log out</a>
				<a href="http://www.w3schools.com" class="headerRight" >Forum</a>
				<a href="http://www.w3schools.com" class="headerRight" >Mesaje</a>
			</div>
	
			<div class="inner">
				<div id = "cursuri">  Cursuri  </div>
				<div class="img">
				        <a target="_blank" href="Profesor_pagina_curs.aspx">
				            <img src="../Images/book.jpg">
				        </a>
				    <div class="desc">Curs 1</div>
				</div>

				<div class="img">
				    <a target="_blank" href="https://www.google.com">
				        <img src="../Images/book.jpg">
				    </a>
					<div class="desc">Curs 2</div>
				</div>

				<div class="img">
				    <a target="_blank" href="https://www.google.com">
				        <img src="../Images/book.jpg">
				    </a>
				    <div class="desc">Curs 3</div>
				</div>

                <div class="img">
				    <a target="_blank" href="https://www.google.com">
				        <img src="../Images/book.jpg">
				    </a>
				    <div class="desc">Curs 4</div>
				</div>

			</div>
			
		</div>
    <div id="calendar"></div>
</body>
</html>
