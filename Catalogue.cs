namespace G15_13092022;

internal class Catalogue : List<Product>
{
    new public Product this[int index]
    {
        get
        {
            return this[index];
        }
        set
        {
            ProtectID(value);
            base[index] = value;
        }
    }

    new public void AddRange(IEnumerable<Product> collection)
    {
        foreach (var item in collection)
        {
            this.Add(item);
        }
    }

    new public void InsertRange(int index, IEnumerable<Product> collection)
    {
        foreach (var item in collection)
        {
            this.Insert(index,item);
        }
    }
    new public void Insert(int index, Product item)
    {
        ProtectID(item);
        base.Insert(index, item);
    }

    new public void Add(Product item)
    {
        ProtectID(item);
        base.Add(item);
    }

    private void ProtectID(Product item)
    {
        foreach (Product member in this)
        {
            if (member.ID == item.ID)
            {
                throw new Exception($"Item With ID: {item.ID} Is Already Exist.");
            }
        }
    }

    public void Load(string filePath)
    {
        this.Clear();

        using BinaryReader reader = new(new FileStream(filePath, FileMode.Open));
        while (reader.BaseStream.Position < reader.BaseStream.Length)
        {
            Product prod = new(reader.ReadInt32());
            prod.Name = reader.ReadString();
            prod.Price = reader.ReadDecimal();
            Add(prod);
        }
    }
    public void Save(string filePath)
    {
        using BinaryWriter writer = new(new FileStream(filePath, FileMode.Create));

        foreach (var product in this)
        {
            writer.Write(product.ID);
            writer.Write(product.Name);
            writer.Write(product.Price);
        }
    }
    public decimal TotalAmount
    {
        get
        {
            decimal total = 0;
            foreach (var product in this)
            {
                total += product.Price;
            }
            return total;
        }
    }

}
