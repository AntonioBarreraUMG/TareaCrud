<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioWeb.aspx.cs" Inherits="TareaCrud.FormularioWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 48px">
            <asp:Button ID="ButtonSQL" runat="server" OnClick="ButtonSQL_Click" Text="Cargar con SQL Server" />
            <asp:Button ID="ButtonMySql" runat="server" OnClick="ButtonMySql_Click" Text="Cargar con MySql" />
        </div>
    </form>
</body>
</html>
