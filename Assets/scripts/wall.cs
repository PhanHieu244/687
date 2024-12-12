using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    // Start is called before the first frame update
    Basket basket;
    void Start()
    {
        basket = FindObjectOfType<Basket>();
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            basket.Enemystoppointer = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            basket.Playerstoppointer = true;
        }
    }
}
