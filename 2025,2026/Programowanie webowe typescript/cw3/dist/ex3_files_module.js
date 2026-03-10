"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.countWords = void 0;
const countWords = (length, words) => {
    let result = 0;
    for (const word of words) {
        if (word.length === length) {
            result++;
        }
    }
    return result;
};
exports.countWords = countWords;
//# sourceMappingURL=ex3_files_module.js.map