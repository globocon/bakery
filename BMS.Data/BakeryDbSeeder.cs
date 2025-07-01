using BMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data
{
    public static class BakeryDbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PreparationTeam>().HasData(
                new PreparationTeam { TeamId = 1, TeamName = "Fast Food Team" },
                new PreparationTeam { TeamId = 2, TeamName = "Nadan Items Team" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Puffs_Sweetna", TeamId = 1 },
                new Category { CategoryId = 2, Name = "Bread_Bun", TeamId = 1 },
                new Category { CategoryId = 3, Name = "Fruit_ButterBread_Donut", TeamId = 1 },
                new Category { CategoryId = 4, Name = "Tea_Cake", TeamId = 1 },
                new Category { CategoryId = 5, Name = "Plum_Cake", TeamId = 1 },
                new Category { CategoryId = 6, Name = "Pineapple_Cake", TeamId = 1 },
                new Category { CategoryId = 7, Name = "Carrot_Dates_Cake", TeamId = 1 },
                new Category { CategoryId = 8, Name = "Spunge_Cake", TeamId = 1 },
                new Category { CategoryId = 9, Name = "Cream", TeamId = 1 },
                new Category { CategoryId = 10, Name = "Black_Forest", TeamId = 1 },
                new Category { CategoryId = 11, Name = "White_Forest", TeamId = 1 },
                new Category { CategoryId = 12, Name = "Red_Velvet", TeamId = 1 },
                new Category { CategoryId = 13, Name = "Ghee_Cake", TeamId = 1 },
                new Category { CategoryId = 14, Name = "Sandwitch_Pizza", TeamId = 1 },
                new Category { CategoryId = 15, Name = "Tea_Rusk", TeamId = 1 },
                new Category { CategoryId = 16, Name = "White_Rusk", TeamId = 1 },
                new Category { CategoryId = 17, Name = "Beans_Biscuit", TeamId = 1 },
                new Category { CategoryId = 18, Name = "Pineapple_Cookies", TeamId = 1 },
                new Category { CategoryId = 19, Name = "Orange_Cookies", TeamId = 1 },
                new Category { CategoryId = 20, Name = "Strawberry_Cookies", TeamId = 1 },
                new Category { CategoryId = 21, Name = "Pista_Cookies", TeamId = 1 },
                new Category { CategoryId = 22, Name = "Semia_Cookies", TeamId = 1 },
                new Category { CategoryId = 23, Name = "Coconut_Cookies", TeamId = 1 },
                new Category { CategoryId = 24, Name = "Masala_Cookies", TeamId = 1 },
                new Category { CategoryId = 25, Name = "Muffins", TeamId = 1 },
                new Category { CategoryId = 26, Name = "Choc Muffin", TeamId = 1 },
                new Category { CategoryId = 27, Name = "Cherry Cake", TeamId = 1 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Chocolate Cake", CategoryId = 1, MRP = 450 },
                new Product { ProductId = 2, Name = "Baguette", CategoryId = 2, MRP = 120 }
            );

            modelBuilder.Entity<RawMaterial>().HasData(
                new RawMaterial { RawMaterialId = 1, Name = "Maida", StockQuantity = 295.9f, CP = 36m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 2, Name = "Sugar", StockQuantity = 75.7f, CP = 39m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 3, Name = "Salt", StockQuantity = 100f, CP = 9m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 4, Name = "Milk Powder", StockQuantity = 0.88f, CP = 315m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 5, Name = "Vanila Powder", StockQuantity = 1.9f, CP = 312m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 6, Name = "Egg", StockQuantity = 699f, CP = 5m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 7, Name = "RKG", StockQuantity = 2.79f, CP = 550m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 8, Name = "Custard Powder", StockQuantity = 0.55f, CP = 85m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 9, Name = "Milkmaid", StockQuantity = 6.76f, CP = 256m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 10, Name = "Nuts", StockQuantity = 1.05f, CP = 500m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 11, Name = "Coconut Powder", StockQuantity = 2.645f, CP = 210m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 12, Name = "Butter", StockQuantity = 1.89f, CP = 465m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 13, Name = "Bread Improver", StockQuantity = 0.75f, CP = 190m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 14, Name = "Baking Powder", StockQuantity = 0.95f, CP = 85m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 15, Name = "Yeast", StockQuantity = 1.96f, CP = 145m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 16, Name = "Sunflower Oil", StockQuantity = 4.55f, CP = 155m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 17, Name = "Coconut Oil", StockQuantity = 1.84f, CP = 185m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 18, Name = "Icing Sugar", StockQuantity = 10f, CP = 70m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 19, Name = "Cardamom", StockQuantity = 0.24f, CP = 1320m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 20, Name = "Atta", StockQuantity = 1.36f, CP = 60m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 21, Name = "Aval", StockQuantity = 6.96f, CP = 45m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 22, Name = "Lilly - Puffs", StockQuantity = 19.7f, CP = 159m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 23, Name = "Sheel - Bread", StockQuantity = 8.09f, CP = 148m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 24, Name = "Biskin - Cookies", StockQuantity = 10f, CP = 163m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 25, Name = "SSM - Cream", StockQuantity = 19.7f, CP = 170m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 26, Name = "USM - Cake", StockQuantity = 9.83f, CP = 168m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 27, Name = "Dark Chocolate", StockQuantity = 0.88f, CP = 260m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 28, Name = "WhiteChocolate", StockQuantity = 0.56f, CP = 364m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 29, Name = "Garam Masala", StockQuantity = 0.15f, CP = 500m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 30, Name = "Ginger Powder", StockQuantity = 100f, CP = 240m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 31, Name = "Jeerakam", StockQuantity = 0.565f, CP = 180m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 32, Name = "Sadu Jeerakam", StockQuantity = 100f, CP = 190m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 33, Name = "Soda Powder", StockQuantity = 0.305f, CP = 50m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 34, Name = "Gel", StockQuantity = 0.15f, CP = 220m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 35, Name = "Jam Mixed", StockQuantity = 3.74f, CP = 75m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 36, Name = "Jam Pineapple", StockQuantity = 4.4f, CP = 75m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 37, Name = "Liquid Glucose", StockQuantity = 1.06f, CP = 85m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 38, Name = "Jue Colour", StockQuantity = 0.445f, CP = 110m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 39, Name = "Coco Powder", StockQuantity = 100f, CP = 360m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 40, Name = "Calcium", StockQuantity = 0.385f, CP = 250m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 41, Name = "Jelly White", StockQuantity = 0.04f, CP = 180m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 42, Name = "Jelly Black", StockQuantity = 0.095f, CP = 185m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 43, Name = "Palm Oil", StockQuantity = 100f, CP = 129m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 44, Name = "Sarkara", StockQuantity = 23f, CP = 51m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 45, Name = "Cut Dates", StockQuantity = 6.6f, CP = 105m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 46, Name = "Candy Peel", StockQuantity = 100f, CP = 110m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 47, Name = "Ginger Peel", StockQuantity = 100f, CP = 260m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 48, Name = "Orange", StockQuantity = 100f, CP = 39m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 49, Name = "Makkiri", StockQuantity = 100f, CP = 100m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 50, Name = "Naranga/Lemon", StockQuantity = 100f, CP = 100m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 51, Name = "Tuty", StockQuantity = 2.4f, CP = 56m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 52, Name = "Cherry", StockQuantity = 1.46f, CP = 220m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 53, Name = "Kismiss", StockQuantity = 300f, CP = 138m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 54, Name = "Pineapple cutting", StockQuantity = 1.09f, CP = 175m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 55, Name = "Black Forest Powder", StockQuantity = 7f, CP = 120m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 56, Name = "White Forest Powder", StockQuantity = 3.36f, CP = 102m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 57, Name = "Red Velvet", StockQuantity = 5.4f, CP = 210m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 58, Name = "Vanila", StockQuantity = 20f, CP = 420m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 59, Name = "Orange", StockQuantity = 20f, CP = 480m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 60, Name = "Pineapple", StockQuantity = 20f, CP = 431m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 61, Name = "Ice Cream", StockQuantity = 20f, CP = 400m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 62, Name = "Lemon", StockQuantity = 20f, CP = 356m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 63, Name = "Rum", StockQuantity = 20f, CP = 440m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 64, Name = "Almond", StockQuantity = 20f, CP = 300m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 65, Name = "Plum", StockQuantity = 20f, CP = 1360m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 66, Name = "Butter", StockQuantity = 20f, CP = 220m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 67, Name = "Banana", StockQuantity = 20f, CP = 500m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 68, Name = "Water", StockQuantity = 20f, CP = 2m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 69, Name = "Pista Nuts", StockQuantity = 20f, CP = 5m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 70, Name = "Muffin Mix Vanila", StockQuantity = 20f, CP = 200m, Unit = "kg" },
                new RawMaterial { RawMaterialId = 71, Name = "Muffin Mix Choc", StockQuantity = 20f, CP = 250m, Unit = "kg" }
            );

            modelBuilder.Entity<ProductRawMaterial>().HasData(
                new ProductRawMaterial { Id = 1, ProductId = 1, RawMaterialId = 1, QuantityRequired = 0.5f },
                new ProductRawMaterial { Id = 2, ProductId = 1, RawMaterialId = 2, QuantityRequired = 0.3f },
                new ProductRawMaterial { Id = 3, ProductId = 2, RawMaterialId = 1, QuantityRequired = 0.7f }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Name = "John Doe", Phone = "1234567890", Email = "john@example.com", Address = "123 Main Street", GSTNo = "GST12345" }
            );

        }
    }
}
