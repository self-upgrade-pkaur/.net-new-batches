"use strict";
exports.__esModule = true;
var Employee = /** @class */ (function () {
    function Employee(name, id) {
        this.employeeName = name;
        this.EmpId = id;
    }
    Employee.prototype.greet = function () {
        console.log("Hello " + this.employeeName + " - " + this.EmpId);
    };
    return Employee;
}());
exports.Employee = Employee;
var emp = new Employee("Pushpinder Kaur", "1301HH");
emp.greet();
