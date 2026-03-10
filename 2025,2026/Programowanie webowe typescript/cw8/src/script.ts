import readline from "readline/promises";
import mysql from "mysql2/promise";
// const rl = readline.createInterface({
//     input: process.stdin,
//     output: process.stdout,
// });

const connection = await mysql.createConnection(
    {
        host: 'localhost',
        user: 'root',
        password: '',
        database: '4tip_students_2025_26'
    }
);
const resultTest = await connection.execute('SELECT 1+1 AS solution');
const [result2, fields] = await connection.execute('SELECT * FROM students');
console.log(`Odpowiedz bazy danych: `, resultTest);
console.log(`Wszyscy uczniowie: `, result2);
await connection.end();
console.log("Połączenie zakończone.");

