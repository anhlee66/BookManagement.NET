-- Inserting sample book genres
INSERT INTO BookGenres (Name, Description) 
VALUES 
    ('Fantasy', 'Books involving magic, mythical creatures, and imaginary worlds'),
    ('Science Fiction', 'Books based on scientific speculation, often set in the future or in space'),
    ('Mystery', 'Books focusing on solving a crime or unraveling a puzzle'),
    ('Romance', 'Books centered around romantic relationships'),
    ('Thriller', 'Books with intense, suspenseful plots'),
    ('Historical Fiction', 'Fiction set in the past, often featuring historical events or figures'),
    ('Horror', 'Books designed to evoke fear, dread, or disgust'),
    ('Biography', 'Accounts of real people''s lives written by other people'),
    ('Self-Help', 'Books offering advice or guidance on personal growth or self-improvement'),
    ('Cookbook', 'Books containing recipes and cooking tips'),
    ('Poetry', 'Literary works characterized by rhythmical patterns of language'),
    ('Drama', 'Plays or scripts written for performance'),
    ('Comedy', 'Humorous works intended to entertain'),
    ('Travel', 'Books about travel experiences and destinations');

	select * from BookGenres;
-- Inserting sample publishers
INSERT INTO Publishers (Name, Contact, Description)
VALUES 
    ('Penguin Random House', 'contact@penguinrandomhouse.com', 'One of the largest book publishers'),
    ('HarperCollins', 'contact@harpercollins.com', 'Global publishing company'),
    ('Simon & Schuster', 'contact@simonandschuster.com', 'Publishing house founded in New York City'),
    ('Macmillan Publishers', 'contact@macmillan.com', 'International publishing company'),
    ('Hachette Livre', 'contact@hachette.com', 'French publishing company'),
    ('Oxford University Press', 'contact@oup.com', 'Academic publishing house'),
    ('Random House', 'contact@randomhouse.com', 'American book publishing company'),
    ('Penguin Books', 'contact@penguinbooks.com', 'British publishing house'),
    ('Vintage Books', 'contact@vintagebooks.com', 'Publisher of literary fiction and nonfiction'),
    ('Scholastic Corporation', 'contact@scholastic.com', 'American publishing company specializing in educational materials'),
    ('Houghton Mifflin Harcourt', 'contact@hmhco.com', 'Educational and trade publisher'),
    ('Little, Brown and Company', 'contact@littlebrown.com', 'American publisher specializing in fiction and nonfiction'),
    ('Bloomsbury Publishing', 'contact@bloomsbury.com', 'Independent publishing house');

-- Inserting sample authors
INSERT INTO Authors (Name, Contact, Description) 
VALUES 
    ('J.K. Rowling', 'jkrowling@gmail.com', 'Author of the Harry Potter series'),
    ('George Orwell', 'georgeorwell@hotmail.com', 'Famous for his dystopian novel "1984"'),
    ('Agatha Christie', 'agathachristie@yahoo.com', 'Renowned for her detective fiction'),
    ('Stephen King', 'stephenking@gmail.com', 'Master of horror fiction'),
    ('Maya Angelou', 'mayaangelou@hotmail.com', 'Iconic poet and civil rights activist'),
    ('William Shakespeare', 'shakespeare@yahoo.com', 'Legendary playwright and poet'),
    ('Jane Austen', 'janeausten@gmail.com', 'Classic author known for her romantic novels'),
    ('Mark Twain', 'marktwain@hotmail.com', 'Famed for "The Adventures of Huckleberry Finn"'),
    ('J.R.R. Tolkien', 'tolkien@yahoo.com', 'Creator of "The Lord of the Rings"'),
    ('Ernest Hemingway', 'ehemingway@gmail.com', 'Nobel Prize-winning author known for his concise prose'),
    ('Virginia Woolf', 'virginiawoolf@hotmail.com', 'Modernist writer and feminist icon'),
    ('Leo Tolstoy', 'tolstoy@yahoo.com', 'Russian author of "War and Peace"'),
    ('Gabriel Garcia Marquez', 'ggmarquez@gmail.com', 'Colombian author of "One Hundred Years of Solitude"'),
    ('Charles Dickens', 'cdickens@hotmail.com', 'Victorian novelist known for "Great Expectations"');

-- Inserting sample books
INSERT INTO Books (Name, Summary, Quantity, ImportPrice, BookGenreId, PublisherId)
VALUES 
    ('Harry Potter and the Philosopher''s Stone', 'Follows the life of a young wizard, Harry Potter', 100, 10.99, 1, 1),
    ('1984', 'Dystopian novel set in a totalitarian society', 50, 9.99, 2, 2),
    ('Murder on the Orient Express', 'Detective Hercule Poirot solves a murder mystery', 80, 8.99, 3, 3),
    ('The Shining', 'A family is haunted by supernatural forces at a remote hotel', 70, 12.99, 6, 4),
    ('I Know Why the Caged Bird Sings', 'Memoir of the author''s childhood and adolescence', 60, 11.99, 7, 5),
    ('Romeo and Juliet', 'Tragic love story of two young star-crossed lovers', 40, 7.99, 12, 6),
    ('Pride and Prejudice', 'Classic novel of manners in early 19th-century England', 90, 8.99, 4, 7),
    ('The Adventures of Tom Sawyer', 'The mischievous adventures of a young boy', 55, 6.99, 14, 4),
    ('The Hobbit', 'Bilbo Baggins embarks on a quest to reclaim the Lonely Mountain', 75, 10.99, 1, 3),
    ('The Old Man and the Sea', 'An old fisherman''s epic struggle with a giant marlin', 45, 9.99, 8, 2),
    ('Mrs. Dalloway', 'A day in the life of Clarissa Dalloway in post-World War I England', 65, 10.99, 11, 5),
    ('War and Peace', 'Epic novel set during the Napoleonic Wars', 85, 13.99, 10, 1),
    ('One Hundred Years of Solitude', 'Multigenerational saga of the Buendía family in Macondo', 30, 11.99, 9, 7),
    ('Great Expectations', 'Orphan Pip''s journey to becoming a gentleman', 95, 7.99, 13, 6);
		
	select * from Books;

-- Inserting authorship details
INSERT INTO Authorship (AuthorId, BookId)
VALUES 
    (1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), 
    (8, 8), (9, 9), (10, 10), (11, 11), (12, 12), (13, 13), (14, 14);

-- Inserting sample selling prices
INSERT INTO SellingPrice (BookId, Price)
VALUES 
    (1, 15.99), (2, 12.99), (3, 10.99), (4, 18.99), (5, 16.99), (6, 14.99), 
    (7, 12.99), (8, 10.99), (9, 15.99), (10, 14.99), (11, 12.99), (12, 18.99), 
    (13, 15.99), (14, 12.99);

-- Inserting sample discounts
INSERT INTO Discounts (BookId, DateOfStarting, DateOfEnding, Discount)
VALUES 
    (1, '2024-01-01', '2024-12-31', 0.1), 
    (2, '2024-01-01', '2024-12-31', 0.15), 
    (3, '2024-01-01', '2024-12-31', 0.05),
    (4, '2024-01-01', '2024-12-31', 0.2),
    (5, '2024-01-01', '2024-12-31', 0.1),
    (6, '2024-01-01', '2024-12-31', 0.15),
    (7, '2024-01-01', '2024-12-31', 0.05),
    (8, '2024-01-01', '2024-12-31', 0.2),
    (9, '2024-01-01', '2024-12-31', 0.1),
    (10, '2024-01-01', '2024-12-31', 0.15),
    (11, '2024-01-01', '2024-12-31', 0.05),
    (12, '2024-01-01', '2024-12-31', 0.2),
    (13, '2024-01-01', '2024-12-31', 0.1),
    (14, '2024-01-01', '2024-12-31', 0.15);

-- Inserting sample states (assuming initial state)
INSERT INTO States (BookId, State)
VALUES 
    (1, 'In stock'), (2, 'In stock'), (3, 'In stock'), (4, 'In stock'), 
    (5, 'In stock'), (6, 'In stock'), (7, 'In stock'), (8, 'In stock'), 
    (9, 'In stock'), (10, 'In stock'), (11, 'In stock'), (12, 'In stock'), 
    (13, 'In stock'), (14, 'In stock');

-- Inserting sample suppliers
INSERT INTO Suppliers (Name, Contact, Description)
VALUES 
    ('Book Distributors Inc.', 'info@bookdistributors.com', 'Leading distributor of books'),
    ('Global Books Supplier', 'contact@globalbooks.com', 'Supplier of books worldwide'),
    ('International Book Services', 'contact@internationalbooks.com', 'Provider of books to global markets'),
    ('Best Book Wholesalers', 'info@bestbooks.com', 'Wholesaler of best-selling books'),
    ('Worldwide Book Distributors', 'contact@worldwidedistributors.com', 'Distributor of books across continents'),
    ('Global Textbook Supplier', 'info@globaltextbooks.com', 'Supplier of academic textbooks worldwide'),
    ('Book Source Direct', 'info@booksource.com', 'Direct supplier of books to retailers');

	select * from Suppliers;
-- Inserting sample positions
INSERT INTO Positions (Name, Description)
VALUES 
    ('Manager', 'Oversees operations'),
    ('Sales Representative', 'Handles customer inquiries and sales'),
    ('Accountant', 'Manages financial transactions and records'),
    ('Marketing Specialist', 'Develops and implements marketing strategies'),
    ('Warehouse Manager', 'Oversees inventory and logistics'),
    ('Customer Service Representative', 'Assists customers with inquiries and issues'),
    ('Editor', 'Reviews and edits manuscripts for publication');

-- Inserting sample employees
INSERT INTO Employees (Name, Gender, Contact, PositionId)
VALUES 
    ('John Doe', 1, 'john.doe@example.com', 1),
    ('Jane Smith', 0, 'jane.smith@example.com', 2),
    ('Michael Johnson', 1, 'michael.johnson@example.com', 3),
    ('Emily Brown', 0, 'emily.brown@example.com', 4),
    ('David Wilson', 1, 'david.wilson@example.com', 5),
    ('Sarah Lee', 0, 'sarah.lee@example.com', 6),
    ('Daniel Clark', 1, 'daniel.clark@example.com', 7),
    ('Rachel Taylor', 0, 'rachel.taylor@example.com', 1),
    ('Christopher Evans', 1, 'christopher.evans@example.com', 2),
    ('Amanda Martinez', 0, 'amanda.martinez@example.com', 3),
    ('James Garcia', 1, 'james.garcia@example.com', 4),
    ('Jessica Hernandez', 0, 'jessica.hernandez@example.com', 5),
    ('Matthew King', 1, 'matthew.king@example.com', 6),
    ('Lauren White', 0, 'lauren.white@example.com', 7);
	select * from Employees;
-- Inserting sample computer accounts
INSERT INTO ComputerAccounts (EmployeeId, AccountName, Password, RoleId)
VALUES 
    (2, 'jane_smith', 'letmein', 2),
    (3, 'michael_johnson', 'accounting123', 1);

	select * from Employees;
	select * from roles;
INSERT INTO ComputerAccounts (EmployeeId, AccountName, Password, RoleId)
VALUES 
    (1,'anhle','123',1);

-- Inserting sample customers
INSERT INTO Customers (Name, Contact, Gender, Address)
VALUES 
    ('Olivia Thomas', 'olivia.thomas@example.com', 0, '890 Oak Street, Chicago, USA'),
    ('Noah Wilson', 'noah.wilson@example.com', 1, '567 Maple Avenue, Toronto, Canada'),
    ('Sophia Martinez', 'sophia.martinez@example.com', 0, '123 Elm Street, London, UK'),
    ('Liam Taylor', 'liam.taylor@example.com', 1, '456 Pine Avenue, Sydney, Australia'),
    ('Ava Brown', 'ava.brown@example.com', 0, '789 Cedar Road, Paris, France'),
    ('Jackson Anderson', 'jackson.anderson@example.com', 1, '234 Birch Lane, Berlin, Germany'),
    ('Olivia Hernandez', 'olivia.hernandez@example.com', 0, '567 Pine Street, Rome, Italy'),
    ('Emma Smith', 'emma.smith@example.com', 0, '890 Oak Street, Madrid, Spain'),
    ('Logan Johnson', 'logan.johnson@example.com', 1, '123 Elm Street, Tokyo, Japan'),
    ('Isabella Jones', 'isabella.jones@example.com', 0, '456 Pine Avenue, Beijing, China'),
    ('Sophia Garcia', 'sophia.garcia@example.com', 0, '789 Cedar Road, Moscow, Russia'),
    ('Mia Martinez', 'mia.martinez@example.com', 0, '234 Birch Lane, Seoul, South Korea'),
    ('Jack Johnson', 'jack.johnson@example.com', 1, '567 Pine Street, Mumbai, India'),
    ('Emily Anderson', 'emily.anderson@example.com', 0, '890 Oak Street, Rio de Janeiro, Brazil');

-- Inserting sample receipts
INSERT INTO Receipts (DateOfReceipt, SupplierId, EmployeeId, Description)
VALUES 
    ('2024-04-15', 1, 1, 'Received new book shipment'),
    ('2024-04-16', 2, 2, 'Restocked bestselling titles'),
    ('2024-04-17', 3, 3, 'Received latest releases from publisher'),
    ('2024-04-18', 4, 4, 'Restocked high-demand books'),
    ('2024-04-19', 5, 5, 'Received special edition books'),
    ('2024-04-20', 6, 6, 'Restocked academic textbooks'),
    ('2024-04-21', 7, 7, 'Received rare and collectible books');

-- Inserting sample receipt details
INSERT INTO ReceiptDetail (ReceiptId, BookId, Quantity)
VALUES 
    (1, 1, 50),
    (2, 2, 30),
    (3, 3, 40),
    (4, 4, 25),
    (5, 5, 35),
    (6, 6, 20),
    (7, 7, 15);

-- Inserting sample invoices
INSERT INTO Invoices (DateOfInvoice, CustomerId, EmployeeId)
VALUES 
    ('2024-04-15', 1, 2),
    ('2024-04-16', 2, 1),
    ('2024-04-17', 3, 3),
    ('2024-04-18', 4, 4),
    ('2024-04-19', 5, 5),
    ('2024-04-20', 6, 6),
    ('2024-04-21', 7, 7);

-- Inserting sample invoice details
INSERT INTO InvoiceDetail (InvoiceId, BookId, Quantity)
VALUES 
    (1, 1, 3),
    (2, 2, 2),
    (3, 3, 4),
    (4, 4, 5),
    (5, 5, 3),
    (6, 6, 2),
    (7, 7, 4);


