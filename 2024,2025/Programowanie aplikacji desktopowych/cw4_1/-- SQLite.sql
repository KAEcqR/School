-- SQLite
-- SQLite
CREATE TABLE gift (
    Id INTEGER PRIMARY KEY,
    Name TEXT,
    From_sb TEXT ,
    For_sb TEXT ,
    Price INT ,
    Packaging TEXT 
);

INSERT INTO gift (Name, From_sb, For_sb, Price, Packaging) VALUES  
('Lego', 'Tata', 'Brat', 10, 'Papier_ozdobny'),  
('Autko', 'Siostra', 'Kuzyn', 15, 'Pudelko'),  
('Kawa', 'Babcia', 'Ciocia', 20, 'Torebka'),
('Slodycze', 'Brat', 'Siostra', 25, 'Torebka');

drop table gift;

delete from gift;