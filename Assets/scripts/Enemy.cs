using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    // public GameObject basketBall;
    private float Speed;
    bool moveleft, moveright;
    bool startenemymovement;
    public GameObject ground;
    // Start is called before the first frame update
    void Start()
    {
        moveright = false;
        moveleft = true;
        rb = this.gameObject.GetComponent<Rigidbody>();
        startenemymovement = false;
    }

    // Update is called once per frame
    int[] ra=new int[] {4,4};
    int[] speed=new int[] {1500,1900};

    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            startenemymovement = true;
        }
        //Debug.Log(Vector3.Distance(ground.transform.position, this.transform.position));
        if (Vector3.Distance(ground.transform.position,this.transform.position)<ra[Random.Range(0,ra.Length)] && startenemymovement)
        {
            if (rb.isKinematic == true)
            {
                rb.isKinematic = false;
            }
            if (moveright)
            {
                rb.velocity = Vector3.right * 100 * Time.deltaTime + Vector3.up * speed[Random.Range(0, speed.Length)] * Time.deltaTime;
                this.gameObject.GetComponent<ConstantForce>().force = new Vector3(0, -50, 0);


            }
            else if (moveleft)
            {
                rb.velocity = Vector3.left * 100 * Time.deltaTime + Vector3.up * speed[Random.Range(0, speed.Length)] * Time.deltaTime;
                this.gameObject.GetComponent<ConstantForce>().force = new Vector3(0, -50, 0);

            }
        }
            
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Right")
        {
            moveleft = true;
            moveright = false;
        }
        if (collision.gameObject.tag == "Left")
        {
            moveleft = false;
            moveright = true;
        }
    }
}
