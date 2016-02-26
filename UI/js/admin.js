//Load
$(function () {
    $('#addUser').click(function () {
        AddUser();
    });
});

//show dialog
function AddUser() {
    $('#addDiv').css('display', 'block');
    $('#addDiv').dialog({
        title: 'Add User Info',
        width: 300,
        height: 300,
        buttons: [{
            text: 'Add',
            iconCls: 'icon-ok',
            handler: function () {
                //Add User Info
                addUserEvent();
            }
        }, {
            text: 'Cancel',
            handler: function () {
                $('#addDiv').dialog('close');
            }
        }]
    });
}

//Add User Info
function addUserEvent() {
    var serverData = $('#addForm').serializeArray();
    $.post("UserManagerAdd.aspx", serverData, function (data) {
        if (data == 'ok') {
            alert("Fail to Add!!!");
        } else {
            alert('Sucess!');
            location.reload();
            $('#addDiv').dialog('close');
        }
    });
}

function RemoveConfirm(id) {
    if (confirm("Are you sure?"))
    {
        $.post('UserManagerRemove.ashx', { id: id }, function (data) {
            if (data == 1) {
                location.reload();
            } else {
                alert("Fail to Delete");
            }
        });
    }
}