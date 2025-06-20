using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class BuyFishingRobData : MonoBehaviour
{
    [SerializeField]
    public int FishingRobID;

    [SerializeField]
    private GameObject _UIManager;
    [SerializeField]
    private GameObject _nameObj;
    [SerializeField]
    private GameObject _priceObj;

    private ItemList _itemList;
    private FishingRobData _fishingRobData;

    private void Awake()
    {
        _itemList = _UIManager.GetComponent<ShopWindowController>().Items;
        _fishingRobData = (FishingRobData)_itemList.GetItemData(FishingRobID);
        Debug.Log(_fishingRobData.Name);

        _nameObj.GetComponent<TextMeshProUGUI>().text = _fishingRobData.Name;
        _priceObj.GetComponent<TextMeshProUGUI>().text = _fishingRobData.Price.ToString();
    }
}
