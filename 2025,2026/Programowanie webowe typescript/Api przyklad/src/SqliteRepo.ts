import {open, Database} from 'sqlite';
import sqlite3 from 'sqlite3';
import path from 'node:path';
import { fileURLToPath } from 'node:url';  
//typ do ksiazki 
export type Book = {
    id: number;
    title: string;
    author: string;
    published_year: number;
    price: number;
}
//plik bazy danych
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);
const dbPath = path.join(__dirname, '..', 'app.db');
console.log('Database path:', dbPath);

let db: Database | null = null;
//funkcja do polaczenia z baza danych
export async function getDbConnection(): Promise<Database> {
    if(db) return db;

    db = await open({
        filename: dbPath,
        driver: sqlite3.Database
    });
    return db;  
}
//zamykanie polaczenia z baza danych
export async function closeDbConnection(): Promise<void> {
    if(db) {
        await db.close();
        db = null;
    }
}
//pobranie wszystkich ksiazek
export async function getAllBooks(): Promise<Book[]> {
    const db = await getDbConnection();    
    const books = await db.all<Book[]>('SELECT * FROM books');
    await closeDbConnection();
    return books;   
}