function tulostaLämpötila(lämpötila) {

    if (lämpötila >= 25) {
        console.log(lämpötila + ": Lämpöä piisaa: " + lämpötila);
    }
    else if (lämpötila < -20) {
        console.log(lämpötila + ": Karvahattu päähän!");
    }
    else if (lämpötila < 0) {
        console.log(lämpötila + ": Pipo päähän!");
    }
    else {
        console.log(lämpötila + ": Ei kovin kuumaa.");
    }
}


console.log("Aloitetaan suoritus.");
var lämpötila = 13;
var ikä = 0;
const ikäraja = 18;
var osoite = "";

/*
console.log("Silmukka alkaa.");
for (var i = 0; i < 5; i++) {
    console.log("Silmukan sisällä: " + i);

    if (i >= 4) {
        console.log("Kohta loppuu!");
    }
}
console.log("Silmukka päättyy.");
*/

for (var lämpö = -10; lämpö < 10; lämpö++) {
   tulostaLämpötila(lämpö);
}

/*
console.log(lämpötila);

lämpötila = 17;
// ikäraja = 25;  <-- ei mahdollista, "const"-määritys
console.log(lämpötila);
*/

console.log("Lopetetaan suoritus.");
