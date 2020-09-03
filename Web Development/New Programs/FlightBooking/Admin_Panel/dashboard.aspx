<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/admin_master.master" AutoEventWireup="true" CodeFile="dashboard.aspx.cs" Inherits="Admin_Panel_dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>Dashboard</h1>
    <hr />

    <center>
    <div style="width:300px;margin-bottom:10px;border:1px solid;padding:10px;">
    <form action="#" method="post" runat="server">
        <input type="text" name="name" value="" id="txtFlightID" placeholder="Flight ID" runat="server"/>
        <br />
        <br />
        <input type="text" name="name" value="" id="txtFlightType" placeholder="Flight Type" runat="server" />
        <br />
        <br />
        <input type="submit" name="name" value="Save" id="btnSave" runat="server" onserverclick="btnSave_ServerClick"/>
    </form>
        </div>
        </center>

    <table class="table table table-hover">
        <tr>
            <th>FlightType ID</th>
            <th>Flight Type</th>
            <th>#</th>
           <th>#</th>
        </tr>
        <%
            FlightType obj = new FlightType();
            ArrayList records = obj.showFlightType();

            for (int i = 0; i < records.Count; i++)
            {
                FlightType x = (FlightType)records[i];
        %>
        <tr>
            <td><%= x.flighttypeid %></td>
            <td><%= x.flighttype %></td>
            <td><a href="?delid=<%=x.flighttypeid %>">delete</a></td>
            <td><a href="?upid=<%=x.flighttypeid %>">Update</a></td>
        </tr>
        <% 
          }
        %>
    </table>









</asp:Content>

