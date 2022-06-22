namespace University_Project.Mvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Raiting_ID { get; set; }
        public string Category { get; set; }

        public Product(int ProductId, string name, float price, string description,string image, int rating_ID, string category)
        {
            Id = ProductId;
            Name = name;
            Price = price;
            Description = description;
            Image = image;
            Raiting_ID = rating_ID;
            Category = category;
        }
    }
}
