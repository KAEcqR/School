import { getAllBooks } from "./SqliteRepo.js";

async function testGetAllBooks() {
    let books = await getAllBooks();
    console.log("Books in database:", books);
}
testGetAllBooks();