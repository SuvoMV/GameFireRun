using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy4 : MonoBehaviour
{
    public GameObject BuyButton;
    int BuySkin;
    void Start()
    {
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (BuySkin == 1)
        {
            BuyButton.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);
        }
    }

    public void BuySkins()
    {
        if (MoneyText.Money >= 20)
        {
            MoneyText.Money -= 20;
            PlayerPrefs.SetInt("money", MoneyText.Money);
            BuySkin = 2;
            PlayerPrefs.GetInt("BuySkin", BuySkin);
            //PlayerPrefs.SetInt("BuySkin", BuySkin);
        }

    }
}
