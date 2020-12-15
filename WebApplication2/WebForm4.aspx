<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication2.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container-login">
            <div class="login-form">
                <h1 class="login-title">Chestionar</h1>           
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <asp:Button ID="Button1" class="btn" style="margin: auto;" runat="server" Text="Trimite" OnClick="Button1_Click" />
                <asp:Label class="label" style="display:block; margin-bottom:10px; color: white;" ID="Label4" runat="server" Text=""></asp:Label>
            </div>
        </div>
     </form>
</asp:Content>
