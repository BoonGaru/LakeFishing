using UnityEngine;

public class ItemDatas : ScriptableObject
{
    public ItemList Items;

    private ItemDatas()
    {
        Items.SetItemData(1, new FishingRobData(1, "���� ���ô�", 0, Performance.WORN_OUT));
        Items.SetItemData(2, new FishingRobData(2, "��û ������ ���ô�", 10, Performance.ULTRA_LIGHT));
        Items.SetItemData(3, new FishingRobData(3, "������ ���ô�", 100, Performance.LIGHT));
        Items.SetItemData(4, new FishingRobData(4, "������ ���ô�", 1000, Performance.MEDIUM));
        Items.SetItemData(5, new FishingRobData(5, "������ ���ſ� ���ô�", 2000, Performance.MEDIUM_HEAVY));
        Items.SetItemData(6, new FishingRobData(6, "���ſ� ���ô�", 2000, Performance.HEAVY));

        Items.SetItemData(1001, new FishData(1001, "�����", 30, Grade.C, 2));
        Items.SetItemData(1002, new FishData(1002, "�Ͼ��", 70, Grade.C, 5));
        Items.SetItemData(1003, new FishData(1003, "����", 100, Grade.C, 10));

        Items.SetItemData(1004, new FishData(1004, "�ѱ���", 150, Grade.B, 15));
        Items.SetItemData(1005, new FishData(1005, "��", 200, Grade.B, 20));

        Items.SetItemData(1006, new FishData(1006, "���絵��", 500, Grade.A, 30));
        Items.SetItemData(1007, new FishData(1007, "��ġ", 500, Grade.A, 20));
        Items.SetItemData(1008, new FishData(1008, "�׾�", 1000, Grade.A, 30));

        Items.SetItemData(1009, new FishData(1009, "�������", 4000, Grade.S, 35));
        Items.SetItemData(1010, new FishData(1010, "����̻��", 5000, Grade.S, 70));
        Items.SetItemData(1011, new FishData(1011, "������", 5000, Grade.S, 50));
        Items.SetItemData(1012, new FishData(1012, "����̰�", 10000, Grade.S, 100));
    }
}