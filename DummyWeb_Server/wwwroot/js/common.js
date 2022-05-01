window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Success Notification!',
            message,
            'success'
        )
    }
    if (type === "error") {
        Swal.fire(
            'Error Notification!',
            message,
            'error'
        )
    }
    if (type === "warning") {
        Swal.fire(
            'Warning Notification!',
            message,
            'warning'
        )
    }
}