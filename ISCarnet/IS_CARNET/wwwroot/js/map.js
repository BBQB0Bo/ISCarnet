var map;

function initMap() {
    //Map options and new map 
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 47.168733, lng: 27.541590 },
        zoom: 15
    });
}

function addMarker(latitudine, longitudine) {
    coords = { lat: latitudine, lng: longitudine }
    var marker = new google.maps.Marker({
        position: coords,
        map: map,
        icon: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png'
    });
}