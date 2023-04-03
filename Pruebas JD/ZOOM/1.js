
document.addEventListener("DOMContentLoaded", function () { zoom(); });


function zoom() {
    var myImg = document.getElementById("myimg");
    var scale = 1;

    myImg.addEventListener("wheel", function (event) {
        event.preventDefault();

        var delta = event.deltaY || event.detail || event.wheelDelta;

        // Aumenta el factor de zoom en 0.1 para cada "click" en la rueda del ratón
        scale += delta * 0.01;

        // Establece la propiedad "transform" en CSS para aplicar el zoom
        myImg.style.transform = "scale(" + scale + ")";
    });

}
