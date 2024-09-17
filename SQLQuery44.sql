-- Example: Insert orders for existing customers
INSERT INTO [dbo].[Orders] ([Customer_ID], [Item], [Quantity], [Total])
VALUES
    (1, 'Honey', 2, 23.98),          -- Assuming Customer_ID 1 exists
    (2, 'Bee Pollen', 1, 12.50);     -- Assuming Customer_ID 2 exists
    -- Insert 5 more orders (adjust Customer_ID, Item, Quantity, and Total as needed)
INSERT INTO [dbo].[Orders] ([Customer_ID], [Item], [Quantity], [Total])
VALUES
    (1, 'Royal Jelly', 1, 15.75),           -- Example: Assuming Customer_ID 3 exists
    (1, 'Beeswax Candles', 3, 26.97),       -- Example: Assuming Customer_ID 4 exists
    (2, 'Propolis Extract', 2, 22.60),       -- Example: Assuming Customer_ID 2 exists
    (2, 'Bee Bread', 1, 13.25),             -- Example: Assuming Customer_ID 5 exists
    (1, 'Honeycomb', 2, 29.00);             -- Example: Assuming Customer_ID 1 exists
