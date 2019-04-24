// implode en php (convierte un array en un string), equivalente a join() de javascript

let mimetypes = {
  xlsx : "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
  pdf : "application/pdf",
  jpeg : "image/jpeg",
  jpg : "image/jpeg",
  png : "image/png"
}

document.write(`mime types : ${Object.keys(mimetypes).join(", ")}`); // >_ mime types : xlsx, pdf, jpeg, jpg, png
// o
document.write(`mime types : ${["hello", ' world'].toString()}`) // >_ 'hello, world'

// explode en php (convierte un string en un array) equivalente a split() de javascript

console.log('hello world'.split(' ')); // >_ ['hello', 'wolrd']
