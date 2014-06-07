<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.master" AutoEventWireup="true" CodeFile="Pl_Login.aspx.cs" Inherits="Pl_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="Image2" runat="server" Height="118px" ImageAlign="Left" 
        ImageUrl="~/images/imgres.jpg" Width="109px" />
&nbsp; PLEASE LOGIN TO VIEW THIS PAGE.<br />
&nbsp;
    <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Login.aspx">Click here to login !</asp:HyperLink>
&nbsp;
</asp:Content>

