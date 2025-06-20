using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopWindowController : MonoBehaviour
{
    [SerializeField] 
    private GameObject _shopWindow;
    [SerializeField]
    private GameObject _buyingWindow;
    [SerializeField]
    private GameObject _sellingWindow;
    [SerializeField]
    private GameObject _slide;

    public ItemList Items = new();

    private bool _isShopWindowEnable;

    private void Start()
    {
        if (_shopWindow == null || _buyingWindow == null || _sellingWindow == null)
        {
            Debug.Log($"Window is null"); // 방어코드... 일단비워둠
        }
    }
    private void Awake()
    {
        _shopWindow.SetActive(false);
        _isShopWindowEnable = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isShopWindowEnable = !_isShopWindowEnable;

            if(_isShopWindowEnable)
            {
                OnUIWindowEnabled();
            }
            else
            {
                _shopWindow.SetActive(false);
            }
        }
    }

    public void OnCloseButtonClicked()
    {
        _isShopWindowEnable = false;
        _shopWindow.SetActive(false);
    }

    public void OnBuyButtonClicked()
    {
        _sellingWindow.SetActive(false);
        _buyingWindow.SetActive(true);
    }

    public void OnSellButtonClicked()
    {
        _buyingWindow.SetActive(false);
        _sellingWindow.SetActive(true);
    }

    private void OnUIWindowEnabled()
    {
        _shopWindow.SetActive(true);
        _buyingWindow.SetActive(true);
        _sellingWindow.SetActive(false);
    }
}
