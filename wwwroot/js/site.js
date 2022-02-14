function confirmOK(url) {
	window.location.href = url;
}

function confirmCancel() {
	$('#alertConfirm').hide();
}

function confirmOKAlert() {
	var id = $('#hiddenId').val();
	var action = $('#action').val();
	$('#alertConfirm').hide();
	if (action == "delete-data") {
		window.location.href = "/ListData/Delete?id=" + id;
	} else if (action == "delete-user") {
		window.location.href = "/ListUser/Delete?id=" + id;
	} else if (action == "delete-category") {
		window.location.href = "/ListCategory/Delete?id=" + id;
	}
}

function confirmDelete(id, action) {
	$('#messageAlert').text("Do you want to delete this data?");
	$('#alertConfirm').show();
	$('#hiddenId').val(id);
	$('#action').val(action);
}

function openAPI(id) {
	var url = "/api/GetData?userId=" + id;
	window.open(url, '_blank').focus();
}