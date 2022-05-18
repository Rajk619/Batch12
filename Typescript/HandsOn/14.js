var __spreadArray = (this && this.__spreadArray) || function (to, from) {
    for (var i = 0, il = from.length, j = to.length; i < il; i++, j++)
        to[j] = from[i];
    return to;
};
var arr1 = [23, 34, 45];
var arr2 = [98, 76, 34];
var copyArray = __spreadArray([], arr1);
console.log('Copied Array: ' + copyArray);
//create new array with existing array
var newArray = __spreadArray(__spreadArray([], arr2), [89, 90, 13]);
//merge array
var mergeArray = __spreadArray(__spreadArray([], arr1), arr2);
console.log('Merged Array: ' + mergeArray);
