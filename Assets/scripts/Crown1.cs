using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject enemy;

    public void LateUpdate()
    {
        transform.position = enemy.transform.position + new Vector3(0, 1.3f, 0);
    }
}
