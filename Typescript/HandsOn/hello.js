var Program = (function () {
    function Program(msg) {
        this.msg = msg;
    }
    Program.prototype.show = function () {
        console.log("Your Message: " + this.msg);
    };
    return Program;
}());
var obj = new Program("Hello TypeScript");
obj.show();
