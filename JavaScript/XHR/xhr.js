function fetchJSONFile(path, callback) {
    var httpRequest = new XMLHttpRequest();
    httpRequest.responseType = 'json';// este XHR sabra que el servidor retornara un JSON, y que debe ser convertido en un objeto JavaScript
    httpRequest.onreadystatechange = function() {
        if (httpRequest.readyState === 4) {
            if (httpRequest.status === 200) {
              // var data = JSON.parse(httpRequest.responseText); // in the case responseType = 'json' is not specified
              if (callback) callback(httpRequest.response);
            }
        }
    };
    httpRequest.open('GET', path);
    httpRequest.send();
}

let button = document.createElement('button');
button.addEventListener("click", function () {
  // this requests the file and executes a callback with the parsed result once it is available
  fetchJSONFile('https://raw.githubusercontent.com/jjoselon/cURL/master/JavaScript/heroes.json', function(data){
      // do something with your data
      console.log(data);
  });
});
button.appendChild(document.createTextNode('JSON parse'));
document.body.appendChild(button); // append in body html
