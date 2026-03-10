import mysql from "mysql2/promise";
export const connection = await mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: '4tip_students_2025_26'
});
//# sourceMappingURL=db.js.map