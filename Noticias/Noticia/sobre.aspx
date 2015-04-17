<%@ Page Title="Noticias" Language="C#" AutoEventWireup="true"
 CodeBehind="sobre.aspx.cs" Inherits="Noticia.sobre" MasterPageFile="~/master.master" %>

<asp:Content ID="sobreContent" ContentPlaceHolderID="ApplicationMain" runat="server">
	<!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('assets/img/about-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="page-heading">
                        <h1>Sobre</h1>
                        <hr class="small">
                        <span class="subheading">Quem somos? Haha!</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                <p>Somos uma equipe dedicada a entregar as noticias mais atuais, com base em um sistema de busca por vários sites do mundo, e também através do cadastro imediato de novas noticias, realizados no momento em que tudo acontece.</p>
            </div>
        </div>
    </div>
</asp:Content>