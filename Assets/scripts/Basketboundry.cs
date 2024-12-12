using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketboundry : MonoBehaviour
{
    // Start is called before the first frame update
    Basket basket;
    void Start()
    {
        basket = FindObjectOfType<Basket>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void OnCollisionEnter(Collision collision)
    //{
    // //   Debug.Log(collision.gameObject);
    //    if(collision.gameObject.tag=="Player" || collision.gameObject.tag == "Enemy")
    //    {
    //        basket.stoppointer = false;
    //    }
    //}
    public void OnCollisionExit(Collision collision)
    {

    }
}
