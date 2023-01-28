namespace G15_13092022;

internal class Product
{
	public Product(int id)
	{
		ID = id;
	}

	public int ID { get; private init; }
	public string Name { get; set; } = string.Empty;
	public decimal Price { get; set; }
	public override string ToString()
	{
		return $"{ID}, {Name}, {Price}";
	}
}
