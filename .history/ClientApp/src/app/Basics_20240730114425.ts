let myString: string;
let myNumber: number;
let myBoolean: boolean;
let myArray: number[];
let myObject: { name: string, age: number };

myString = "Hello, TypeScript!";
myNumber = 42;
myBoolean = true;
myArray = [1, 2, 3];
myObject = { name: "Alice", age: 25 };
//You can also use type inference, where TypeScript infers the type based on the assigned value:

let myString = "Hello, TypeScript!";  // inferred as string
let myNumber = 42;                    // inferred as number
let myBoolean = true;                 // inferred as boolean
let myArray = [1, 2, 3];              // inferred as number[]
let myObject = { name: "Alice", age: 25 };  // inferred as { name: string, age: number }