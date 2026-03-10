export type Student = {
    id: number;
    firstname: string;
    lastname: string;
    age: number;
};
export const students: Student[] = [
    { id: 1, firstname: "John", lastname: "Doe", age: 20 },
    { id: 2, firstname: "Jane", lastname: "Smith", age: 22 },
    { id: 3, firstname: "Jim", lastname: "Brown", age: 19 }
];
