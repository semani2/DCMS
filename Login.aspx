<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style16
    {
        width: 51%;
        height: 231px;
    }
    .style18
    {
        width: 400px;
    }
    .style19
    {
        width: 135px;
    }
    .style20
    {
        width: 135px;
        height: 177px;
    }
    .style21
    {
        width: 400px;
        height: 177px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="left">
        &nbsp;Please Select Ur login here :</p>
<table class="style16">
    <tr>
        <td class="style20">
            <asp:ImageButton ID="stu_img" runat="server" Height="145px" 
                ImageUrl="~/images/stu_log.gif" onclick="ImageButton1_Click" Width="147px" />
            <br />
            <strong>STUDENT LOGIN</strong></td>
        <td class="style21">
            <asp:ImageButton ID="ImageButton2" runat="server" Height="140px" 
                ImageUrl="~/images/faculty_icon.jpg" onclick="ImageButton2_Click" 
                Width="142px" />
        </td>
    </tr>
    <tr>
        <td class="style19">
            <asp:ImageButton ID="ImageButton3" runat="server" Height="141px" 
                ImageUrl="~/images/login_icon.png" onclick="ImageButton3_Click" Width="143px" />
            <br />
            <strong>COLLEGE MNG LOGIN</strong></td>
        <td class="style18">
            <asp:ImageButton ID="ImageButton4" runat="server" Height="143px" 
                ImageUrl="~/images/login-icon.jpg" onclick="ImageButton4_Click" Width="146px" />
            <br />
            <strong>ADMIN LOGIN</strong></td>
    </tr>
</table>
<p>
    &nbsp;</p>
</asp:Content>

