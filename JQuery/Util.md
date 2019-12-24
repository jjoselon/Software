## Si el scroll toca cierto nodo

```js

var alreadyScrolled = false;
$(window).scroll(function () {
    if (!alreadyScrolled && $('#node').size() > 0 && $('#node').offset().top < $(this).height() + $(this).scrollTop()) {
        alreadyScrolled = true;
        // something else
    }
}
```
