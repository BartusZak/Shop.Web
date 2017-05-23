﻿$(document).ready(function () {
    $('.AddUser').on('click', function () {
        $("#AddUserForm").dialog({
            autoOpen: true,
            position: { my: "center", at: "top+350", of: window },
            width: 1000,
            resizable: false,
            title: 'Add User Form',
            modal: true,
            open: function () {
                $(this).load('@Url.Action("AddUserPartialView")');
            },
            buttons: {
                "Add User": function () {
                    addUserInfo();
                },
                Cancel: function () {
                    $(this).dialog("close");
                }
            }
        });
        return false;
    });
    function addUserInfo() {
        $.ajax({
            url: '@Url.Action("AddUserInfo", "Wszystkies")',
            type: 'POST',
            data: $("#myForm").serialize(),
            success: function (data) {
                if (data) {
                    $(':input', '#myForm')
                      .not(':button, :submit, :reset, :hidden')
                      .val('')
                      .removeAttr('checked')
                      .removeAttr('selected');
                }
            }
        });
    }
});