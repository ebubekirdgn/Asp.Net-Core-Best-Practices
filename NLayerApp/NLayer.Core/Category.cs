namespace NLayer.Core
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Product> Products { get; set; }

    }
}
