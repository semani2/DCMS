<%@ Page Title="" Language="C#" MasterPageFile="~/Homepage.master" AutoEventWireup="true" CodeFile="Aboutus.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <p>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="69px" 
            ImageUrl="~/images/student.jpg" onclick="ImageButton1_Click" 
            Width="82px" />
    &nbsp;FOR STUDENT</p>
<p>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Height="125px" 
            Visible="False" Width="540px">This is for student details</asp:TextBox>
    </p>
<p>
        &nbsp;</p>
    <p>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="70px" 
            ImageUrl="~/images/faculty.jpg" onclick="ImageButton2_Click" 
            Width="83px" />
    &nbsp;FOR FACULTY</p>
<p>
        <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" Height="109px" 
            Visible="False" Width="540px">This is for faculty</asp:TextBox>
    </p>
<p>
        &nbsp;</p>
<p>
        <asp:ImageButton ID="ImageButton3" runat="server" Height="68px" 
            ImageUrl="~/images/colg_mng.png" onclick="ImageButton3_Click" 
            Width="81px" />
    &nbsp;FOR COLLEGE MANAGEMENT</p>
<p>
        <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None" Height="104px" 
            Visible="False" Width="544px">This is for college management</asp:TextBox>
    </p>
</asp:Content>


