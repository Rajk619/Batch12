//enum 
var Week;
(function (Week) {
    Week[Week["Mon"] = 1] = "Mon";
    Week[Week["Tue"] = 2] = "Tue";
    Week[Week["Wed"] = 3] = "Wed";
    Week[Week["Thu"] = 4] = "Thu";
    Week[Week["Fri"] = 5] = "Fri";
    Week[Week["Sat"] = 6] = "Sat";
    Week[Week["Sun"] = 7] = "Sun";
})(Week || (Week = {}));
console.log(Week.Fri);
