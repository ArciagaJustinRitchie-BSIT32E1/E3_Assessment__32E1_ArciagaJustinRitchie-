function EvenOrOdd() {

    var inputNumber = parseInt(document.getElementById("numberInput").value);

    var result = checkEvenOrOdd(inputNumber);

    document.getElementById("resultParagraph").innerText = `The number is ${result}.`;
}

function checkEvenOrOdd(number) {
    if (number % 2 === 0) {
        return "Even";
    } else {
        return "Odd";
    }
}