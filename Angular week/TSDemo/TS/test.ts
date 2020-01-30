//TS by Microsoft
// Static typed, class based objects, compatible with ES6, Modular, close to high level language syntax, code readable and easier
//Types:string, number, boolean,Array,Any,Unknown,Void, Null, Tuple, Enum, Generics
//class based objects: OOPs, No Prototypes,Encapsulation, Inheritance, Modifiers
//Install Node Js
// create a .ts file
// compile to JS file using tsc file name
// run on node.js file 
// run on watch mode tsc *.ts -w
import {Employee} from './Employee'
let message='Welcome Back again!!';
//console.log(message);
 const x=10;
 let y =20;
 //let x=30;//error due to same name type
 //x=30;//can't assign to a const

// y="string value";// Typescript is statically typed
//we can also assign a datatype
let name: string;
name="Pushpinder Kaur";
name.toUpperCase();// auto intellisense
let age:number =28;
let sentence: string =`My name is ${name}
I am ${age} years old`;
//console.log(sentence);

//they are the subset of any other datatypes
let n:null=null;
let u:undefined=undefined;

let isNew: boolean=true;
let scores:number[]=[91,92,93];
let scores2:Array<number>=[10 ,20,39];
scores2.forEach(element => {
   console.log(element);
});
 enum DaysOdWeek{Sunday=1,Monday,Tuesday, Wednesday,Thursday,Friday,Saturday}

 let randomValue:any=10;
 randomValue=true;
 randomValue="Hello World!!"

 let myVar:unknown=10;
 //console.log(myVar);
 
 let a;
 a=10; 
 a=true;//no type inference

 //let b=20;
 //b="hjj";//type is inferred, so leads to error

 let multitype: number|string//union of types
 multitype=20;
 multitype="Hello World!!";
 //function
                   // vvv  optional param  should always be passed at the end     
 function add(a:number=10,b?:number):number{
    if(b) 
        return a+b;
    else 
        return a;
 }
//console.log(add(5,10));
 //add(3,'3');//error as typechecking is happening
//console.log(add());//passing only one paramenter

//INTERFACES
/*function getFullName(person:{firstname:string,lastname:string}){
    return `${person.firstname} ${person.lastname}`;
}

let person={
    firstname:"Harry",
    lastname:"Potter"
};*/
interface Person{
    firstname:string,
    middlename?:string,
    lastname:string
}

function getFullName(person:Person){
    if(person.middlename)
        return `${person.firstname} ${person.middlename} ${person.lastname}`;
    else
        return `${person.firstname} ${person.lastname}`;
}
let person={
    firstname:"Harry",
    lastname:"Potter ji"
};
//console.log(getFullName(person));

//CLASSES: inheritance

class Manager extends Employee{
constructor(mangerName:string){
    super("Test2 Emp","321JH");
    }
    delegateWork(){
        console.log('Delegates works');
    }
}
let m1=new Manager("Bruce");
m1.greet();

let tuple:[String,number]=["Emp1",100];
//console.log(tuple[1]);
let d = [0, 1, null];
//console.log(typeof(d));
