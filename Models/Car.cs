// Business Logic

using System;
namespace Dealership.Models
{
  public class Car
  {

    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public float SalePrice { get; set; }

    public static string MakeSound(string sound)
    {
        return "Our cars soundlike" + sound;
    }

    public Car(string makeModel, int price, int miles, float salePrice)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      SalePrice = salePrice;
    }

    public string GetMakeModel() { return MakeModel; }

    public int GetPrice() { return Price; }

    public int GetMiles() { return Miles; }

    public float GetSalePrice() { return SalePrice; }

    public bool WorthBuying(int maxPrice)
    {
      return ( Price <= maxPrice); 
    }
  }
}
