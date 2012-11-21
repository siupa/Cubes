<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CubeIntersect.Default" %>

<%@ Register Src="~/Controls/CubeForm.ascx" TagName="CubeForm" TagPrefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cube Intersection</title>
    <link href="static/css/main.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.8.3.min.js" type="text/javascript"></script>
    <script src="static/js/cubes.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--controls have default values set as shown in the sample data--%>
        <div id="cubeA">
            <uc:CubeForm ID="cbfrmCubeA" Title="Cube A" Size="5" X="10" Y="10" Z="0" runat="server" />
        </div>
        <div id="cubeB">
            <uc:CubeForm ID="cbfrmCubeB" Title="Cube B" Size="2" X="9" Y="9" Z="0" runat="server" />
        </div>
    <asp:Button ID="btnIntersect" runat="server" Text="Calculate intersection" OnClick="btnIntersect_Clicked"
        ClientIDMode="Static" />
    <asp:Literal ID="ltlResults" runat="server"></asp:Literal>
    </div>
    <div id="canvasContainer">
        <canvas id="canvasCubesXY">
        </canvas>
        <canvas id="canvasCubesXZ">
        </canvas>
        <canvas id="canvasCubesYZ">
        </canvas>
    </div>
    </form>
</body>
</html>
