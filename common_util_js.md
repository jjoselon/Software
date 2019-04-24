Get event tiggered:
```javascript
console.log(`event fired ${event.type}`); 
```

Get name of the function and its caller

```javascript
console.log(`Function ${arguments.callee.name.toString()} called ${Function.caller == null ? 'from the top' : 'by ' + Function.caller}`)
```

## Convertir una cadena `JSON` a un objeto literal de javascript, lo denominamos como `parsing`
> Se logra con el método parse() del objeto global JSON
[parse() API](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse)
```javascript
var json = '{"result":true, "count":42}';
obj = JSON.parse(json);
```

## Convertir un objeto literal de javascript a un `JSON` para tratarlo, lo denominamos como `stringification`
> Se logra con el método stringify() del objeto global JSON
[stringify() API](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)
```javascript
console.log(JSON.stringify({ x: 5, y: 6 }));
// expected output: "{"x":5,"y":6}"

console.log(JSON.stringify([new Number(3), new String('false'), new Boolean(false)]));
// expected output: "[3,"false",false]"

console.log(JSON.stringify({ x: [10, undefined, function(){}, Symbol('')] }));
// expected output: "{"x":[10,null,null,null]}"

console.log(JSON.stringify(new Date(2006, 0, 2, 15, 4, 5)));
// expected output: ""2006-01-02T15:04:05.000Z""
```
