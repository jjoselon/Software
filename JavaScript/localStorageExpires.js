    try {
        // Set cookie del localStorage
        if (typeof (localStorage) != "undefined" && (typeof (localStorage) != null) && (window.localStorage)) {

            // Si no existe el item se procede a crearlo
            if (localStorage.getItem('resource') === null && localStorage.getItem('resource_expiresIn') === null) {
                localStorage.setItem('resource', JSON.stringify({ idResources: [/* empty array */]}));
                var now = new Date();
                var oneMonthExpires = now.setMonth(now.getMonth() + 1); // can be other date
                localStorage.setItem('resource_expiresIn', oneMonthExpires)
            }
            // Obtener en formato JSON el contenido del item
            var idResourcesViewedJSON = JSON.parse(localStorage.getItem('resource'));
            var expiresIn = localStorage.getItem('resource_expiresIn');

            if (expiresIn < Date.now()) {
                try {
                    localStorage.removeItem('resource');
                    localStorage.removeItem('resource_expiresIn');
                    // Finish
                    return;
                } catch(e) {
                    console.log(e.toString())
                }
            }

            // Cantidad de recursos vistos
            var lengthIdResourceViewed = idResourcesViewedJSON.idResources.length;

            // Válida que no exista ese id dentro del localStorage
            if ($.inArray(idResource, idResourcesViewedJSON.idResources) == -1) {
                // NO encontro ese id del articulo, lo almacenamos
                idResourcesViewedJSON.idResources.push(idResource);
                // Guarda los cambios dados
                localStorage.setItem('resource', JSON.stringify(idResourcesViewedJSON));
                idResourcesViewedJSON = JSON.parse(localStorage.getItem('resource'));
                lengthIdResourcesViewed = idResourcesViewedJSON.idResources.length;

                // Se almacena/actualiza el item contador
                localStorage.setItem("counter" + lengthIdResourcesViewed);
            }
            // More logic...
        } else {
            // Cuando localStorage no este disponible
        }
    } catch (e) {
        console.log(e.toString())
    }
