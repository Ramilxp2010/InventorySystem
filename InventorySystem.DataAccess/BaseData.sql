INSERT INTO Providers (Name) VALUES( "Поставщик_1");
INSERT INTO Providers (Name) VALUES( "Поставщик_2");
INSERT INTO Providers (Name) VALUES( "Поставщик_3");

INSERT INTO Inventories (Number, Date) VALUES( "50001", "2020-05-01 08:23:19.120");
INSERT INTO Inventories (Number, Date) VALUES( "50002", "2020-05-02 08:23:19.120");
INSERT INTO Inventories (Number, Date) VALUES( "50003", "2020-05-03 08:23:19.120");

INSERT INTO PurchaseInvoices (Number, Date, ProviderId) VALUES( "10002", "2020-01-01 08:23:19.120", 1);
INSERT INTO PurchaseInvoices (Number, Date, ProviderId) VALUES( "10003", "2020-05-01 08:23:19.120", 2);
INSERT INTO PurchaseInvoices (Number, Date, ProviderId) VALUES( "10004", "2020-05-02 08:23:19.120", 3);
INSERT INTO PurchaseInvoices (Number, Date, ProviderId) VALUES( "10005", "2020-05-03 08:23:19.120", 1);
INSERT INTO PurchaseInvoices (Number, Date, ProviderId) VALUES( "10006", "2020-05-04 08:23:19.120", 2);

INSERT INTO Invoices (Number, Date) VALUES( "90001", "2020-05-01 08:23:19.120");
INSERT INTO Invoices (Number, Date) VALUES( "90002", "2020-05-02 08:23:19.120");
INSERT INTO Invoices (Number, Date) VALUES( "90003", "2020-05-03 08:23:19.120");
INSERT INTO Invoices (Number, Date) VALUES( "90004", "2020-05-04 08:23:19.120");
INSERT INTO Invoices (Number, Date) VALUES( "90005", "2020-05-05 08:23:19.120");

INSERT INTO Units (Name) VALUES( "ШТ");
INSERT INTO Units (Name) VALUES( "КГ");
INSERT INTO Units (Name) VALUES( "М");

INSERT INTO Products (Name, Code, UnitId) VALUES( "Product_1", "100001", 1);
INSERT INTO Products (Name, Code, UnitId) VALUES( "Product_2", "100021", 1);
INSERT INTO Products (Name, Code, UnitId) VALUES( "Product_3", "100301", 2);
INSERT INTO Products (Name, Code, UnitId) VALUES( "Product_4", "104001", 1);
INSERT INTO Products (Name, Code, UnitId) VALUES( "Product_5", "150001", 3);

INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 1, 100, 90, 1, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 2, 100, 71, 2, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 3, 100, 60, 3, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 4, 100, 74, 5, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 5, 100, 93, 5, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 1, 100, 23, NULL, 1, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 2, 100, 34, NULL, 2, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 3, 100, 54, NULL, 3, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 4, 100, 65, NULL, 5, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 5, 100, 23, NULL, 5, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 1, 100, 12, NULL, NULL, 1);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 2, 100, 54, NULL, NULL, 2);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 3, 100, 76, NULL, NULL, 3);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 1, 100, 12, 1, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 2, 100, 54, 1, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 3, 100, 23, 1, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 4, 100, 54, 1, NULL, NULL);
INSERT INTO ProductWorks (ProductId, Cost, Count, PurchaseInvoiceId, InvoiceId, InventoryId) VALUES( 5, 100, 76, 1, NULL, NULL);