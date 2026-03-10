export type Book = {
    id: number;
    title: string;
    author: string;
    publishedYear: number;
}
export const books: Book[] = [
    {
        id: 1, title: "1984", author: "George Orwell",
        publishedYear: 1949
    },
    {
        id: 2, title: "To Kill a Mockingbird", author: "Harper Lee",
        publishedYear: 1960
    },
    {
        id: 3, title: "The Great Gatsby", author: "F. Scott Fitzgerald",
        publishedYear: 1925
    },
    {
        id: 4, title: "Moby Dick", author: "Herman Melville",
        publishedYear: 1851
    },
    {
        id: 5, title: "Pride and Prejudice", author: "Jane Austen",
        publishedYear: 1813
    },
];