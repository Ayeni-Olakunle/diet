<%@ Page Title="Task" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Task.aspx.cs" Inherits="foodCalender.Task" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="holdAll">
        <div class="holdS">
            <div class="holdSwitch">
                <div class="active">Morning</div>
                <div class="notActive">Afternoon</div>
                <div class="notActive">Evening</div>
            </div>
            <div class="holdContent">
                <div id="content">
                    <p class="morning">Morning Food</p>
                </div>
            </div>
            <div class="holdBottom">
                <input id="prev" class="prev" type="button" value="Prev" onclick="return pre()" />
                <input id="next" class="next" type="button" value="Next" onclick="return check()" />
            </div>
        </div>
    </div>
    <script src="Scripts/Task.js"></script>
</asp:Content>
