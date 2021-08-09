namespace Exercicio___S9_123__Projeto_Enums_e_Composição_.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
