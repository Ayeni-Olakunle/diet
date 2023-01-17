<%@ Page Title="Task" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="foodCalender.Task" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="holdAll">
        <div class="holdS">
            <div class="holdSwitch">
                <asp:Button ID="Button3" runat="server" class="active" Text="Morning" OnClick="Morning"/>
                <asp:Button ID="Button4" runat="server" class="notActive" Text="Afternoon" OnClick="After_Noon" />
                <asp:Button ID="Button5" runat="server" class="notActive" Text="Evening" OnClick="Night"/>
            </div>

            <div id="morning" runat="server" class="show">
                 <div class="holdContent">
                    <div ID="content" runat="server">
                        <asp:Label ID="Label1" class="morning" runat="server" Text="Morning Food"></asp:Label>
                    </div>
                </div>
                <div class="holdBottom">
                    <asp:Button ID="Button1" runat="server"  class="prev" Text="Prev" OnClick="Decrement" />
                <asp:Button ID="Button2" runat="server" class="next" Text="Next" OnClick="Increment" />
                </div>
            </div>

            <div id="afternoon" runat="server" class="noShow">
                 <div class="holdContent">
                    <div ID="content2" runat="server">
                        <asp:Label ID="Label2" class="morning" runat="server" Text="After noon Food"></asp:Label>
                    </div>
                </div>
                <div class="holdBottom">
                    <asp:Button ID="afterDecrease" runat="server"  class="prev" Text="Prev" OnClick="Decrement2" />
                <asp:Button ID="afterIncrease" runat="server" class="next" Text="Next" OnClick="Increment2" />
                </div>
            </div>

            <div id="night" runat="server" class="noShow">
                 <div class="holdContent">
                    <div ID="content3" runat="server">
                        <asp:Label ID="Label3" class="morning" runat="server" Text="Night Food"></asp:Label>
                    </div>
                </div>
                <div class="holdBottom">
                    <asp:Button ID="nightDecrease" runat="server"  class="prev" Text="Prev" OnClick="Decrement3" />
                <asp:Button ID="nightIncrease" runat="server" class="next" Text="Next" OnClick="Increment3" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>