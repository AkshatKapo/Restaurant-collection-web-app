// let myString: string;
// let myNumber: number;
// let myBoolean: boolean;
// let myArray: number[];
// let myObject: { name: string, age: number };

// myString = "Hello, TypeScript!";
// myNumber = 42;
// myBoolean = true;
// myArray = [1, 2, 3];
// myObject = { name: "Alice", age: 25 };
//You can also use type inference, where TypeScript infers the type based on the assigned value:

// let myString = "Hello, TypeScript!";  // inferred as string
// let myNumber = 42;                    // inferred as number
// let myBoolean = true;                 // inferred as boolean
// let myArray = [1, 2, 3];              // inferred as number[]
// let myObject = { name: "Alice", age: 25 };  // inferred as { name: string, age: number }

// const declares a block-scoped, read-only variable. The type can also be specified:

// typescript
// Copy code
// const myString: string = "Hello, TypeScript!";
// const myNumber: number = 42;
// const myBoolean: boolean = true;
// const myArray: number[] = [1, 2, 3];
// const myObject: { name: string, age: number } = { name: "Alice", age: 25 };

// Cannot reassign myString, myNumber, myBoolean, myArray, myObject
Just like let, you can use type inference with const:

typescript
Copy code
const myString = "Hello, TypeScript!";  // inferred as string
const myNumber = 42;                    // inferred as number
const myBoolean = true;                 // inferred as boolean
const myArray = [1, 2, 3];              // inferred as number[]
const myObject = { name: "Alice", age: 25 };  // inferred as { name: string, age: number }