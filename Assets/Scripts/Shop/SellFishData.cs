using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SellFishData : MonoBehaviour 
{
    [SerializeField] 
    public int FishID;

    [SerializeField]
    private GameObject _UIManager;
    [SerializeField]
    private GameObject _nameObj;
    [SerializeField]
    private GameObject _priceObj;

    private ItemList _itemList;
    private FishData _fishData;

    private void Awake()
    {
        _itemList = _UIManager.GetComponent<ShopWindowController>().Items;
        _fishData = (FishData)_itemList.GetItemData(FishID);
        Debug.Log(_fishData.Name);

        _nameObj.GetComponent<TextMeshProUGUI>().text = _fishData.Name;
        _priceObj.GetComponent<TextMeshProUGUI>().text = "+ " + _fishData.Price;
    }
}