<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyPizzaShop.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div id="SinginArea" class="d-flex align-items-center justify-content-center text-center myFont">
        <form class="form-signin" method="post" id="loginForm" runat="server">
            <img src="./images/logo.png" alt="Logo" width="200" />
            <h1 class="main-text-2 fw-500 mb-30">Sign In</h1>
            <div class="mb-10">
                <label for="username" class="sr-only">Username</label>
                <asp:TextBox ID="Username" runat="server" class="form-control" placeholder="Username"></asp:TextBox>

            </div>
            <div class="mb-10">
                <label for="password" class="sr-only">Password</label>
                <asp:TextBox ID="Password" TextMode="Password" runat="server" class="form-control" placeholder="Password"></asp:TextBox>
            </div>
            <div class="checkbox ">
                <label>
                    <input type="checkbox" value="remember-me">
                    Remember me
                </label>
            </div>
            <div class="message ">
                <asp:Label ID="Error" Class="error" runat="server" Text=""></asp:Label>
            </div>
            <asp:LinkButton ID="SignIn" class="btn btn-danger btn-lg-solid-primary fw-500 text-uppercase btn-block" runat="server" OnClick="SignIn_Click">Sign In</asp:LinkButton>
        </form>
    </div>
</asp:Content>
