<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MyPizzaShop.Home" %>


<asp:Content ID="Content2" ContentPlaceHolderID="HeaderSection" runat="server">
    <div id="header" class="header-wrapper" style="background-image: url(./images/banner2.jpg);">
        <div class="center">
            <div class="header-inside">
                <div class="logo">
                    <a href="#" title="My Pizza Shop">
                        <img id="logoImage" src="./images/logo.png" width="150" /><img id="logoImageRetina" src="upload/logo-retina.jpg" /></a>
                    <div class="clear"></div>
                </div>
                <div class="main-menu">
                    <div class="menu-main-nav-menu-container">
                        <ul id="menu-main-nav-menu" class="sf-menu">
                            <li class="menu-item"><a href="#menu">Home</a></li>
                            <li class="menu-item"><a href="#about">About</a></li>

                            <% HttpCookie user = Request.Cookies["user"]; %>

                            <li class="menu-item current-menu-item">
                                <a href="<%=(user != null)? "Login.aspx?logout=true": "Login.aspx" %>">
                                    <%= (user != null)? "Logout": "Login" %>
                                </a>
                            </li>
                            <li class="menu-item current-menu-item"><a href="tel:0113888888"><i class="fa fa-phone-square fa-lg" aria-hidden="true"></i>&nbsp 0113 888 888</a></li>
                        </ul>
                    </div>
                </div>
                <div class="search-icon">
                    <div class="icons icon-search"></div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>


<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <!-- Pizza List -->
    <div id="menu" class="vc_row wpb_row vc_row-fluid">
        <div class="wpb_column vc_column_container vc_col-sm-12">
            <div class="vc_column-inner ">
                <div class="wpb_wrapper">
                    <div class="wpb_text_column wpb_content_element ">
                        <div class="wpb_wrapper">
                            <h2 style="text-align: center;">we use fresh ingredients.<br />
                                why is that?</h2>

                        </div>
                    </div>

                    <div class="wpb_text_column wpb_content_element ">
                        <div class="wpb_wrapper">
                            <p style="text-align: center;">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                        <br />
                                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="container-wrapper">
        <div class="clear"></div>
        <div id="container">
            <!-- start container -->
            <div class="center">
                <div class="page-wrapper">
                    <div class="main">

                        <div id="post-8" class="post-8 page type-page status-publish">
                            <div class="vc_row wpb_row vc_row-fluid">
                                <div class="wpb_column vc_column_container vc_col-sm-12">
                                    <div class="vc_column-inner ">
                                        <div class="wpb_wrapper">
                                            <div class="wpb_content_element vc_portfolio_items">
                                                <div class="portfolio-items-wrapper">

                                                    <!-- Element Starting -->
                                                    <asp:PlaceHolder ID="Pizzas" runat="server"></asp:PlaceHolder>
                                                    <!-- Ending -->
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
    </div>

    <!-- About -->
    <div id="about" class="vc_row wpb_row vc_row-fluid">
        <div class="wpb_column vc_column_container vc_col-sm-12">
            <div class="vc_column-inner ">
                <div class="wpb_wrapper">
                    <div class="wpb_text_column wpb_content_element ">
                        <div class="wpb_wrapper">
                            <h2 style="text-align: center;">About</h2>
                        </div>
                    </div>

                    <div class="wpb_text_column wpb_about_element ">
                        <div class="wpb_wrapper">
                            <p style="text-align: center;">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                        <br />
                                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                            </p>
                        </div>
                        <div class="wpb_wrapper">
                            <p style="text-align: center;">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
                                        <br />
                                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
