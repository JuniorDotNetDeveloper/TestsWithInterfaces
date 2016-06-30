# TestsWithInterfaces
// sort with delegate


public static Product[] GetProductList()
{
  Product[] productList = new Product 
  {
    new Product {Name: "Apple", ProductID: 21, Count: 200},
    new Product {Name: "Bananas", ProductID: 36, Count: 19},
    new Product {Name: "Peneapple", ProductID: 5, Count: 342},
    new Product {Name: "Cocos", ProductID: 2, Count: 1231}
  }
}
////////////////////////////////////////////////////
class Programm
{
  public static void Main()
  {
    Product[] productList = GetProductList();
    
    Console.WriteLine("Sort by Name");
    Array.Sort(productList, delegate(Product p1, Product p2) { return p1.Name.CompareTo(p2.Name);});
    
    Console.WriteLine("Sort by Count");
    Array.Sort(productList, delegate(Product p1, Product p2) { return p1.Count.CompareTo(p2.Count);});
  }
}
