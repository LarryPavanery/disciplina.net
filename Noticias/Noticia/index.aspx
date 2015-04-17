
<%@ Page Title="Noticias" Language="C#" AutoEventWireup="true"
 CodeBehind="index.aspx.cs" Inherits="Noticia.index" MasterPageFile="~/master.master" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="ApplicationMain" runat="server">
    <!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('assets/img/home-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="site-heading">
                        <h1>Noticias</h1>
                        <hr class="small">
                        <span class="subheading">Um simples site que mostra o mundo</span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Main Content -->
    <div class="container">
	     <div class="row">
	        <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
	            <div class="post-preview">
	                <a href="post.html">
	                    <h2 class="post-title">
	                        Instagram revisa termos de uso para barrar bullying e pornografia
	                    </h2>
	                    <h3 class="post-subtitle">
	                        O Instagram revisou suas regras de conduta no aplicativo e adotou um tom mais agressivo contra possíveis infratores. O primeiro sinal de que os tempos mudaram vem da forma como o texto é escrito, já que o número de vezes que a expressão “por favor” aparece foi reduzido de quatro para apenas uma.
	                    </h3>
	                </a>
	                <p class="post-meta">Postado por <a href="http://olhardigital.uol.com.br/noticia/instagram-revisa-termos-de-uso-para-barrar-bullying-e-pornografia/48031">Olhar Digital</a> em 16/04/2015 às 21h04</p>
	            </div>
	            <hr>
	            <div class="post-preview">
	                <a href="cadastrar.aspx">
	                    <h2 class="post-title">
	                        Jogo "Project Cars" tem suporte a resolução de até 12K no PC
	                    </h2>
	                </a>
	                <p class="post-meta">Postado por <a href="http://olhardigital.uol.com.br/noticia/jogo-project-cars-tem-suporte-a-resolucao-de-ate-12k-no-pc/48029">Olhar Digital</a> em 16/04/2015 às 18h40</p>
	            </div>
	            <hr>
	            <div class="post-preview">
	                <a href="cadastrar.aspx">
	                    <h2 class="post-title">
	                        Petrobras confirma que divulgará balanços auditados na próxima quarta
	                    </h2>
	                    <h3 class="post-subtitle">
	                        Resultados contábeis serão publicados após reunião do Conselho. Balanços estão atrasados devido às investigações da Lava Jato.
	                    </h3>
	                </a>
	                <p class="post-meta">Postado por <a href="#">G1</a> em 16/04/2015 21h14</p>
	            </div>
	            <hr>
	            <div class="post-preview">
	                <a href="cadastrar.aspx">
	                    <h2 class="post-title">
	                        Estudantes fazem megaprotesto contra reforma na educação do Chile
	                    </h2>
	                    <h3 class="post-subtitle">
	                        Manifestação foi repreendida com jatos de água e prisões. Universitários são contra mudanças no sistema de financiamento.
	                    </h3>
	                </a>
	                <p class="post-meta">Postado por <a href="http://g1.globo.com/educacao/noticia/2015/04/estudantes-fazem-megaprotesto-contra-reforma-na-educacao-do-chile.html">G1</a> em 16/04/2015 17h03</p>
	            </div>
	            <hr>
	            <!-- Pager -->
	            <ul class="pager">
	                <li class="next">
	                    <a href="#">Outras noticias &rarr;</a>
	                </li>
	            </ul>
	        </div>
	    </div>
    </div>
</asp:Content>