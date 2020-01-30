"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
//TS by Microsoft
// Static typed, class based objects, compatible with ES6, Modular, close to high level language syntax, code readable and easier
//Types:string, number, boolean,Array,Any,Unknown,Void, Null, Tuple, Enum, Generics
//class based objects: OOPs, No Prototypes,Encapsulation, Inheritance, Modifiers
//Install Node Js
// create a .ts file
// compile to JS file using tsc file name
// run on node.js file 
// run on watch mode tsc *.ts -w
var Employee_1 = require("./Employee");
var message = 'Welcome Back again!!';
//console.log(message);
var x = 10;
var y = 20;
//let x=30;//error due to same name type
//x=30;//can't assign to a const
// y="string value";// Typescript is statically typed
//we can also assign a datatype
var name;
name = "Pushpinder Kaur";
name.toUpperCase(); // auto intellisense
var age = 28;
var sentence = "My name is " + name + "\nI am " + age + " years old";
//console.log(sentence);
//they are the subset of any other datatypes
var n = null;
var u = undefined;
var isNew = true;
var scores = [91, 92, 93];
var scores2 = [10, 20, 39];
scores2.forEach(function (element) {
    console.log(element);
});
var DaysOdWeek;
(function (DaysOdWeek) {
    DaysOdWeek[DaysOdWeek["Sunday"] = 1] = "Sunday";
    DaysOdWeek[DaysOdWeek["Monday"] = 2] = "Monday";
    DaysOdWeek[DaysOdWeek["Tuesday"] = 3] = "Tuesday";
    DaysOdWeek[DaysOdWeek["Wednesday"] = 4] = "Wednesday";
    DaysOdWeek[DaysOdWeek["Thursday"] = 5] = "Thursday";
    DaysOdWeek[DaysOdWeek["Friday"] = 6] = "Friday";
    DaysOdWeek[DaysOdWeek["Saturday"] = 7] = "Saturday";
})(DaysOdWeek || (DaysOdWeek = {}));
var randomValue = 10;
randomValue = true;
randomValue = "Hello World!!";
var myVar = 10;
//console.log(myVar);
var a;
a = 10;
a = true; //no type inference
//let b=20;
//b="hjj";//type is inferred, so leads to error
var multitype; //union of types
multitype = 20;
multitype = "Hello World!!";
//function
// vvv  optional param  should always be passed at the end     
function add(a, b) {
    if (a === void 0) { a = 10; }
    if (b)
        return a + b;
    else
        return a;
}
function getFullName(person) {
    if (person.middlename)
        return person.firstname + " " + person.middlename + " " + person.lastname;
    else
        return person.firstname + " " + person.lastname;
}
var person = {
    firstname: "Harry",
    lastname: "Potter ji"
};
//console.log(getFullName(person));
//CLASSES: inheritance
var Manager = /** @class */ (function (_super) {
    __extends(Manager, _super);
    function Manager(mangerName) {
        return _super.call(this, "Test2 Emp", "321JH") || this;
    }
    Manager.prototype.delegateWork = function () {
        console.log('Delegates works');
    };
    return Manager;
}(Employee_1.Employee));
var m1 = new Manager("Bruce");
m1.greet();
var tuple = ["Emp1", 100];
//console.log(tuple[1]);
var d = [0, 1, null];
console.log(typeof (d));
