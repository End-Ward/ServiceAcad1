document.addEventListener("DOMContentLoaded", function () {
    var modal = document.getElementById("myModal");
    var span = document.getElementsByClassName("close")[0];
    var body = document.getElementById("blurBody");

    // Automatically open the modal on page load
    modal.style.display = "flex";
    body.classList.add("blur-background");

    // When the user clicks on <span> (x), close the modal
    span.onclick = function () {
        modal.style.display = "none";
        body.classList.remove("blur-background");
    }

    // When the user clicks anywhere outside of the modal, close it
    window.onclick = function (event) {
        if (event.target == modal) {
            modal.style.display = "none";
            body.classList.remove("blur-background");
        }
    }
});
