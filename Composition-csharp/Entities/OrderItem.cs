namespace Composition_csharp.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; private set; }
        public Product Product { get; private set; }
        
        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${this.SubTotal()}";
        }
    }
}
