import { writeFileSync } from "fs";
export const hello = "Hello world";
export const saveArrayToFile = (fileName, data) => {
    const content = data.join("\n");
    writeFileSync(fileName, content, "utf8");
};
//# sourceMappingURL=ex1_module.js.map