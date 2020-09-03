<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<!--
Design by Free CSS Templates
http://www.freecsstemplates.org
Released for free under a Creative Commons Attribution 2.5 License

Name       : Adhesive
Description: A three-column, fixed-width blog design.
Version    : 1.0
Released   : 20100406

-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Adhesive by Free CSS Templates</title>
<meta name="keywords" content="" />
<meta name="Adhesive" content="" />
<link href="default.css" rel="stylesheet" type="text/css" media="screen" />

    <style>
        .pstyle {
            border:1px solid;
            width:300px;
            height:400px;
            margin:15px;
            padding:10px;
            text-align:center;
        }

        .pimage {
            width:150px;
            height:200px;
            margin:10px;
        }
    </style>


</head>
<body>
<div id="wrapper">
	<!-- start header -->
	<div id="header">
		<div id="logo">
			<h1><a href="#"><span>Adhesive</span></a>/</h1>
			<p>Designed By Free CSS Templates</p>
		</div>
		<div id="menu">
			<ul id="main">
				<li class="current_page_item"><a href="#">Homepage</a></li>
				<li><a href="#">Services</a></li>
				<li><a href="#">About Us</a></li>
				<li><a href="#">Contact Us</a></li>
			</ul>
		</div>
	</div>
	<!-- end header -->
	<!-- start page -->
	<div id="page">
		<div id="page-bgtop">
			<div id="page-bgbtm">
				<div id="sidebar1" class="sidebar">
					<ul>
						<li>
							<h2>Recent Posts</h2>
							<ul>
								<li><a href="#">Aliquam libero</a></li>
								<li><a href="#">Consectetuer adipiscing elit</a></li>
								<li><a href="#">Metus aliquam pellentesque</a></li>
								<li><a href="#">Suspendisse iaculis mauris</a></li>
								<li><a href="#">Proin gravida orci porttitor</a></li>
								<li><a href="#">Aliquam libero</a></li>
								<li><a href="#">Consectetuer adipiscing elit</a></li>
								<li><a href="#">Metus aliquam pellentesque</a></li>
								<li><a href="#">Suspendisse iaculis mauris</a></li>
								<li><a href="#">Proin gravida orci porttitor</a></li>
							</ul>
						</li>
						<li>
							<h2>Archives</h2>
							<ul>
								<li><a href="#">September</a> (23)</li>
								<li><a href="#">August</a> (31)</li>
								<li><a href="#">July</a> (31)</li>
								<li><a href="#">June</a> (30)</li>
								<li><a href="#">May</a> (31)</li>
							</ul>
						</li>
					</ul>
				</div>
				<!-- start content -->
				<div id="content">
                            <%
                                ProductData p1 = new ProductData();
                                ArrayList R = p1.generateProducts();

                                for (int i = 0; i < R.Count; i++)
                                {
                                    ProductData x = (ProductData)R[i];
                                    %>
                    <div class="pstyle">
                        <img src="<%=x.imgpath%>" class="pimage" alt="Alternate Text" />
                        <br />
                        <h4><%=x.prodid %></h4>
                        <h3><%=x.prodname %></h3>
                        <h3><%=x.price %></h3>
                        <input type="submit" name="name" value="Purchase" class="more"/>
                    </div>
                                    <%
                                }
                            %>
				</div>
				<!-- end content -->
				<!-- start sidebars -->
				<div id="sidebar2" class="sidebar">
					<ul>
						<li>
							<form id="searchform" method="get" action="#">
								<div>
									<h2>Site Search</h2>
									<input type="text" name="s" id="s" size="15" value="" />
								</div>
							</form>
						</li>
						<li>
							<h2>Categories</h2>
							<ul>
								<li><a href="#">Aliquam libero</a></li>
								<li><a href="#">Consectetuer adipiscing elit</a></li>
								<li><a href="#">Metus aliquam pellentesque</a></li>
								<li><a href="#">Suspendisse iaculis mauris</a></li>
								<li><a href="#">Urnanet non molestie semper</a></li>
								<li><a href="#">Proin gravida orci porttitor</a></li>
								<li><a href="#">Aliquam libero</a></li>
								<li><a href="#">Consectetuer adipiscing elit</a></li>
								<li><a href="#">Metus aliquam pellentesque</a></li>
								<li><a href="#">Urnanet non molestie semper</a></li>
								<li><a href="#">Proin gravida orci porttitor</a></li>
								<li><a href="#">Aliquam libero</a></li>
								<li><a href="#">Consectetuer adipiscing elit</a></li>
								<li><a href="#">Metus aliquam pellentesque</a></li>
							</ul>
						</li>
					</ul>
				</div>
				<!-- end sidebars -->
				<div style="clear: both;">&nbsp;</div>
			</div>
			<!-- end page -->
		</div>
	</div>
</div>
<div id="footer-wrapper">
	<div id="footer">
		<p class="copyright">&copy;&nbsp;&nbsp;2009 All Rights Reserved &nbsp;&bull;&nbsp; Design by <a href="http://www.freecsstemplates.org/">Free CSS Templates</a>.</p>
	</div>
</div>
</body>
</html>
