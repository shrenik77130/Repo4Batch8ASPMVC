<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Panel/admin_master.master" AutoEventWireup="true" CodeFile="FlightDetails.aspx.cs" Inherits="Admin_Panel_FlightDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin:100px;padding:10px; border:1px solid;">
        ID :<input type="text" name="name" value=" " />
        <br />
        <br />

        Select Flight Type :
        <select class="form-control" style="width:200px;">
             <% 
                 FlightType f = new FlightType();
                 ArrayList records = f.showFlightType();

                 for (int i = 0; i < records.Count; i++)
                 {
                     FlightType x = (FlightType)records[i];
                     %>
                         <option value="<%= x.flighttypeid %>"><%= x.flighttype %></option>
                    <%
                 }
             %>
        </select>
    </div>
</asp:Content>

