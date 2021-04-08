CREATE TABLE "Products" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	"Brand"	TEXT,
	"Type"	INTEGER,
	"Price"	INTEGER,
	"Update"	DATE,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

INSERT into Products (name,Brand,Type, Price) values ("Coca Cola", "Coca Cola", 1, 100);
INSERT into Products (name,Brand,Type, Price) values ("Cookies", "Oreon", 2, 80.5);

