function toggleSidebar() {
    document.getElementById("sidebar").classList.toggle('active');
}

function myFunction() {
    var x = document.getElementById("UserPassword");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}