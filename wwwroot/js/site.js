// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function setImage(select) {
    var image = document.getElementsByName("image-swap")[0];
    image.src = select.options[select.selectedIndex].id;
}