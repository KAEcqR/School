import { readFileSync, writeFileSync } from "node:fs";
import { countWords } from "./ex3_files_module.js";
const data: string = readFileSync('./input.txt', 'utf-8');
const words: string[] = data.split(/\s+/);
//const words: string[] = data.split(' ');
console.log(words);
console.log(`Number of words with 3 letters: ${countWords(3, words)}`);