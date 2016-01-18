<%@ Page Title="Converter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Converter.aspx.cs" Inherits="WebFormsSummator.Converter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2><%: this.Title %>: Text to image converter</h2>
        <h3>Enter text in the box or add &quot;?text=...&quot; to the URL to change the image.</h3>
        <p>Or type http://localhost:XXXXX/{anything}.img in the address bar</p>
        <p>... or use Postman to send a post request to http://localhost:XXXXX/{anything}.img with body x-www-form-urlencoded, key: "text", value: whatever</p>
        <br />
        <asp:TextBox runat="server" ID="MyTextBox"></asp:TextBox>
        <asp:Button runat="server" OnClick="RenderImageButtonClicked" Text="Change text/image"/>
        <asp:Image runat="server" ID="MyTextImage" />
    </div>
</asp:Content>
