﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AuctionControl.ascx.cs" Inherits="Portal_aukcyjny.UserControls.AuctionControl" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }

    .auto-style3 {
        width: 80px;
    }

    .auto-style4 {
        width: 100%;
        margin-bottom: 15px;
    }

    .auto-style5 {
        font-size: large;
        text-decoration: underline;
    }

    .auto-style6 {
        height: 23px;
        width: 205px;
    }

    .auto-style7 {
        border-top: 1px solid gray;
        padding-top: 5px;
        height: 31px;
    }

    .auto-style8 {
        height: 23px;
        width: 249px;
    }

    .auto-style9 {
        height: 23px;
        text-align: left;
    }

</style>

<table class="auto-style4">
    <tr>
        <td class="auto-style7" colspan="4"><strong>
            <asp:HyperLink ID="Title" runat="server" CssClass="auto-style5">HyperLink</asp:HyperLink>
        </strong></td>
    </tr>
    <tr>
        <td class="auto-style3" rowspan="3">
            <asp:Image ID="Image" runat="server" Height="80px" ImageAlign="Middle" Width="80px" />
        </td>
        <td class="auto-style6"><strong>
            <asp:Label ID="Label7" runat="server" Text="<%$ Resources:Sprzedający%>"></asp:Label>
        </strong>
            <asp:HyperLink ID="Seller" runat="server">HyperLink</asp:HyperLink>
        </td>
        <td class="auto-style8"><strong>
            <asp:Label ID="BuyItNowLabel" runat="server" Text="<%$ Resources:Kup teraz%>" Visible="False"></asp:Label>
        </strong>
            <asp:Label ID="BuyItNow" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        <td class="auto-style1">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>
            <asp:Label ID="TimeLeftLabel" runat="server" Text="<%$ Resources:Pozostało%>"></asp:Label>
        </strong>
            <asp:Label ID="TimeLeft" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style8"><strong>
            <asp:Label ID="BidLabel" runat="server" Text="<%$ Resources:Licytacja%>" Visible="False"></asp:Label>
        </strong>
            <asp:Label ID="Bid" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        <td class="auto-style1">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>
            <asp:Label ID="Label13" runat="server" Text="<%$ Resources:Wyświetleń%>"></asp:Label>
        </strong>
            <asp:Label ID="Views" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style8"><strong>
            <asp:Label ID="Label5" runat="server" Text="<%$ Resources:Ofert%>"></asp:Label>
        </strong>
            <asp:Label ID="OffersNum" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style9"><strong>
            <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Wysyłka%>"></asp:Label>
        </strong>
            <asp:Label ID="Shipment" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>

