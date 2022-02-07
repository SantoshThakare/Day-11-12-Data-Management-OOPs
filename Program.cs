// See https://aka.ms/new-console-template for more information
using Inventory_file;

Console.WriteLine("Hello, World!");


InventoryManagement inventory = new InventoryManagement();
inventory.ReadData(@"E:\VSCode\BasicProgram\JsonFile\Inventory.json");
    Console.ReadKey();