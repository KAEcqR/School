export const countWords = (length: number, words: string[]): number => {
    let result = 0;
    for (const word of words) {
        if (word.length === length) {
            result++;
        }
    }
    return result;
}