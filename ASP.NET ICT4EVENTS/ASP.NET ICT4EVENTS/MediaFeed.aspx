<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MediaFeed.aspx.cs" Inherits="ASP.NET_ICT4EVENTS.MediaFeed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="mediaFeed" style="width:100%">
        <tr>
            <td>
                <asp:Image runat="server" ID="Image1" Height="187px" Width="150px"/>
            </td>
            <td>
                <asp:Image runat="server" ID="Image2" Height="187px" Width="150px"/>
            </td>
            <td>
                <asp:Image runat="server" ID="Image3" Height="187px" Width="150px"/>
            </td>
        </tr>

        <tr>
            <td>Upload 4</td>
            <td>Upload 5</td>
            <td>Upload 6</td>
        </tr>

        <tr>
            <td>Upload 7</td>
            <td>Upload 8</td>
            <td>Upload 9</td>
        </tr>
    </table>
</asp:Content>
