<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta name="keywords" content="" />
<meta name="description" content="" />
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Communication  by Free CSS Templates</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" action="#" method="post" runat="server">
<div id="wrapper">
	<div id="header">
		<div id="logo">
			<h1><a href="#">Communication</a></h1>
			<p> Template design by <a href="http://www.freecsstemplates.org/">Free CSS Templates</a></p>
		</div>
	</div>
	<!-- end #header -->
	<div id="menu">
		<ul>
			<li class="current_page_item"><a href="#">Home</a></li>
			<li><a href="#">Blog</a></li>
			<li><a href="#">Photos</a></li>
			<li><a href="#">About</a></li>
			<li><a href="#">Links</a></li>
			<li><a href="#">Contact</a></li>
		</ul>
	</div>
	<!-- end #menu -->
	<div id="page">
	<div id="page-bgtop">
	<div id="page-bgbtm">
		<div id="content">
			<div class="post">
			<div class="post-bgtop">
			<div class="post-bgbtm">
				<h2 class="title"><a href="#">Sign Up for Free Account</a></h2>
				
				<div class="entry"  runat="server">
					
                        <input type="text" id="txtName" placeholder="Enter Full Name"  runat="server"/>
                        <br />
                        <input type="email" id="txtEmail" placeholder="Email ID"  runat="server"/>
                        <br />
                        <input type="radio" id="radioMale" name="gender" value="Male"  runat="server"/>Male
                        <input type="radio" id="radioFemale" name="gender" value="Female"  runat="server"/>Female
                        <br />
                        <input type="text" id="txtSignUsername" placeholder="Username"  runat="server"/>
                        <br />
                        <input type="password" id="txtSignPassword" placeholder="Password" runat="server"/>
                        <br />
                        <input type="submit" value="Register" id="btnSignUp" runat="server" onserverclick="btnSignUpClick"/>
				
				</div>
			</div>
			</div>
			</div>
			<div class="post">
			<div class="post-bgtop">
			<div class="post-bgbtm">
				<h2 class="title"><a href="#">Lorem ipsum sed aliquam</a></h2>
				<p class="meta">Posted by <a href="#">Someone</a> on March 8, 2008
					&nbsp;&bull;&nbsp; <a href="#" class="comments">Comments (64)</a> &nbsp;&bull;&nbsp; <a href="#" class="permalink">Full article</a></p>
				<div class="entry">
					<p>Sed lacus. Donec lectus. Nullam pretium nibh ut turpis. Nam bibendum. In nulla tortor, elementum vel, tempor at, varius non, purus. Mauris vitae nisl nec metus placerat consectetuer. Donec ipsum. Proin imperdiet est. Phasellus <a href="#">dapibus semper urna</a>. Pellentesque ornare, orci in consectetuer hendrerit, urna elit eleifend nunc, ut consectetuer nisl felis ac diam. Etiam non felis. Donec ut ante. In id eros. Suspendisse lacus turpis, cursus egestas at sem. Phasellus pellentesque. Mauris quam enim, molestie in, rhoncus ut, lobortis a, est.</p>
					<p>Praesent ac lectus. Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Vivamus augue. Fusce eget tellus ultrices ligula volutpat adipiscing. Aenean ligula lectus, vehicula in, dictum a, fermentum nec, felis. Nunc ac turpis in leo posuere imperdiet.</p>
				</div>
			</div>
			</div>
			</div>
			<div class="post">
			<div class="post-bgtop">
			<div class="post-bgbtm">
				<h2 class="title"><a href="#">Phasellus pellentesque turpis </a></h2>
				<p class="meta">Posted by <a href="#">Someone</a> on March 8, 2008
					&nbsp;&bull;&nbsp; <a href="#" class="comments">Comments (64)</a> &nbsp;&bull;&nbsp; <a href="#" class="permalink">Full article</a></p>
				<div class="entry">
					<p>Sed lacus. Donec lectus. Nullam pretium nibh ut turpis. Nam bibendum. In nulla tortor, elementum vel, tempor at, varius non, purus. Mauris vitae nisl nec metus placerat consectetuer. Donec ipsum. Proin imperdiet est. Pellentesque ornare, orci in consectetuer hendrerit, urna elit eleifend nunc, ut consectetuer nisl felis ac diam. Etiam non felis. Donec ut ante. In id eros. Suspendisse lacus turpis, cursus egestas at sem. Phasellus pellentesque. Mauris quam enim molestie  rhoncus lobortis a, est.</p>
				</div>
			</div>
			</div>
			</div>
		<div style="clear: both;">&nbsp;</div>
		</div>
		<!-- end #content -->
		<div id="sidebar">
			<ul>
				<li>
					<h2>Please Login</h2>
                    <div style="border:0px solid;margin:10px;">
                    
                        <input type="text" id="txtUsername" placeholder="Username" runat="server"/>
                        <br /><br />
                        <input type="password" id="txtPassword" placeholder="Password" runat="server"/>
                        <br /><br />
                        <input type="submit" id="btnLogin" value="Login" runat="server" onserverclick="btnLogin_Click"/>
                    </div>
				</li>
				<li>
					<h2>Categories</h2>
					<ul>
						<li><a href="#">Uncategorized</a> (3)<span>Lorem Ipsum Dolor Sit Amit</span></li>
						<li><a href="#">Lorem Ipsum</a> (42)<span>Lorem Ipsum Dolor Sit Amit</span></li>
						<li><a href="#">Urna Congue Rutrum</a> (28)<span>Lorem Ipsum Dolor Sit Amit</span> </li>
						<li><a href="#">Vivamus Fermentum</a> (13)<span>Lorem Ipsum Dolor Sit Amit</span> </li>
					</ul>
				</li>
				<li>
					<h2>Blogroll</h2>
					<ul>
						<li><a href="#">Phasellus Pellentesque</a><span>Lorem Ipsum Dolor Sit Amit</span> </li>
						<li><a href="#">Consectetuer Adipiscing</a><span>Lorem Ipsum Dolor Sit Amit</span> </li>
						<li><a href="#">Urna Congue Rutrum</a><span>Lorem Ipsum Dolor Sit Amit</span> </li>
					</ul>
				</li>
				<li>
					<h2>Archives</h2>
					<ul>
						<li><a href="#">December 2009</a>&nbsp;(29)<span>Lorem Ipsum Dolor Sit Amit</span></li>
						<li><a href="#">November 2009</a>&nbsp;(30)<span>Lorem Ipsum Dolor Sit Amit</span></li>
						<li><a href="#">October 2009</a>&nbsp;(31)<span>Lorem Ipsum Dolor Sit Amit</span></li>
					</ul>
				</li>
			</ul>
		</div>
		<!-- end #sidebar -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	</div>
	</div>
	<!-- end #page -->
</div>
	<div id="footer">
		<p>Copyright (c) 2008 Sitename.com. All rights reserved. Design by <a href="http://www.freecsstemplates.org/">Free CSS Templates</a>.</p>
	</div>
	<!-- end #footer -->
        </form>
</body>
    
</html>
