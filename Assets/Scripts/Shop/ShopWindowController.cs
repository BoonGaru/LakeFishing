using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopWindowController : MonoBehaviour
{
    [SerializeField] 
    private GameObject _shopWindow;
    [SerializeField]
    private GameObject _buyingWindow;
    [SerializeField]
    private GameObject _sellingWindow;

    private bool _isShopWindowEnable;

    private void Start()
    {
        if (_shopWindow == null || _buyingWindow == null || _sellingWindow == null)
        {
            Debug.Log($"Window is null"); // 방어코드... 일단비워둠
        }

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
        _shopWindow.SetActive(_isShopWindowEnable);
    }

    private void OnUIWindowEnabled()
    {
        _shopWindow.SetActive(true);
        _sellingWindow.SetActive(false);
    }
}
