<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FullCatalog.aspx.cs" Inherits="CSharpGuitarBugs.Views.Catalog.FullCatalog" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Full Catalog - CSharpGuitarBugs</title>
    <link href="/Content/bootstrap.css" rel="stylesheet"/>
<link href="/Content/site.css" rel="stylesheet"/>
    <script src="/Scripts/modernizr-2.6.2.js"></script>
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="/">CSharpGuitarBugs</a>
            </div>            
        </div>
    </div>
    <div class="container body-content">
    <h2>Full Catalog</h2>
        <hr />
        <asp:Label ID="labelStatus" runat="server" />
        <form runat="server">
            <asp:Button runat="server" ID="FourHundredButton1" Text="Refresh" OnClick="FourHundredButton1_Click" />
            <asp:Button runat="server" ID="FourHundredButton2" Text="Next Page" OnClick="FourHundredButton2_Click" />
        </form>
        <br />
        <footer>
            <p>&copy; 2016 - TheBestCSharpProgrammerInTheWorld</p>
            <p><asp:Label ID="aspnetPipelineLabel" runat="server" /></p>
        </footer>
    </div>
    <script src="/Scripts/jquery-1.10.2.js"></script>
    <script src="/Scripts/bootstrap.js"></script>
<script src="/Scripts/respond.js"></script>

</body>
</html>

