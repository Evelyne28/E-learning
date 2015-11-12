<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor_pagina_curs.aspx.cs" Inherits="WebApplication1.Web_forms.Profesor_pagina_curs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pagina curs</title>
    <link rel="stylesheet" type="text/css" href="~/Css/Profesor_pagina_curs.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <div class="outer">
			<div class="header">
				<a href="http://www.w3schools.com" class="headerRight">Log out</a>
				<a href="http://www.w3schools.com" class="headerRight" >Forum</a>
				<a href="http://www.w3schools.com" class="headerRight" >Mesaje</a>
			</div>
	
			<div class="inner">
				<div id ="cursuri"> Cursuri:  </br></br>
					<a href="../Images/Curs 1.pdf" >Curs 1</a></br>
					<a href="http://www.w3schools.com" >Curs 2</a></br>
					<a href="http://www.w3schools.com" >Curs 3</a></br>
					<a href="http://www.w3schools.com" >Curs 4</a></br>
					<a href="http://www.w3schools.com" >Curs 5</a></br>
					<a href="http://www.w3schools.com" >Curs 6</a></br>
					<a href="http://www.w3schools.com" >Curs 7</a></br>
					<a href="http://www.w3schools.com" >Curs 8</a></br>
					<a href="http://www.w3schools.com" >Curs 9</a></br>
					<a href="http://www.w3schools.com" >Curs 10</a></br>
				</div>
			
				<div class="butoane">
					<button id="button" onclick=AdaugaCurs()>Adauga Curs</button></br>
					<button id="button" onclick=StergeCurs()>Sterge Curs</button></br>
					<button id="button" onclick=ModificaCurs()>Modifica Curs</button></br>
				</div>
				
				<div id ="teme"> Teme:  </br></br>
					<a href="http://www.w3schools.com" >Tema 1</a></br>
					<a href="http://www.w3schools.com" >Tema 2</a></br>
					<a href="http://www.w3schools.com" >Tema 3</a></br>
					<a href="http://www.w3schools.com" >Tema 4</a></br>
					<a href="http://www.w3schools.com" >Tema 5</a></br>
					<a href="http://www.w3schools.com" >Tema 6</a></br>
				</div>
				
				<div class="butoaneTeme">
					<button id="button" onclick=AdaugaTema()>Adauga Tema</button></br>
					<button id="button" onclick=StergeTema()>Sterge Tema</button></br>
					<button id="button" onclick=ModificaTema()>Modifica Tema</button></br>
				</div>
				<div class="studenti">
					<p>Studenti inscrisi:</p>
					<select multiple class = "stud"></select>
				
				</div>
				
			</div>
			<button id="catalog" onclick=AcceseazaCatalog()>Catalog Note</button></br>
		</div>

</body>
</html>
