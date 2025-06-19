using UnityEngine;

[SerializeField]
public class FishingRobData 
{
    public int FishingRobID;
    public string Name;
    public int Price;
    public Performance Perform;

    public bool IsOwned;

    public FishingRobData(int id, string name, int price, Performance performance)
    {
        FishingRobID = id;
        Name = name;
        Price = price;
        Perform = performance;
    }
}