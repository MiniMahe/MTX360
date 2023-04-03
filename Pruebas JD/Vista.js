function zoomIn() {
    var image = document.getElementById("myImg");
    image.classList.toggle("zoomed");
  }


  document.addEventListener("DOMContentLoaded", function () { zoom(); });
  
  
  function zoom() {
  var myImg = document.getElementById("myImg");
var scale = 1;
var maxScale = 4;
var deltaScale = 0.1;
var lastDelta = 0;

myImg.addEventListener("wheel", function(event) {
  event.preventDefault();
  
  // Detecta la dirección del scroll
  var delta = event.deltaY || event.detail || event.wheelDelta;
  var direction = delta/Math.abs(delta);
  
  // Aplica un incremento proporcional al nivel de zoom actual
  var increment = scale * deltaScale * direction;
  
  // Suma el último delta al incremento para evitar saltos en el zoom
  increment += lastDelta;
  lastDelta = increment % 1;
  
  // Actualiza el valor de escala y limita el valor máximo
  scale += increment;
  if (scale > maxScale) {
    scale = maxScale;
  } else if (scale < 1) {
    scale = 1;
  }
  
  // Establece la propiedad "transform" en CSS para aplicar el zoom
  myImg.style.transform = "scale(" + scale + ")";
});}

// function zoom() {

//   var myImg = document.getElementById("myImg");
//   var scale = 1;
//   var maxScale = 2;
//   var minScale = 1;
  
//   myImg.addEventListener("wheel", function(event) {
//     event.preventDefault();
    
//     var delta = event.deltaX || event.detail || event.wheelDelta;
    
//     // Aumenta el factor de zoom en 0.1 para cada "click" en la rueda del ratón
//     scale += delta * 0.01;
    
//     // Verifica que el factor de escala no supere el máximo permitido
//     if (scale > maxScale) {
//       scale = maxScale;
//     }
//     if (scale <= minScale) {
//       scale = minScale;
//     }
    
//     // Establece la propiedad "transform" en CSS para aplicar el zoom
//     myImg.style.transform = "scale(" + scale + ")";
//   });
  

// }