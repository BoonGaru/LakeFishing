using UnityEngine;

[SerializeField]
public class FishData 
{
    public int FishID;
    public string Name;
    public int Price;
    public Grade AppProb; //���� Ȯ��
    public int Strength;

    public FishData(int id, string name, int price, Grade appProb, int strength)
    {
        FishID = id;
        Name = name;
        Price = price;
        AppProb = appProb;
        Strength = strength;
    }
}