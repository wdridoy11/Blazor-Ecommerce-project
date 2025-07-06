window.showSwal = function (type, message) {
    if (type == 'success') {
        Swal.fire({
            title: "Success",
            text: message,
            icon: "success"
        });
    }
    else if (type == 'error') {
        Swal.fire({
            title: "error",
            text: message,
            icon: "error"
        });
    }
}

window.isConfirm = function (message) {
    return Swal.fire({
        title: "Are you sure?",
        text: message,
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        return result.isConfirmed; // ✅ return true or false to Blazor
    });
};
