CREATE DATABASE Hotel_Management_System;
go
USE Hotel_Management_System
go

CREATE TABLE User_Table
(
	User_ID INT IDENTITY(1,1) NOT NULL,
	User_Name NVARCHAR (100) NOT NULL,
	User_Password Varchar(100) UNIQUE not null,
	CONSTRAINT User_Table_User_ID_PK PRIMARY KEY(User_ID)
);

CREATE TABLE Client_Table
(
	Client_ID INT IDENTITY(1,1) NOT NULL,
	Client_FirstName NVARCHAR(100) NOT NULL,
	Client_LastName NVARCHAR(100) NOT NULL,
	Client_Phone VARCHAR(11) UNIQUE NOT NULL,
	Client_Address VARCHAR(100) NOT NULL,
	CONSTRAINT Client_Table_Client_ID_PK PRIMARY KEY(Client_ID)
);
CREATE TABLE Room_Table
(
	Room_Number INT IDENTITY(1,1) NOT NULL,
	Room_Type VARCHAR(6) NOT NULL,
	Room_Phone VARCHAR(15) UNIQUE NOT NULL,
	Room_Available VARCHAR(3) NOT NULL,
	Price Decimal(10,2) NOT NULL,
	CONSTRAINT Room_Table_Room_ID_PK PRIMARY KEY(Room_Number)
);

CREATE TABLE Reservation_Table
(
	Reservation_ID INT IDENTITY(1,1) NOT NULL,
	Reservation_Room_Type VARCHAR(30) NOT NULL,
	Reservation_Room_Number INT NOT NULL,
	Reservation_Client_ID INT NOT NULL,
	Reservation_In DATE NOT NULL,
	Reservation_Out DATE NOT NULL,
	CONSTRAINT Reservation_Table_Reservation_ID_PK PRIMARY KEY(Reservation_ID),
	CONSTRAINT FK_Reservation_Client FOREIGN KEY (Reservation_Client_ID) REFERENCES Client_Table(Client_ID)
);
CREATE TABLE CheckOut (
    CheckOut_ID INT PRIMARY KEY identity(1,1),
    Reservation_ID INT,  -- Khóa ngoại liên kết với bảng Reservation
    Total_Price DECIMAL(10, 2),
    CheckOut_Status NVARCHAR(20),
    FOREIGN KEY (Reservation_ID) REFERENCES Reservation_Table (Reservation_ID)
);
INSERT INTO User_Table 
VALUES ('Thorra','1211'), ('Trknghi','123321'),('Admin','123');
INSERT INTO Client_Table (Client_FirstName, Client_LastName, Client_Phone, Client_Address)
VALUES
('John', 'Doe', '12345678901', '123 Main St'),
('Jane', 'Smith', '98765432101', '456 Elm St'),
('Alice', 'Johnson', '11223344556', '789 Oak St'),
('Bob', 'Williams', '22334455667', '101 Pine St'),
('Charlie', 'Brown', '33445566778', '202 Maple St'),
('David', 'Davis', '44556677889', '303 Oak St'),
('Eva', 'Miller', '55667788990', '404 Birch St'),
('Frank', 'Wilson', '66778899001', '505 Cedar St'),
('Grace', 'Moore', '77889900112', '606 Walnut St'),
('Henry', 'Taylor', '88990011223', '707 Ash St'),
('Isabel', 'Anderson', '99001122334', '808 Redwood St'),
('Jack', 'Thomas', '10012233445', '909 Willow St'),
('Karen', 'Jackson', '21123344556', '1010 Pinewood St'),
('Leo', 'White', '32234455667', '1111 Birchwood St'),
('Mona', 'Harris', '43345566778', '1212 Cedarwood St'),
('Nina', 'Martin', '54456677889', '1313 Oakwood St'),
('Oscar', 'Garcia', '65567788990', '1414 Maplewood St'),
('Paul', 'Rodriguez', '76678899001', '1515 Elmwood St'),
('Quinn', 'Martinez', '87789900112', '1616 Birchwood St'),
('Rita', 'Lopez', '98890011223', '1717 Cedarwood St'),
('Sam', 'Gonzalez', '10001122334', '1818 Willowwood St'),
('Tina', 'Perez', '21112233445', '1919 Redwoodwood St'),
('Ursula', 'Lee', '32223344556', '2020 Pinewood St'),
('Victor', 'King', '43334455667', '2121 Ashwood St'),
('Wendy', 'Scott', '54445566778', '2222 Maplewood St'),
('Xander', 'Adams', '65556677889', '2323 Birchwood St'),
('Yvonne', 'Baker', '76667788990', '2424 Cedarwood St'),
('Zack', 'Carter', '87778899001', '2525 Oakwood St'),
('Amelia', 'Nelson', '98889900112', '2626 Pine St'),
('Benjamin', 'Young', '10090011223', '2727 Maple St'),
('Catherine', 'Hill', '21101122334', '2828 Birch St'),
('Daniel', 'Green', '32212233445', '2929 Cedar St'),
('Emily', 'Adams', '43323344556', '3030 Redwood St'),
('Felix', 'Baker', '54434455667', '3131 Ash St'),
('Gina', 'Nelson', '65545566778', '3232 Oak St'),
('Hannah', 'King', '76656677889', '3333 Maple St'),
('Ian', 'Scott', '87767788990', '3434 Birch St'),
('Jasmine', 'Carter', '98878899001', '3535 Cedar St'),
('Kenny', 'Lopez', '10089900112', '3636 Pine St'),
('Lily', 'Gonzalez', '21190011223', '3737 Willow St'),
('Matthew', 'Rodriguez', '32201122334', '3838 Redwood St'),
('Nancy', 'Perez', '43312233445', '3939 Ashwood St'),
('Olivia', 'Harris', '54423344556', '4040 Oakwood St'),
('Paul', 'Miller', '65534455667', '4141 Maplewood St'),
('Quincy', 'Martinez', '76645566778', '4242 Birchwood St');

INSERT INTO Room_Table (Room_Type, Room_Phone, Room_Available, Price)
VALUES
('Suite', '0355123001', 'Yes', 250.00),
('Family', '0355123002', 'Yes', 300.00),
('Single', '0355123003', 'Yes', 100.00),
('Double', '0355123004', 'Yes', 150.00),
('Suite', '0355123005', 'Yes', 250.00),
('Family', '0355123006', 'Yes', 300.00),
('Single', '0355123007', 'Yes', 100.00),
('Double', '0355123008', 'Yes', 150.00),
('Suite', '0355123009', 'Yes', 250.00),
('Family', '0355123010', 'Yes', 300.00),
('Single', '0355123011', 'Yes', 100.00),
('Double', '0355123012', 'Yes', 150.00),
('Suite', '0355123013', 'Yes', 250.00),
('Family', '0355123014', 'Yes', 300.00),
('Single', '0355123015', 'Yes', 100.00),
('Double', '0355123016', 'Yes', 150.00),
('Suite', '0355123017', 'Yes', 250.00),
('Family', '0355123018', 'Yes', 300.00),
('Single', '0355123019', 'Yes', 100.00),
('Double', '0355123020', 'Yes', 150.00),
('Suite', '0355123021', 'Yes', 250.00),
('Family', '0355123022', 'Yes', 300.00),
('Single', '0355123023', 'Yes', 100.00),
('Double', '0355123024', 'Yes', 150.00),
('Suite', '0355123025', 'Yes', 250.00),
('Family', '0355123026', 'Yes', 300.00),
('Single', '0355123027', 'Yes', 100.00),
('Double', '0355123028', 'Yes', 150.00),
('Suite', '0355123029', 'Yes', 250.00),
('Family', '0355123030', 'Yes', 300.00),
('Single', '0355123031', 'Yes', 100.00),
('Double', '0355123032', 'Yes', 150.00),
('Suite', '0355123033', 'Yes', 250.00),
('Family', '0355123034', 'Yes', 300.00),
('Single', '0355123035', 'Yes', 100.00),
('Double', '0355123036', 'Yes', 150.00),
('Suite', '0355123037', 'Yes', 250.00),
('Family', '0355123038', 'Yes', 300.00),
('Single', '0355123039', 'Yes', 100.00),
('Double', '0355123040', 'Yes', 150.00),
('Suite', '0355123041', 'Yes', 250.00),
('Family', '0355123042', 'Yes', 300.00),
('Single', '0355123043', 'Yes', 100.00),
('Double', '0355123044', 'Yes', 150.00),
('Suite', '0355123045', 'Yes', 250.00),
('Family', '0355123046', 'Yes', 300.00),
('Single', '0355123047', 'Yes', 100.00),
('Double', '0355123048', 'Yes', 150.00),
('Suite', '0355123049', 'Yes', 250.00),
('Family', '0355123050', 'Yes', 300.00);

