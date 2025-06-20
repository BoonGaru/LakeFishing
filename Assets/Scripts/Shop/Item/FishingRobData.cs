using UnityEngine;

[CreateAssetMenu]
public class FishingRobData :ScriptableObject
{
    public int FishingRobID;
    public string Name;
    public int Price;
    public Performance Perform;

    public bool IsOwned;
}

