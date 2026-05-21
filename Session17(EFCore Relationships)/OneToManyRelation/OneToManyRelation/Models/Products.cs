namespace OneToManyRelation.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
