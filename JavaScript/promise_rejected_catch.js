let promesa = new Promise(function(resolve, reject) {
  // Simulamos un XHR cualquiera
  setTimeout(function() {
    console.log(resolve, reject);
    // Suponiendo que está es la respuesta de nuestro XHR
    reject(['esta', 'es', 'la', 'respuesta', 'ajax']);
  },5000);
});

promesa.then(function (result) {
  // Ponemos esta respuesta es un select por ejemplo
  console.log(result);
}).catch(function (result) {
  // Suponiendo que el XHR falla por conectividad
  console.log("Fail connection ",result);
});
