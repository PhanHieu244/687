using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{
    private Rigidbody rb;
  //  public GameObject basketBall;
    public float Speed;
    bool moveleft, moveright;

    // Start is called before the first frame update
    void Start()
    {
        moveright = true;
        moveleft = false;
        rb = this.gameObject.GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rb.isKinematic == true)
            {
                rb.isKinematic = false;
            }
            if (moveright)
            {
                rb.velocity = Vector3.right * 100 * Time.deltaTime + Vector3.up * Speed * Time.deltaTime;
            }
            else if (moveleft)
            {
                rb.velocity = Vector3.left * 100 * Time.deltaTime + Vector3.up * Speed * Time.deltaTime;
            }
            //  rb.AddRelativeForce(Vector3.up * Speed * Time.deltaTime, ForceMode.Impulse);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Left")
        {
            moveleft = false;
            moveright = true;
        }
        if (collision.gameObject.tag == "Right")
        {
            moveleft = true;
            moveright = false;
        }
    }
}
