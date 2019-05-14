using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolikot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D (Collider2D tormaaja)
    {
        if (tormaaja.name.Equals("Pelaaja"))
        {
            GameObject.Find("Kamera").GetComponent<aika_ja_kolikot1>().Kolikot += 0.5f;
            Destroy(this.gameObject);
            
            

           
        }
    }
}
