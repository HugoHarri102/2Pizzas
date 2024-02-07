using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;

    public void ButtonCick()
    {
        money++;
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}
