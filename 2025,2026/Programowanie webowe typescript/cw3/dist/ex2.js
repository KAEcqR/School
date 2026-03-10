"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const ex2_modul_js_1 = require("./ex2_modul.js");
const ex2_module2_js_1 = require("./ex2_module2.js");
for (const text of ex2_modul_js_1.texts) {
    console.log(text);
}
const sum = (0, ex2_modul_js_1.Add)(5, 10);
console.log(`Sum: ${sum}`);
console.log(ex2_module2_js_1.person);
//# sourceMappingURL=ex2.js.map