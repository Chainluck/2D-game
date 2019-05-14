using UnityEngine;
using UnityEngine.UI;
public class GetCoinsToGameOver : MonoBehaviour
{

    void Start()
    {
        float Coins = PlayerPrefs.GetFloat("Coins");
        GameObject.Find("Coins").GetComponent<Text>().text = "Coins Collected: " + Coins.ToString("0.00") + " e";
    }

}
