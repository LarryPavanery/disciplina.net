<%@ Page Title="Work" Language="C#" AutoEventWireup="true" 
 CodeBehind="work.aspx.cs" Inherits="App.work" MasterPageFile="~/master.master" %>


<asp:Content ID="aboutContent" ContentPlaceHolderID="ApplicationMain" runat="server">
	<div class="row work">
        <hr>
        <div class="large-12 columns">
          <h4>Work</h4>

          <ul class="clearing-thumbs small-block-grid-1 medium-block-grid-2 large-block-grid-4" data-clearing>
            <li>
              <a title="Speech understanding in Portuguese, using Spiking Neural Networks." href="#">
              	<img data-caption="Research" src="assets/img/nupex.jpg" width="100" height="100">
              </a>
            </li>
            <li>
              <a title="Documenting, analyzing, estimating, designing, architecturing, developing and testing." href="#">
              	<img data-caption="Analyst" src="assets/img/accenture.png" width="150" height="150">
          	  </a>
            </li>
            <li>
              <a title="LG Electronics." href="#">
              	<img data-caption="Developer" src="assets/img/embedded.png" width="200" height="150">
              </a>
            </li>
            <li>
              <a title="Authoring Tool for Instructional Design." href="#">
              	<img data-caption="Research" src="assets/img/nupex.jpg" width="100" height="100">
              </a>
            </li>
          </ul>
        </div>
      </div>
</asp:Content>
