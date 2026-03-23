using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bebidas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Menu = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Masas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bebidas",
                columns: new[] { "Id", "Descripcion", "Ingredientes", "Menu", "Nombre", "Precio", "Ruta" },
                values: new object[,]
                {
                    { 41, "Experimenta todo el sabor cola, refrescando y amplificando cada momento (113 Cal)", null, 0, "Pepsi 600 ml", 25m, "images/bebidas/5090ae51-956d-42b0-a51a-cf5af5636032.jpg" },
                    { 42, "Experimenta todo el sabor cola, refrescando y amplificando cada momento (113 Cal)", null, 0, "Pepsi 1.5 litros", 54m, "images/bebidas/5090ae51-956d-42b0-a51a-cf5af5636032.jpg" },
                    { 43, "Experimenta y comparte el gran sabor cola, sin calorias (0 Cal)", null, 0, "Pepsi Ligth 600 ml", 25m, "images/bebidas/48dc6f3f-c5be-45fa-892e-c7064994f642.jpg" },
                    { 44, "Experimenta y comparte el gran sabor cola, sin calorias (0 Cal)", null, 0, "Pepsi Ligth 1.5 litros", 54m, "images/bebidas/48dc6f3f-c5be-45fa-892e-c7064994f642.jpg" },
                    { 45, "Agua, burbujas y los refrescantes sabores naturales de la lima & limón (0 Cal)", null, 0, "7up 600 ml", 32m, "images/bebidas/0760521a-dcb5-4be7-b481-fa8b22ed8b88.jpg" },
                    { 46, "Agua, burbujas y los refrescantes sabores naturales de la lima & limón (0 Cal).", null, 0, "7up 1.5 litros", 54m, "images/bebidas/0760521a-dcb5-4be7-b481-fa8b22ed8b88.jpg" },
                    { 47, "Agua purificada que te hidrata y cuida tu corazón por no contener sodio (0 Cal)", null, 0, "E-Pura Natural 600 ml", 32m, "images/bebidas/95f1a30b-62f8-4e4a-8f11-644e8a047e79.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Masas",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "La original y clásica masa fresca hecha al momento con orilla dorada y espolvoreada de especias que le dan nuestro toque único.", "Original" },
                    { 2, "Masa fresca hecha al momento con deliciosa orilla dorada rellena de queso mozzarella derretido y espolvoreada con especias.", "Orilla rellena de queso" },
                    { 3, "Masa dorada y esponjosa con toque de mantequilla, doble capa de queso (provolone y mozzarella) e ingredientes hasta la orilla.", "Sartén" },
                    { 4, "Masa delgada y crujiente con borde dorado, perfecta para resaltar el sabor de los ingredientes y ofrecer una experiencia más ligera.", "Crunchy" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Ingredientes", "Nombre", "Precio", "Ruta" },
                values: new object[,]
                {
                    { 1, null, "Carbonara", 0m, "/images/pizzas/022238e3-ac62-45af-b765-379a077a9b26.jpg" },
                    { 2, null, "Triple peperoni", 0m, "/images/pizzas/00455854-40f9-45e2-a241-b03e70dfe6cc.jpg" },
                    { 3, null, "Peperoni", 0m, "/images/pizzas/be242cad-08db-4b00-becd-be48a9fb86a4.jpg" },
                    { 4, null, "Hawaiina", 0m, "/images/pizzas/75b89c2b-2c59-4225-8478-4e9ab4432ec9.jpg" },
                    { 5, null, "Mexicana", 0m, "/images/pizzas/7f339d0c-bf13-4839-a9dc-de6721210a5b.jpg" },
                    { 6, "[\"Salsa BBQ\",\"Salsa de tomate\",\"Carne molida\",\"Pollo\",\"Tocino\"]", "Texas bbq", 0m, "/images/pizzas/67734d82-5c38-40f8-a311-255c0d157bd5.jpg" },
                    { 7, null, "Cuatro quesos", 0m, "images/pizzas/0ad30a1e-d7ed-4384-9b1e-b8a5c9587174.jpg" },
                    { 8, null, "Pepperoni especial", 0m, "images/pizzas/8be27c50-bb3c-4774-ac8f-a41f42029617.jpg" },
                    { 9, null, "Carnes frias", 0m, "images/pizzas/f8748c06-e178-4d38-b99c-a522ad450a86.jpg" },
                    { 10, null, "Chicken hawaiina", 0m, "images/pizzas/49249843-d9af-4356-bcac-ae94e3357742.jpg" },
                    { 11, null, "Honolulu", 0m, "images/pizzas/cdcef20a-407a-488e-9751-6f481a871048.jpg" },
                    { 12, null, "Veggie", 0m, "images/pizzas/3f362b55-3f56-47f9-b67a-ff49eb10f66a.jpg" },
                    { 13, null, "Extravaganzza", 0m, "images/pizzas/db99ef86-f2b8-4a8e-8afb-5ad4409e4233.jpg" },
                    { 14, null, "Deluxe", 0m, "images/pizzas/9614b6f3-0def-4ace-8c5d-e0954d899a5b.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebidas");

            migrationBuilder.DropTable(
                name: "Masas");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
