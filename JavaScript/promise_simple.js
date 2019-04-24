let promesa = new Promise(function(resolve, reject) {
  // Simulamos un XHR cualquiera
  setTimeout(function() {
    // Suponiendo que está es la respuesta de nuestro XHR
    resolve(['esta', 'es', 'la', 'respuesta', 'ajax']);
  },5000);
});

promesa.then(function (result) {
  // Ponemos esta respuesta es un select por ejemplo
  console.log(result);
});
