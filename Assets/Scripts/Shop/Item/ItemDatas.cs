using UnityEngine;

public class ItemDatas : ScriptableObject
{
    public ItemList Items;

    private ItemDatas()
    {
        Items.SetItemData(1, new FishingRobData(1, "낡은 낚시대", 0, Performance.WORN_OUT));
        Items.SetItemData(2, new FishingRobData(2, "엄청 가벼운 낚시대", 10, Performance.ULTRA_LIGHT));
        Items.SetItemData(3, new FishingRobData(3, "가벼운 낚시대", 100, Performance.LIGHT));
        Items.SetItemData(4, new FishingRobData(4, "적당한 낚시대", 1000, Performance.MEDIUM));
        Items.SetItemData(5, new FishingRobData(5, "적당히 무거운 낚시대", 2000, Performance.MEDIUM_HEAVY));
        Items.SetItemData(6, new FishingRobData(6, "무거운 낚시대", 2000, Performance.HEAVY));

        Items.SetItemData(1001, new FishData(1001, "대방이", 30, Grade.C, 2));
        Items.SetItemData(1002, new FishData(1002, "하얀어", 70, Grade.C, 5));
        Items.SetItemData(1003, new FishData(1003, "영어", 100, Grade.C, 10));

        Items.SetItemData(1004, new FishData(1004, "한국어", 150, Grade.B, 15));
        Items.SetItemData(1005, new FishData(1005, "혱어", 200, Grade.B, 20));

        Items.SetItemData(1006, new FishData(1006, "가루도미", 500, Grade.A, 30));
        Items.SetItemData(1007, new FishData(1007, "넙치", 500, Grade.A, 20));
        Items.SetItemData(1008, new FishData(1008, "잉어", 1000, Grade.A, 30));

        Items.SetItemData(1009, new FishData(1009, "가루오리", 4000, Grade.S, 35));
        Items.SetItemData(1010, new FishData(1010, "대방이상어", 5000, Grade.S, 70));
        Items.SetItemData(1011, new FishData(1011, "가루상어", 5000, Grade.S, 50));
        Items.SetItemData(1012, new FishData(1012, "대방이고래", 10000, Grade.S, 100));
    }
}