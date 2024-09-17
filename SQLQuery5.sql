-- Create Bees table
CREATE TABLE Bees (
    Bee_ID INT PRIMARY KEY,
    Type VARCHAR(50),
    Age INT,
    Color VARCHAR(50)
)
-- Create Queens table
CREATE TABLE Queens (
    Queen_ID INT PRIMARY KEY,
    Bee_ID INT,
    Fertility_Status VARCHAR(50),
    FOREIGN KEY (Bee_ID) REFERENCES Bees(Bee_ID)
);
-- Create Payments table
CREATE TABLE Payments (
    Payment_ID INT PRIMARY KEY,
    Order_ID INT,
    Payment_Date DATETIME,
    Amount DECIMAL(10, 2),
    FOREIGN KEY (Order_ID) REFERENCES Orders(Order_ID)
);