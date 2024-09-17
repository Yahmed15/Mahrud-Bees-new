-- Assuming you have a Suppliers table with some Supplier_IDs already present
-- Replace the Supplier_ID values with actual values from your Suppliers table

INSERT INTO [dbo].[Products] (Name, Price, Supplier_ID) VALUES
('Honey', 9.99, 1),
('Bee Pollen', 12.50, 2),
('Royal Jelly', 15.75, 3),
('Beeswax Candles', 8.99, 1),
('Propolis Extract', 11.30, 2),
('Bee Bread', 13.25, 4),
('Beeswax Lip Balm', 4.99, 3),
('Honeycomb', 14.50, 4),
('Beeswax Wraps', 10.00, 1);
