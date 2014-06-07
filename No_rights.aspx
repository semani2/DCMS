<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.master" AutoEventWireup="true" CodeFile="No_rights.aspx.cs" Inherits="No_rights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-weight: 700">
        <asp:Image ID="Image2" runat="server" Height="124px" ImageAlign="Left" 
            ImageUrl="~/images/error.jpg" Width="113px" />
&nbsp;</p>
    <p style="font-weight: 700">
        &nbsp;Sorry ! No access Right.</p>
    <p style="font-weight: 700">
        Login as appropriate personnel.</p>
    <p style="font-weight: 700">
        Please proceed to 
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Login.aspx">LOGIN !</asp:HyperLink>
    </p>
</asp:Content>

