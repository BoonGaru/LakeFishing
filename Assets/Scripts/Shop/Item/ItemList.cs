
using System.Collections.Generic;
using UnityEngine;

public class ItemList
{
    private Dictionary<int, object> _itenData = new();

    public void SetItemData(int id, object data)
    {
        _itenData[id] = data;
    }

    public object GetItemData(int id)
    {
        return _itenData[id];
    }
}