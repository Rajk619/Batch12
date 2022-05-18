var Calculate = /** @class */ (function () {
    function Calculate() {
    }
    Calculate.prototype.Add = function (a, b) {
        return a + b;
    };
    Calculate.prototype.Greet = function (name) {
        return 'Hello ' + name;
    };
    Calculate.prototype.GetFlowers = function () {
        return ["Rose", "Lilly", "Tulips"];
    };
    Calculate.prototype.IsEven = function (no) {
        return no % 2 == 0 ? true : false;
    };
    return Calculate;
}());
var calc = new Calculate();
console.log(calc.Add(12, 23));
console.log(calc.GetFlowers());
console.log(calc.Greet('Sachin'));
console.log(calc.IsEven(20) ? 'Even' : 'Odd');
