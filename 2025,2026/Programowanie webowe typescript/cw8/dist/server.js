import express from 'express';
import mysql from 'mysql2/promise';
import path from 'path';
import { fileURLToPath } from 'url';
const __dirname = path.dirname(fileURLToPath(import.meta.url));
const app = express();
app.use(express.static(path.join(__dirname, '../public')));
app.use(express.json());
app.post('/students', async (req, res) => {
    try {
        const connection = await mysql.createConnection({
            host: 'localhost',
            user: 'root',
            password: '',
            database: '4tip_students_2025_26'
        });
        const { firstname, lastname, birthDate } = req.body;
        await connection.execute('INSERT INTO students (firstname, lastname, birthDate) VALUES (?, ?, ?)', [firstname, lastname, birthDate]);
        await connection.end();
        res.json({ message: 'Uczeń dodany' });
    }
    catch (error) {
        res.status(500).json({ error: 'Błąd przy dodawaniu' });
    }
});
app.get('/students', async (req, res) => {
    try {
        const connection = await mysql.createConnection({
            host: 'localhost',
            user: 'root',
            password: '',
            database: '4tip_students_2025_26'
        });
        const [students] = await connection.execute('SELECT * FROM students');
        await connection.end();
        res.json(students);
    }
    catch (error) {
        res.status(500).json({ error: 'Błąd bazy danych' });
    }
});
app.delete('/students/:id', async (req, res) => {
    try {
        const connection = await mysql.createConnection({
            host: 'localhost',
            user: 'root',
            password: '',
            database: '4tip_students_2025_26'
        });
        await connection.execute('DELETE FROM students WHERE id = ?', [req.params.id]);
        await connection.end();
        res.json({ message: 'Uczeń usunięty' });
    }
    catch (error) {
        res.status(500).json({ error: 'Błąd przy usuwaniu' });
    }
});
app.listen(3000, () => {
    console.log(path.join(__dirname, '../public'));
    console.log('Serwer  na porcie 3000');
});
//# sourceMappingURL=server.js.map