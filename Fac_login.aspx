<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.master" AutoEventWireup="true" CodeFile="Fac_login.aspx.cs" Inherits="Fac_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Faculty login page</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
        &nbsp;<asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
    <p>
        &nbsp;<asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
</p>
<p>
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False" 
            BackColor="#CC0000"></asp:Label>
</p>
    <p style="margin-left: 120px">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Reset" />
</p>
<p style="margin-left: 120px">
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/fac_reg.aspx">New User ? Sign up here</asp:HyperLink>
</p>
<p style="margin-left: 120px">
        <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/ForgotPass.aspx">Forgot Password ? Click Here</asp:HyperLink>
</p>
    <p style="margin-left: 160px">
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>

