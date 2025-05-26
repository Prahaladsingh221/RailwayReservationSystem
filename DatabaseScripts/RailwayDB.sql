USE RailwayDB;
CREATE TABLE users (
    [UserID] INT PRIMARY KEY,                
    [Username] VARCHAR(50),                       
    [Password] VARCHAR(255));

INSERT INTO Users (UserID,Username,Password )
VALUES 
(101,'admin_user', 'password123'),
(102,'john_doe','password456'),
(103,'akshay_prap', 'password221'),
(104,'arpita_gt','password546');
select * from Users;
CREATE TABLE Stations (
StationID INT IDENTITY(1,1) PRIMARY KEY,        
    StationName VARCHAR(100),              
    Location VARCHAR(255)                 
);

INSERT INTO Stations (StationID ,StationName, Location)
VALUES 
(01,'Central Station', 'City A'),
(02,'West End Station', 'City B'),
(03,'East Gate Station', 'City C'),
(04,'Mountain View Station', 'City D'),
(05,'Riverdale Station', 'City E'),
(06,'Sunset Park Station', 'City F');
select * from Stations;
drop table Stations;
CREATE TABLE Stations (
StationID INT IDENTITY(1,1) PRIMARY KEY,        
    StationName VARCHAR(100),              
    Location VARCHAR(255)                 
);

INSERT INTO Stations (StationName, Location)
VALUES 
('Central Station', 'City A'),
('West End Station', 'City B'),
('East Gate Station', 'City C'),
('Mountain View Station', 'City D'),
('Riverdale Station', 'City E'),
('Sunset Park Station', 'City F');
select * from Stations;
CREATE TABLE Trains (
    TrainID INT  IDENTITY(1,1) PRIMARY KEY,         
    TrainName VARCHAR(100),
	SourceStationID INT,
    DestinationStationID INT,                        
    DepartureTime DATETIME,                
    ArrivalTime DATETIME,                   
    FOREIGN KEY (SourceStationID) REFERENCES Stations(StationID),   
    FOREIGN KEY (DestinationStationID) REFERENCES Stations(StationID) 
);
INSERT INTO Trains (TrainName, SourceStationID, DestinationStationID, DepartureTime, ArrivalTime)
VALUES
('hampi express', 01, 02, '2025-03-30 08:00:00', '2025-03-30 10:30:00'),
('yeshventpur express', 02, 03, '2025-03-30 12:00:00', '2025-03-30 14:30:00');
select * from Trains;
INSERT INTO Trains (TrainName, SourceStationID, DestinationStationID, DepartureTime, ArrivalTime)
VALUES 
('Express A', 1, 2, '08:00:00', '14:00:00'),
('Express B', 2, 3, '10:30:00', '18:45:00'),
('Express C', 3, 4, '06:15:00', '12:30:00'),
('Express D', 4, 5, '09:45:00', '16:00:00'),
('Express E', 5, 6, '07:00:00', '13:15:00');

CREATE TABLE ViewSchedule (
    ScheduleID INT IDENTITY(1,1) PRIMARY KEY,
    TrainID INT FOREIGN KEY REFERENCES Trains(TrainID),
    DepartureDate DATETIME,
    ArrivalDate DATETIME
);
INSERT INTO ViewSchedule (TrainID, DepartureDate, ArrivalDate)
VALUES 
(11, '2025-04-04 08:00:00', '2025-04-04 14:00:00'),
(22, '2025-04-05 10:30:00', '2025-04-05 18:45:00'),
(33, '2025-04-06 06:15:00', '2025-04-06 12:30:00'),
(44, '2025-04-07 09:45:00', '2025-04-07 16:00:00'),
(55, '2025-04-08 07:00:00', '2025-04-08 13:15:00');
SET IDENTITY_INSERT Trains ON;
INSERT INTO Trains (TrainID, TrainName, SourceStationID, DestinationStationID, DepartureTime, ArrivalTime)
VALUES 
(11, 'Express A', 1, 2, '08:00:00', '14:00:00'),
(22, 'Express B', 2, 3, '10:30:00', '18:45:00'),
(33, 'Express C', 3, 4, '06:15:00', '12:30:00'),
(44, 'Express D', 4, 5, '09:45:00', '16:00:00'),
(55, 'Express E', 5, 6, '07:00:00', '13:15:00');
SET IDENTITY_INSERT Trains OFF;

select * from ViewSchedule
use RailwayDB;
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    PassengerName NVARCHAR(100),
    TrainID INT,
    ScheduleID INT,
    BookingDate DATE,
    SeatNumber NVARCHAR(10)
);
INSERT INTO Bookings (PassengerName, TrainID, ScheduleID, BookingDate, SeatNumber)
VALUES 
('Alice Johnson', 101, 1001, '2025-04-05', 'A1'),
('Bob Smith', 102, 1002, '2025-04-06', 'B2'),
('Clara Thomas', 103, 1003, '2025-04-07', 'C3'),
('David Miller', 101, 1004, '2025-04-08', 'A2'),
('Emma Wilson', 104, 1005, '2025-04-09', 'D1');
select * from Bookings;
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Bookings';
SELECT DB_NAME() AS RailwayDB;
SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Bookings';
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    PassengerName VARCHAR(100) NOT NULL,
    TrainID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentDate DATE NOT NULL DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) NOT NULL
);
INSERT INTO Payments (PassengerName, TrainID, Amount, PaymentDate, PaymentMethod)  
VALUES  
('Alice Johnson', 101, 500.00, '2025-04-05', 'Credit Card'),  
('Bob Smith', 102, 750.00, '2025-04-06', 'Debit Card'),  
('Clara Thomas', 103, 620.00, '2025-04-07', 'UPI'),  
('David Miller', 104, 850.00, '2025-04-08', 'Cash'),  
('Emma Wilson', 105, 900.00, '2025-04-09', 'Credit Card');  
select * from Payments;
ALTER TABLE Bookings ADD Amount DECIMAL(10,2)
UPDATE Bookings SET Amount = 500.00 WHERE PassengerName = 'Alice Johnson';
UPDATE Bookings SET Amount = 750.00 WHERE PassengerName = 'Bob Smith';
UPDATE Bookings SET Amount = 620.00 WHERE PassengerName = 'Clara Thomas';
UPDATE Bookings SET Amount = 850.00 WHERE PassengerName = 'David Miller';
UPDATE Bookings SET Amount = 900.00 WHERE PassengerName = 'Emma Wilson';
UPDATE Bookings SET Amount = 920.00 WHERE PassengerName = 'sravani';
select * from Bookings;
ALTER TABLE Payments
DROP COLUMN Amount;
select * from Payments;
ALTER TABLE Payments
ADD BookingID INT;
UPDATE Payments
SET BookingID = (
    SELECT BookingID
    FROM Bookings
    WHERE Bookings.PassengerName = Payments.PassengerName
      AND Bookings.TrainID = Payments.TrainID
);
SELECT * FROM Payments;
INSERT INTO Bookings (BookingID, PassengerName, TrainID, DepartureDate, ArrivalDate)
VALUES (4, 'David Miller', 104, '2025-04-08', '2025-04-08'), 
       (5, 'Emma Wilson', 105, '2025-04-09', '2025-04-09');
	   SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Bookings';
INSERT INTO Bookings (
   INSERT INTO Bookings (
    PassengerName, TrainID, ScheduleID, SeatNumber, Amount
)
VALUES 
('David Miller', 104, 1, 'A1', 650.00),
('Emma Wilson', 105, 2, 'A2', 900.00);
select * from Bookings;
USE RailwayDB;
SELECT * FROM Payments;
select * from Bookings;
ALTER TABLE Payments
ADD Amount DECIMAL(10, 2);
SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Payments';
ALTER TABLE Payments
ADD CONSTRAINT FK_Payments_Bookings
FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID);
ALTER TABLE Payments
ADD BookingID INT;
select * from Bookings;
DELETE FROM Trains WHERE TrainName = 'TrainName'
select * from Trains;
SELECT b.BookingID, b.PassengerName, t.TrainName, s1.StationName AS Source, 
       s2.StationName AS Destination, vs.DepartureDate, vs.ArrivalDate, b.SeatNumber
FROM Bookings b
JOIN Trains t ON b.TrainID = t.TrainID
JOIN Stations s1 ON t.SourceStationID = s1.StationID
JOIN Stations s2 ON t.DestinationStationID = s2.StationID
JOIN ViewSchedule vs ON b.ScheduleID = vs.ScheduleID
SELECT * FROM Bookings;
SELECT b.BookingID, b.TrainID, t.TrainName
FROM Bookings b
LEFT JOIN Trains t ON b.TrainID = t.TrainID;
SELECT b.BookingID, b.ScheduleID, vs.DepartureDate
FROM Bookings b
LEFT JOIN ViewSchedule vs ON b.ScheduleID = vs.ScheduleID;
SELECT t.TrainID, t.TrainName, s1.StationName AS Source, s2.StationName AS Destination
FROM Trains t
LEFT JOIN Stations s1 ON t.SourceStationID = s1.StationID
LEFT JOIN Stations s2 ON t.DestinationStationID = s2.StationID;
SELECT 
    T.TrainName,
    SS.StationName AS SourceStation,
    DS.StationName AS DestinationStation,
    V.DepartureDate,
    V.ArrivalDate
FROM ViewSchedule V
JOIN Trains T ON V.TrainID = T.TrainID
JOIN Stations SS ON T.SourceStationID = SS.StationID
JOIN Stations DS ON T.DestinationStationID = DS.StationID
select * from Trains;
SELECT 
    b.BookingID,
    b.SeatNumber,
    b.PassengerName,
    b.TrainID,
    t.TrainName,
    s1.StationName AS Source,
    s2.StationName AS Destination,
    t.DepartureTime,
    t.ArrivalTime
FROM 
    Bookings b
JOIN 
    Trains t ON b.TrainID = t.TrainID
JOIN 
    Stations s1 ON t.SourceStationID = s1.StationID
JOIN 
    Stations s2 ON t.DestinationStationID = s2.StationID
WHERE 
    b.BookingID = @BookingID



























