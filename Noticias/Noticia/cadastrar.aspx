<%@ Page Title="Cadastrar Noticias" Language="C#" AutoEventWireup="true"
 CodeBehind="cadastrar.aspx.cs" Inherits="Noticia.cadastrar" MasterPageFile="~/master.master" %>

<asp:Content ID="cadastrarContent" ContentPlaceHolderID="ApplicationMain" runat="server">
<!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('assets/img/about-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="page-heading">
                        <h1>Uma nova Noticia?</h1>
                        <hr class="small">
                        <span class="subheading">Isto será muito divertido o/</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                <form id="form" runat="server" role="form">

					<div class="form-group">
					<label for="titulo">Titulo</label>
						<asp:TextBox runat="server" OnTextChanged="titulo_TextChanged" class="form-control" id="titulo" placeholder="Titulo" />
					</div>

					<div class="form-group">
					<label for="calendario">Calendario</label>
						<asp:Calendar id="calendario" runat="server" />
					</div>

					<div class="form-group">
					<label for="texto">Texto</label>
						<asp:TextBox id="texto" class="form-control" rows="4" runat="server" TextMode="MultiLine" />
					</div>

            		<asp:Button id="button" runat="server" class="btn btn-default" Text="Cadastrar" />
		        </form>
            </div>
        </div>
    </div>
</asp:Content>