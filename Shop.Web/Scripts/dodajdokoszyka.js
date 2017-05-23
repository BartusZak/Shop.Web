$(document).ready(function () {
    var url = "";
    var Title = "";
    $("#dialogCreate").dialog({
        width: 400,
        modal: true,
        autoOpen: false,
        open: function () {
            $(".ui-dialog-titlebar-close").remove();
            $(".ui-dialog-title").html(Title);
            // $(".ui-dialog-titlebar").removeClass("ui-widget-header");
            $(this).load(url);
        },
    });

    $("#dialogConfirm").dialog({
        modal: true,
        autoOpen: false,
        open: function () {
            $(".ui-dialog-title").html("Confirm");

        },
        buttons: {
            Cancel: function () { $(this).dialog("close"); },
            Ok: function () {
                window.location.href = url;
            }
        },
    });

    $("#dialogAlert").dialog({
        modal: true,
        autoOpen: false,
        open: function () {
            $(".ui-dialog-title").html("Alert");

        },
        buttons: {
            Cancel: function () { $(this).dialog("close"); },
            Ok: function () {
                $(this).dialog("close");
            }
        },
    });

    $("#dialogdoKoszyka").dialog({
        title: "Dodaj do koszyka",
        modal: true,
        autoOpen: false,
        open: function () {
            $(".ui-dialog-titlebar-close").hide();
            $(".ui-dialog-title").html("doKoszyka");
            $(this).load(url);
        },
        buttons: {
            Cancel: function () { $(this).dialog("close"); },
            Ok: function () {
                $(this).dialog("close");
            }
        },
    });

    if ('@TempData["Message"]' != "") {
        $("#dialogAlert").dialog("open");
    }


    $("#btnCreate").click(function (event) {
        event.preventDefault();
        url = $(this).attr("href");
        Title = "Create User";
        $("#dialogCreate").dialog("open");
    });

    $(".delete").live("click", function (event) {
        event.preventDefault();
        url = $(this).attr("href");
        $("#dialogConfirm").dialog("open");
    });

    $(".dokoszyka").live("click", function (event) {
        event.preventDefault();
        url = $(this).attr("href");
        $("#dialogdoKoszyka").dialog("open");
    });


    $(".edit").live("click", function (event) {
        event.preventDefault();
        url = $(this).attr("href");
        Title = "Edit User";
        $("#dialogCreate").dialog("open");
    });


    $("#btnCancel").live("click", function () {
        $("#dialogCreate").dialog("close");
    });


});