var listOfMoney = document.querySelectorAll('[currency]');

// Formatting Currency (Erwin)
var PHP = new Intl.NumberFormat('tl-PH', {
    style: 'currency',
    currency: 'PHP',
});

for (let i = 0; i < listOfMoney.length; i++) {
    PHP.format(listOfMoney[i]);
}