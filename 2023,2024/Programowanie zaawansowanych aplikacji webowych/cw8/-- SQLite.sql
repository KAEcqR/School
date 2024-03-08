-- SQLite
CREATE TABLE films (
    id INTEGER PRIMARY KEY;
    title VARCHAR(50);
    director VARCHAR(50);
    price DECIMAL(10, 2);
    description VARCHAR(50);
);

INSERT INTO films(title,director,price,description)
VALUES( "avatar","bodzio",23,"film bodzia");

