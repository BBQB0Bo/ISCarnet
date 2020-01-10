var map;

function initMap() {

    //Map options and new map 
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 47.168733, lng: 27.541590 },
        zoom: 15
    });
}

function addMarker() {

    var x = document.getElementById("punctPlecare").value;

    /*Trebuie modificate coordonatele si adaugate zone noi*/

    if (x == "Zona Gara") {
        coords = { lat: 47.168731, lng: 27.541580 };
    } else if (x == "Moara de Foc") {
        coords = { lat: 47.128730, lng: 27.541 };
    }

    var marker = new google.maps.Marker({
        position: coords,
        map: map,
        icon: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png'
    });

    map.addListener('center_changed', function () {
    
        window.setTimeout(function () {
            map.panTo(marker.getPosition());
        }, 3000);
    });

    marker.addListener('click', function () {
        map.setZoom(15);
        map.setCenter(marker.getPosition());
    });
}
