<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
	<h2>Table Example 3 With CSS Styles</h2>
	<hr>

	<table>
		<tr>
			<th>Name</th>
			<th>Education</th>
			<th>City</th>
		</tr>

		<tr>
			<td>Omkar</td>
			<td>BCS</td>
			<td>Sangli</td>
		</tr>

		<tr>
			<td>Yogesh</td>
			<td>B.Com</td>
			<td>Kolhapur</td>
		</tr>
	</table>


	<style type="text/css">
		table
		{
			border:1px solid red;
		}

		td,th
		{
			font-family:"calibri";
			border:1px solid;
			padding:10px;
		}

		td:hover
		{
			background-color:yellow;
		}
	</style>
</body>
</html>
