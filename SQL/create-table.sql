CREATE TABLE "Products" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	"Brand"	TEXT,
	"Type"	INTEGER,
	"Price"	INTEGER,
	"Update"	DATE,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

CREATE TABLE "Market" (
	"Id"		INTEGER NOT NULL,
	"Address"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

CREATE TABLE "Stock" (
	"IdProduct"		INTEGER NOT NULL,
	"IdMarket"		INTEGER NOT NULL,
	"Amount"		INTEGER NOT NULL,
);

	INSERT into Products (name,Brand,Type, Price) values ("Coca Cola", "Coca Cola", 1, 100);
	INSERT into Products (name,Brand,Type, Price) values ("Cookies", "Oreon", 2, 80.5);
END;
/

