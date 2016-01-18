<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSummator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Summator</h1>
        <p class="lead">Sum two numbers</p>
            <input id="FirstNumber" placeholder="First number" runat="server" style="padding: 3px; margin: 5px; border: thin solid #0000FF; font-family: Arial, Helvetica, sans-serif; text-align: right;" type="number" value="0" />
            <input id="SecondNumber" placeholder="Second number" runat="server" style="padding: 3px; margin: 5px; border: thin solid #0000FF; font-family: Arial, Helvetica, sans-serif; text-align: right;" type="number" value="0" />
        
        <br />
        <asp:Button ID="SumButton" runat="server" Text="Sum" OnClick="Sum" Width="122px" />
        <br />
        <asp:Label ID="OutputLabel" runat="server" Text="Sum" Visible="false"></asp:Label>
        <br />
    </div>
</asp:Content>
