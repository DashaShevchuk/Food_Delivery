// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('.smallbaner').mouseover(function () {
    $(this).animate({
        height: '+= 100px',
        width: '+= 100px',
    });
});