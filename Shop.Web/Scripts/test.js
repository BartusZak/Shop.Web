﻿$(document).ready(function () {

    $.ajaxSetup({ cache: false });

    $("#openDialog").live("click", function (e) {
        e.preventDefault();
        var url = $(this).attr('href');

        $("#dialog-edit").dialog({
            title: 'Add Student',
            autoOpen: false,
            resizable: false,
            height: 355,
            width: 400,
            show: { effect: 'drop', direction: "up" },
            modal: true,
            draggable: true,
            open: function (event, ui) {
                $(this).load(url);
            },
            close: function (event, ui) {
                $(this).dialog('close');
            }
        });

        $("#dialog-edit").dialog('open');
        return false;
    });

    $(".doKoszykaDialog").live("click", function (e) {
        var url = $(this).attr('href');
        $("#dialog-edit").dialog({
            title: 'Edit Customer',
            autoOpen: false,
            resizable: false,
            height: 355,
            width: 400,
            show: { effect: 'drop', direction: "up" },
            modal: true,
            draggable: true,
            open: function (event, ui) {
                $(this).load(url);

            },
            close: function (event, ui) {
                $(this).dialog('close');
            }
        });

        $("#dialog-edit").dialog('open');
        return false;
    });

    $(".confirmDialog").live("click", function (e) {

        var url = $(this).attr('href');
        $("#dialog-confirm").dialog({
            autoOpen: false,
            resizable: false,
            height: 170,
            width: 350,
            show: { effect: 'drop', direction: "up" },
            modal: true,
            draggable: true,
            buttons: {
                "OK": function () {
                    $(this).dialog("close");
                    window.location = url;

                },
                "Cancel": function () {
                    $(this).dialog("close");

                }
            }
        });
        $("#dialog-confirm").dialog('open');
        return false;
    });

    $(".viewDialog").live("click", function (e) {
        var url = $(this).attr('href');
        $("#dialog-view").dialog({
            title: 'View Customer',
            autoOpen: false,
            resizable: false,
            height: 355,
            width: 400,
            show: { effect: 'drop', direction: "up" },
            modal: true,
            draggable: true,
            open: function (event, ui) {
                $(this).load(url);

            },
            buttons: {
                "Close": function () {
                    $(this).dialog("close");

                }
            },
            close: function (event, ui) {
                $(this).dialog('close');
            }
        });

        $("#dialog-view").dialog('open');
        return false;
    });

    $("#btncancel").live("click", function (e) {
        $("#dialog-edit").dialog('close');

    });
});