-- SQLite
CREATE TABLE Books (
    id INTEGER PRIMARY KEY,
    title TEXT NOT NULL,
    author TEXT NOT NULL,
    published_year INTEGER,
    price REAL
);
INSERT INTO Books (title, author, published_year, price) VALUES
('Quo Vadis', 'Henryk Sienkiewicz', 1896, 29.99),
('Pan Tadeusz', 'Adam Mickiewicz', 1834, 24.99),
('Lalka', 'Bolesław Prus', 1890, 34.99),
('Nad Niemnem', 'Eliza Orzeszkowa', 1888, 27.99),
('Przedwiośnie', 'Stefan Żeromski', 1925, 31.99),
('Chłopi', 'Wladyslaw Reymont', 1904, 32.99),
('Miscellanea', 'Ignacy Jan Witkiewicz', 1921, 28.99),
('Demon', 'Stanisław Wyspiański', 1903, 26.99),
('Pani Bovary', 'Gustave Flaubert', 1856, 23.99),
('1984', 'George Orwell', 1949, 25.99);