export class Employee{
    employeeName:string;
    EmpId:string;
    constructor(name:string,id:string){
        this.employeeName=name;
        this.EmpId=id;
    }
    greet(){
        console.log(`Hello ${this.employeeName} - ${this.EmpId}`)
    }
}

let emp=new Employee("Pushpinder Kaur","1301HH");
emp.greet();

interface StringValidator {
    isAcceptable(s: string): boolean;
}

let lettersRegexp = /^[A-Za-z]+$/;
let numberRegexp = /^[0-9]+$/;

class LettersOnlyValidator implements StringValidator {
    isAcceptable(s: string) {
        return lettersRegexp.test(s);
    }
}
