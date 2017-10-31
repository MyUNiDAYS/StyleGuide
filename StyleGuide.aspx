<%-- Imports at the top --%>
<%@ Import Namespace="System" %>

<%-- Page details next --%>
<%@ Page Language="C#" Title="Page Title" MasterPageFile="~/Areas/Common/Views/Shared/site.master" Inherits="ViewPage<Object>" %>

<%-- Then the page sections --%>
<asp:Content ContentPlaceHolderID="Head" runat="server">

<%-- Then local scripts --%>
<script type="text/javascript">
	$(function () {
		alert('Stuff and things');
	});	
</script>

<ul>
<%-- Keep loops and IFs indented -1, so that the markup is generated with correct indentation --%>
<% foreach (var thing in Model) %>
<% { %>
	<li><%: thing %></li>
<% } %>
</ul>

<%-- The opening brace for an if or loop should be on a new line. --%>
<% if (thing == stuff) %>
<% { %>
	<div>Stuff & Things</div>
<% } %>

<%-- Don't add carriage returns to elements. Let the editor wrap the code. --%>
<section id="Page_Index" data-one="A large amount of data" data-two="A large amount of data" data-three="A large amount of data" data-four="A large amount of data" data-five="A large amount of data" data-six="A large amount of data"></section>

<%-- CSS classes that are used for JavaScript selectors should be prefixed with `js-`. --%>
<div class="js-div-to-select"></div>

<%-- CSS classes should not be used for both CSS and JavaScript selectors. Create multiple classes where necessary. --%>
<div class="js-div-to-select div-to-style"></div>

<%-- Where Razor will be reused, create a partial view. --%>
<% Html.RenderPartial("../Shared/PartialView", Model); %>

<%-- For partial views that are shared across the site, especially those that take parameters, consider creating an HTML helper function. --%>
<%: Html.HelperFunction(ViewData.HelperParamOne, ViewData.HelperParamTwo) %>

<%-- Use ternary operators to conditonally insert element classes. --%>
<div class="<%: (ViewData.Thing == OtherThing ? "js-thing" : null) %>"></div>

<%-- Tables should have both thead and tbody --%>
<table>
	<thead>
		<tr>
			<th></th>
			<th></th>
			<th></th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td></td>
			<td></td>
			<td></td>
		</tr>
	</tbody>
</table>

<%-- Handlers should have a single responsibility. If you need multiple submit buttons with different effects, create multiple
forms and multiple handlers. --%>
<form target="/handler-one">
	<input type=submit value="Submit One" />
</form>
<form target="/handler-two">
	<input type=submit value="Submit Two" />
</form>

<%-- Don't do this. --%>
<form target="/everything-handler">
	<input type=submit value="SaveDataInOneWay" name="action" />
	<input type=submit value="SaveDataInAnotherWay" name="action" />
</form>