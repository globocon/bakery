using BMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BMS.Data
{
    public static class BakeryDbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var CurrentTime = new DateTime(2025, 7, 2, 5, 47, 50, 922, DateTimeKind.Utc).AddTicks(9602);
            var UserId = "Initial Creation"; //"8f3c9d8e-1234-4bcd-a456-7890abcdef12"; // Default admin user ID

            modelBuilder.Entity<PreparationTeam>().HasData(
                new PreparationTeam { Id = 1, TeamName = "Fast Food Team", CreatedById = UserId, CreatedOn = CurrentTime },
                new PreparationTeam { Id = 2, TeamName = "Nadan Items Team", CreatedById = UserId, CreatedOn = CurrentTime }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Name = "Hotel Margretta", Phone = "1234567890", Email = null, Address = "123 Main Street", GSTNo = "32GST1AC23452Z2", CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 2, Name = "Moon Bakery", Phone = null, Email = null, Address = "CC Road", GSTNo = "32GSE2AC23462Z2", CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 3, Name = "Best Bakery", Phone = null, Email = null, Address = "45 Second Street", GSTNo = null, CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 4, Name = "Hotel Grand", Phone = null, Email = null, Address = "Grand Street", GSTNo = null, CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 5, Name = "Roastown Grill", Phone = null, Email = null, Address = "Roastown Street", GSTNo = null, CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 6, Name = "Fort Paragon", Phone = null, Email = null, Address = "Paragon Main Street", GSTNo = null, CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 7, Name = "Ginger House", Phone = null, Email = null, Address = "123 House Street", GSTNo = null, CreatedById = UserId, CreatedOn = CurrentTime },
                new Customer { CustomerId = 8, Name = "Rasoi Fort Kochi", Phone = null, Email = null, Address = "Fort Kochi", GSTNo = null, CreatedById = UserId, CreatedOn = CurrentTime }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Puffs_Sweetna", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 2, Name = "Bread_Bun", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 3, Name = "Fruit_ButterBread_Donut", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 4, Name = "Tea_Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 5, Name = "Plum_Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 6, Name = "Pineapple_Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 7, Name = "Carrot_Dates_Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 8, Name = "Spunge_Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 9, Name = "Cream", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 10, Name = "Black_Forest", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 11, Name = "White_Forest", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 12, Name = "Red_Velvet", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 13, Name = "Ghee_Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 14, Name = "Sandwitch_Pizza", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 15, Name = "Tea_Rusk", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 16, Name = "White_Rusk", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 17, Name = "Beans_Biscuit", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 18, Name = "Pineapple_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 19, Name = "Orange_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 20, Name = "Strawberry_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 21, Name = "Pista_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 22, Name = "Semia_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 23, Name = "Coconut_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 24, Name = "Masala_Cookies", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 25, Name = "Muffins", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 26, Name = "Choc Muffin", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 27, Name = "Cherry Cake", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime },
                new Category { Id = 28, Name = "Samosa", PreparationTeamId = 1, CreatedById = UserId, CreatedOn = CurrentTime }
            );

            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = 1, CategoryId = 1, Name = "PUFFS", CreatedById = UserId, CreatedOn = CurrentTime },
                new SubCategory { Id = 2, CategoryId = 4, Name = "TEA CAKE", CreatedById = UserId, CreatedOn = CurrentTime },
                new SubCategory { Id = 3, CategoryId = 14, Name = "SANDWICH", CreatedById = UserId, CreatedOn = CurrentTime },
                new SubCategory { Id = 4, CategoryId = 27, Name = "SAMOSA", CreatedById = UserId, CreatedOn = CurrentTime }
            );

            modelBuilder.Entity<RawMaterial>().HasData(
                 new RawMaterial { RawMaterialId = 1, Name = "Maida", StockQuantity = 295.9f, CP = 36m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 2, Name = "Sugar", StockQuantity = 75.7f, CP = 39m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 3, Name = "Salt", StockQuantity = 100f, CP = 9m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 4, Name = "Milk Powder", StockQuantity = 0.88f, CP = 315m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 5, Name = "Vanila Powder", StockQuantity = 1.9f, CP = 312m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 6, Name = "Egg", StockQuantity = 699f, CP = 5m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 7, Name = "RKG", StockQuantity = 2.79f, CP = 550m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 8, Name = "Custard Powder", StockQuantity = 0.55f, CP = 85m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 9, Name = "Milkmaid", StockQuantity = 6.76f, CP = 256m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 10, Name = "Nuts", StockQuantity = 1.05f, CP = 500m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 11, Name = "Coconut Powder", StockQuantity = 2.645f, CP = 210m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 12, Name = "Butter", StockQuantity = 1.89f, CP = 465m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 13, Name = "Bread Improver", StockQuantity = 0.75f, CP = 190m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 14, Name = "Baking Powder", StockQuantity = 0.95f, CP = 85m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 15, Name = "Yeast", StockQuantity = 1.96f, CP = 145m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 16, Name = "Sunflower Oil", StockQuantity = 4.55f, CP = 155m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 17, Name = "Coconut Oil", StockQuantity = 1.84f, CP = 185m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 18, Name = "Icing Sugar", StockQuantity = 10f, CP = 70m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 19, Name = "Cardamom", StockQuantity = 0.24f, CP = 1320m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 20, Name = "Atta", StockQuantity = 1.36f, CP = 60m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 21, Name = "Aval", StockQuantity = 6.96f, CP = 45m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 22, Name = "Lilly - Puffs", StockQuantity = 19.7f, CP = 159m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 23, Name = "Sheel - Bread", StockQuantity = 8.09f, CP = 148m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 24, Name = "Biskin - Cookies", StockQuantity = 10f, CP = 163m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 25, Name = "SSM - Cream", StockQuantity = 19.7f, CP = 170m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 26, Name = "USM - Cake", StockQuantity = 9.83f, CP = 168m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 27, Name = "Dark Chocolate", StockQuantity = 0.88f, CP = 260m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 28, Name = "WhiteChocolate", StockQuantity = 0.56f, CP = 364m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 29, Name = "Garam Masala", StockQuantity = 0.15f, CP = 500m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 30, Name = "Ginger Powder", StockQuantity = 100f, CP = 240m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 31, Name = "Jeerakam", StockQuantity = 0.565f, CP = 180m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 32, Name = "Sadu Jeerakam", StockQuantity = 100f, CP = 190m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 33, Name = "Soda Powder", StockQuantity = 0.305f, CP = 50m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 34, Name = "Gel", StockQuantity = 0.15f, CP = 220m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 35, Name = "Jam Mixed", StockQuantity = 3.74f, CP = 75m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 36, Name = "Jam Pineapple", StockQuantity = 4.4f, CP = 75m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 37, Name = "Liquid Glucose", StockQuantity = 1.06f, CP = 85m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 38, Name = "Jue Colour", StockQuantity = 0.445f, CP = 110m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 39, Name = "Coco Powder", StockQuantity = 100f, CP = 360m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 40, Name = "Calcium", StockQuantity = 0.385f, CP = 250m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 41, Name = "Jelly White", StockQuantity = 0.04f, CP = 180m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 42, Name = "Jelly Black", StockQuantity = 0.095f, CP = 185m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 43, Name = "Palm Oil", StockQuantity = 100f, CP = 129m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 44, Name = "Sarkara", StockQuantity = 23f, CP = 51m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 45, Name = "Cut Dates", StockQuantity = 6.6f, CP = 105m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 46, Name = "Candy Peel", StockQuantity = 100f, CP = 110m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 47, Name = "Ginger Peel", StockQuantity = 100f, CP = 260m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 48, Name = "Orange", StockQuantity = 100f, CP = 39m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 49, Name = "Makkiri", StockQuantity = 100f, CP = 100m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 50, Name = "Naranga/Lemon", StockQuantity = 100f, CP = 100m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 51, Name = "Tuty", StockQuantity = 2.4f, CP = 56m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 52, Name = "Cherry", StockQuantity = 1.46f, CP = 220m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 53, Name = "Kismiss", StockQuantity = 300f, CP = 138m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 54, Name = "Pineapple cutting", StockQuantity = 1.09f, CP = 175m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 55, Name = "Black Forest Powder", StockQuantity = 7f, CP = 120m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 56, Name = "White Forest Powder", StockQuantity = 3.36f, CP = 102m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 57, Name = "Red Velvet", StockQuantity = 5.4f, CP = 210m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 58, Name = "Vanila", StockQuantity = 20f, CP = 420m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 59, Name = "Orange", StockQuantity = 20f, CP = 480m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 60, Name = "Pineapple", StockQuantity = 20f, CP = 431m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 61, Name = "Ice Cream", StockQuantity = 20f, CP = 400m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 62, Name = "Lemon", StockQuantity = 20f, CP = 356m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 63, Name = "Rum", StockQuantity = 20f, CP = 440m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 64, Name = "Almond", StockQuantity = 20f, CP = 300m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 65, Name = "Plum", StockQuantity = 20f, CP = 1360m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 66, Name = "Butter", StockQuantity = 20f, CP = 220m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 67, Name = "Banana", StockQuantity = 20f, CP = 500m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 68, Name = "Water", StockQuantity = 20f, CP = 2m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 69, Name = "Pista Nuts", StockQuantity = 20f, CP = 5m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 70, Name = "Muffin Mix Vanila", StockQuantity = 20f, CP = 200m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime },
                 new RawMaterial { RawMaterialId = 71, Name = "Muffin Mix Choc", StockQuantity = 20f, CP = 250m, Unit = "kg", CreatedById = UserId, CreatedOn = CurrentTime }
             );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, SubCategoryId = null, Name = "SWEETNA", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 2, CategoryId = 1, SubCategoryId = null, Name = "SWEET STICK", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 3, CategoryId = 1, SubCategoryId = null, Name = "KARI", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 4, CategoryId = 1, SubCategoryId = null, Name = "DILPASANTH", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 5, CategoryId = 1, SubCategoryId = null, Name = "CREAM CORN", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 6, CategoryId = 1, SubCategoryId = 1, Name = "Egg Puffs", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 7, CategoryId = 1, SubCategoryId = 1, Name = "Chicken Puffs", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 8, CategoryId = 1, SubCategoryId = 1, Name = "Meat Puffs", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 9, CategoryId = 1, SubCategoryId = 1, Name = "Banana Puffs", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 10, CategoryId = 1, SubCategoryId = 1, Name = "Veg Puffs", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 11, CategoryId = 1, SubCategoryId = null, Name = "Neyyappam", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 12, CategoryId = 1, SubCategoryId = null, Name = "Kubalappam", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 13, CategoryId = 1, SubCategoryId = null, Name = "Kozhakatta", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 14, CategoryId = 1, SubCategoryId = null, Name = "Elayappam", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 15, CategoryId = 1, SubCategoryId = null, Name = "Sugiyan", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 16, CategoryId = 1, SubCategoryId = null, Name = "Uzhunnuvada", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 17, CategoryId = 1, SubCategoryId = null, Name = "Parippuvada", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 18, CategoryId = 1, SubCategoryId = null, Name = "Pazhampori", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 19, CategoryId = 27, SubCategoryId = 4, Name = "Veg Samosa", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 20, CategoryId = 27, SubCategoryId = 4, Name = "Egg Samosa", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 21, CategoryId = 27, SubCategoryId = 4, Name = "Meat Samosa", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 22, CategoryId = 27, SubCategoryId = 4, Name = "Chicken Samosa", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 23, CategoryId = 2, SubCategoryId = null, Name = "BREAD", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 24, CategoryId = 2, SubCategoryId = null, Name = "BUN", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 25, CategoryId = 2, SubCategoryId = null, Name = "AVAL BUN", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 26, CategoryId = 2, SubCategoryId = null, Name = "CREAM BUN", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 27, CategoryId = 3, SubCategoryId = null, Name = "FRUIT BREAD", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 28, CategoryId = 3, SubCategoryId = null, Name = "BUTTER BREAD", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 29, CategoryId = 3, SubCategoryId = null, Name = "DONUT", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 30, CategoryId = 4, SubCategoryId = 2, Name = "Marble Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 31, CategoryId = 4, SubCategoryId = 2, Name = "Tea Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 32, CategoryId = 4, SubCategoryId = 2, Name = "Butter Plum", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 33, CategoryId = 4, SubCategoryId = 2, Name = "Strawberry Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 34, CategoryId = 5, SubCategoryId = null, Name = "PLUM CAKE", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 35, CategoryId = 6, SubCategoryId = null, Name = "PINEAPPALE CAKE", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 36, CategoryId = 7, SubCategoryId = null, Name = "CARROT&DATES CAKE", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 37, CategoryId = 9, SubCategoryId = null, Name = "Cream", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 38, CategoryId = 8, SubCategoryId = null, Name = "SPUNGE CAKE", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 39, CategoryId = 10, SubCategoryId = null, Name = "Black Forest Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 40, CategoryId = 11, SubCategoryId = null, Name = "White Forest Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 41, CategoryId = 12, SubCategoryId = null, Name = "Red Velvet Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 42, CategoryId = 13, SubCategoryId = null, Name = "GHEE CAKE", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 43, CategoryId = 14, SubCategoryId = null, Name = "Sandwitch BREAD", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 44, CategoryId = 14, SubCategoryId = null, Name = "ATTA BREAD", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 45, CategoryId = 14, SubCategoryId = null, Name = "PAV BUN", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 46, CategoryId = 14, SubCategoryId = null, Name = "Kubboos", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 47, CategoryId = 14, SubCategoryId = null, Name = "Chicken Roll", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 48, CategoryId = 14, SubCategoryId = null, Name = "Meat Roll", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 49, CategoryId = 14, SubCategoryId = null, Name = "Veg Roll", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 50, CategoryId = 14, SubCategoryId = 3, Name = "Chicken sandwitch", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 51, CategoryId = 14, SubCategoryId = 3, Name = "Meat sandwitch", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 52, CategoryId = 14, SubCategoryId = 3, Name = "Veg sandwitch", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 53, CategoryId = 14, SubCategoryId = 3, Name = "Chicken Tikka", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 54, CategoryId = 14, SubCategoryId = null, Name = "Chicken Pizza", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 55, CategoryId = 14, SubCategoryId = null, Name = "Chicken Burger", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 56, CategoryId = 14, SubCategoryId = null, Name = "Meat Burger", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 57, CategoryId = 14, SubCategoryId = null, Name = "Veg Burger", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 58, CategoryId = 15, SubCategoryId = null, Name = "TEA RUSK", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 59, CategoryId = 16, SubCategoryId = null, Name = "WHITE RUSK", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 60, CategoryId = 17, SubCategoryId = null, Name = "Beans Biscuit", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 61, CategoryId = 18, SubCategoryId = null, Name = "Pineapple Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 62, CategoryId = 19, SubCategoryId = null, Name = "Orange Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 63, CategoryId = 20, SubCategoryId = null, Name = "Strawberry Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 64, CategoryId = 21, SubCategoryId = null, Name = "Pista Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 65, CategoryId = 22, SubCategoryId = null, Name = "Semia Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 66, CategoryId = 23, SubCategoryId = null, Name = "Coconut Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 67, CategoryId = 24, SubCategoryId = null, Name = "Masala Cookies", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 68, CategoryId = 25, SubCategoryId = null, Name = "Pineapple Muffin", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 69, CategoryId = 25, SubCategoryId = null, Name = "Strwberry Muffin", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 70, CategoryId = 26, SubCategoryId = null, Name = "Choc Muffin", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime },
                new Product { Id = 71, CategoryId = 27, SubCategoryId = null, Name = "Cherry Cake", MRP = 450, CreatedById = UserId, CreatedOn = CurrentTime }
            );

            //modelBuilder.Entity<ProductRawMaterial>().HasData(
            //    new ProductRawMaterial { Id = 1, ProductId = 1, RawMaterialId = 1, QuantityRequired = 0.5f },
            //    new ProductRawMaterial { Id = 2, ProductId = 1, RawMaterialId = 2, QuantityRequired = 0.3f },
            //    new ProductRawMaterial { Id = 3, ProductId = 2, RawMaterialId = 1, QuantityRequired = 0.7f }
            //);



        }
    }
}
