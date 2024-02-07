using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public static int money;

    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
    }


    public void Click()
    {
        money++;
    }


    public void Update()
    {
        moneyText.text = "Food:" + money;
    }

}
