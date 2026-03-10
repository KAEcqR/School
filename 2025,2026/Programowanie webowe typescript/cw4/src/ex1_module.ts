import { writeFileSync } from "fs";
export const hello = "Hello world";
export const saveArrayToFile = (fileName: string, data: string[]) => {
    const content = data.join("\n");
    writeFileSync(fileName, content, "utf8");
}