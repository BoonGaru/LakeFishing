using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class FishData : ScriptableObject 
{
    public int FishID;
    public string Name;
    public int Price;
    public Grade AppProb; //µîÀå È®·ü
    public int Strength;
    public int Amount;
    public int PrefabIndex;

    public FishData(int id, string name, int price, Grade appProb, int strength)
    {
        FishID = id;
        Name = name;
        Price = price;
        AppProb = appProb;
        Strength = strength;
    }
}

