using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class aika_ja_kolikot1 : MonoBehaviour
{
    private float aikalaskuri = 220f;

    public float Kolikot = 0f;

    private GameObject t1 = null;
    private GameObject t2 = null;

    void Start()
    {
        this.t1 = GameObject.Find("aika");
        this.t2 = GameObject.Find("kolikot");
    }


    void Update()
    {
        this.aikalaskuri -= (Time.deltaTime * 10);

        this.t1.GetComponent<Text>().text = "TIME: " + (int)this.aikalaskuri;
        this.t2.GetComponent<Text>().text = "MONEY: " + this.Kolikot.ToString("0.00") + " e";

        if (this.aikalaskuri <= 0)
        {
            PlayerPrefs.SetFloat("Coins", this.Kolikot);

            SceneManager.LoadScene("GameOver");
        }

        if(Kolikot == 3.50)
        {
            SceneManager.LoadScene("GameOver");
            PlayerPrefs.SetFloat("Coins", this.Kolikot);
        }
    }
}
