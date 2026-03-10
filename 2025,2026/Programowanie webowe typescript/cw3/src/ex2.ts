import { texts, Add } from "./ex2_module.js";
import { person } from "./ex2_module2.js";

for (const text of texts) {
    console.log(text);
}

const sum = Add(5, 10);
console.log(`Sum: ${sum}`);
console.log(person);