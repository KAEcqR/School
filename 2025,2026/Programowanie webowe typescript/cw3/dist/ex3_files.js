"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const node_fs_1 = require("node:fs");
const ex3_files_module_js_1 = require("./ex3_files_module.js");
const data = (0, node_fs_1.readFileSync)('./input.txt', 'utf-8');
const words = data.split(/\s+/);
//const words: string[] = data.split(' ');
console.log(words);
console.log(`Number of words with 3 letters: ${(0, ex3_files_module_js_1.countWords)(3, words)}`);
//# sourceMappingURL=ex3_files.js.map