using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Target;
    public Vector3 offcet;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredpos = Target.transform.position +offcet;
        Vector3 smoothdamping = Vector3.Lerp(this.transform.position, desiredpos, speed * Time.deltaTime);
        this.transform.position = new Vector3(0,Mathf.Clamp(smoothdamping.y, 1.5f, 3.62f), -11);
    }
}
