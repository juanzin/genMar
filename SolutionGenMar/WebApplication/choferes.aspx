<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="choferes.aspx.cs" Inherits="WebApplication.choferes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de choferes</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f5f5f5;
        }
        
        .container {
            max-width: 1200px;
            margin: 0 auto;
            background-color: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
        
        h1 {
            color: #333;
            border-bottom: 3px solid #007bff;
            padding-bottom: 10px;
        }
        
        .filtros {
            margin: 20px 0;
            padding: 15px;
            background-color: #f8f9fa;
            border-radius: 5px;
        }
        
        .filtros label {
            font-weight: bold;
            margin-right: 10px;
        }
        
        .filtros select, .filtros input[type="button"] {
            padding: 8px 15px;
            border: 1px solid #ddd;
            border-radius: 4px;
            margin-right: 10px;
        }
        
        .filtros input[type="button"] {
            background-color: #007bff;
            color: white;
            cursor: pointer;
            border: none;
        }
        
        .filtros input[type="button"]:hover {
            background-color: #0056b3;
        }
        
        .gridview {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        
        .gridview th {
            background-color: #007bff;
            color: white;
            padding: 12px;
            text-align: left;
            font-weight: bold;
        }
        
        .gridview td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }
        
        .gridview tr:hover {
            background-color: #f8f9fa;
        }
        
        .gridview tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        
        .badge {
            padding: 5px 10px;
            border-radius: 12px;
            font-size: 12px;
            font-weight: bold;
        }
        
        .badge-success {
            background-color: #28a745;
            color: white;
        }
        
        .badge-danger {
            background-color: #dc3545;
            color: white;
        }
        
        .info-mensaje {
            padding: 15px;
            margin: 20px 0;
            border-radius: 5px;
            text-align: center;
        }
        
        .info-mensaje.info {
            background-color: #d1ecf1;
            color: #0c5460;
            border: 1px solid #bee5eb;
        }
        
        .info-mensaje.error {
            background-color: #f8d7da;
            color: #721c24;
            border: 1px solid #f5c6cb;
        }

        .menu .button{
            display:inline-block;
        }
        .inputs-container {
            padding: 20px;
        }

        .data-container .item {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>🚛 Gestión de choferes</h1>
            
            <div class="menu-container">

                <div class="menu">
                   <%-- <label>Camiones:</label>
                    <asp:DropDownList ID="opcionesCamion" runat="server" AutoPostBack="false">
                        <asp:ListItem Value="0" Selected="True">Mostrar todos</asp:ListItem>
                        <asp:ListItem Value="1">Agregar</asp:ListItem>
                        <asp:ListItem Value="2">Eliminar</asp:ListItem>
                        <asp:ListItem Value="2">Buscar</asp:ListItem>
                    </asp:DropDownList>--%>
                    <div class="button">
                        <%--<button>Mostrar todos</button>--%>
                        <asp:Button ID="MostrarTodos" runat="server" Text="Mostrar todos" OnClick="OnClickMostrar" />
                    </div>
                    <div class="button">
                        <%--<button>Agregar</button>--%>
                        <asp:Button ID="agregar" runat="server" Text="Agregar" OnClick="OnClickAgregar" />

                    </div>
                    <div class="button">
                        <%--<button>Eliminar</button>--%>
                        <asp:Button ID="Eliminar" runat="server" Text="Eliminar" OnClick="OnClickEliminarOption" />

                    </div>
                    <div class="button">
                        <%--<button>Buscar</button>--%>
                        <asp:Button ID="Buscar" runat="server" Text="Buscar" OnClick="OnClickBuscarOption" />

                    </div>
                </div>
            </div>
            <!-- Filtros -->
            <%--<div class="filtros">
                <label>Filtrar por:</label>
                <asp:DropDownList ID="ddlFiltro" runat="server" AutoPostBack="false">
                    <asp:ListItem Value="0" Selected="True">Todos</asp:ListItem>
                    <asp:ListItem Value="1">Disponibles</asp:ListItem>
                    <asp:ListItem Value="2">No Disponibles</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnFiltrar" runat="server" Text="Buscar" OnClick="btnFiltrar_Click" />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
            </div>--%>
            
            <!-- Mensaje de información -->
            <asp:Panel ID="pnlMensaje" runat="server" Visible="false" CssClass="info-mensaje">
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            </asp:Panel>
            <div class="data-container">
                <asp:GridView ID="GridMostrarData" runat="server"
                    CssClass="gridview"
                    AutoGenerateColumns="False"
                    EmptyDataText="No se encontraron camiones registrados"
                    GridLines="None">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="ID" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApellidoPaterno" HeaderText="Paterno" />
                        <asp:BoundField DataField="ApellidoMaterno" HeaderText="Materno" />
                        <asp:BoundField DataField="Licencia" HeaderText="Licencia" />
                        <asp:BoundField DataField="Telefono" HeaderText="Telefono" DataFormatString="{0:N2}" />
                        <asp:BoundField DataField="Disponibilidad" HeaderText="Disponibilidad" DataFormatString="{0:N0}" />
                        <%--<asp:TemplateField HeaderText="Estado">
                            <ItemTemplate>
                                <span class='badge <%# (bool)Eval("Disponibilidad") ? "badge-success" : "badge-danger" %>'>
                                    <%# (bool)Eval("Disponibilidad") ? "Disponible" : "No Disponible" %>
                                </span>
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                    </Columns>
                </asp:GridView>
                <!-- agregar -->
                <div id="agregarObjecto" class="inputs-container" runat="server">
                    <div class="item">
                        <label>Nombre: </label>
                        <asp:TextBox ID="inputNombre" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <label>Apellido paterno: </label>
                        <asp:TextBox ID="inputApellidoPaterno" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <label>Apellido materno: </label>
                        <asp:TextBox ID="inputApellidoMaterno" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <label>Licencia: </label>
                        <asp:TextBox ID="inputLicencia" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <label>Telefono: </label>
                        <asp:TextBox ID="inputTelefono" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <label>Disponibilidad: </label>
                        <asp:TextBox ID="inputDisponibilidad" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                       <asp:Button ID="guardar" runat="server" Text="Guardar chofer" OnClick="OnClickGuardar" />
                    </div>

                </div>

                <!-- eliminar -->
                <div id="eliminarObjeto" runat="server">
                    <div class="item"> Eliminar chofer</div>
                    <div class="item">
                        <label>Ingrese Id de chofer: </label>
                        <asp:TextBox ID="deleteChofer" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <asp:Button ID="buttonEliminar" runat="server" Text="Eliminar chofer" OnClick="OnClickEliminar" />
                    </div>
                </div>

                <!-- buscar -->
                <div id="buscarObjeto" runat="server">
                    
                    <div class="item">Buscar chofer</div>
                    <div class="item">
                        <label>Ingrese Id de chofer: </label>
                        <asp:TextBox ID="inputBuscar" runat="server"></asp:TextBox>
                    </div>

                    <div class="item">
                        <asp:Button ID="buttonBuscar" runat="server" Text="Buscar chofer" OnClick="OnClickBuscar" />
                    </div>

                    <asp:GridView ID="GridViewBuscar" runat="server"
                        CssClass="gridview"
                        AutoGenerateColumns="False"
                        EmptyDataText="No se encontraron camiones registrados"
                        GridLines="None">
                        <Columns>
                  
                            <asp:BoundField DataField="Id" HeaderText="ID" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="ApellidoPaterno" HeaderText="Paterno" />
                            <asp:BoundField DataField="ApellidoMaterno" HeaderText="Materno" />
                            <asp:BoundField DataField="Licencia" HeaderText="Licencia" />
                            <asp:BoundField DataField="Telefono" HeaderText="Telefono" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="Disponibilidad" HeaderText="Disponibilidad" DataFormatString="{0:N0}" />
                     
                        </Columns>
                    </asp:GridView>

                </div>

            </div>
            <!-- end data-container -->
        </div>
    </form>
</body>
</html>--%>
