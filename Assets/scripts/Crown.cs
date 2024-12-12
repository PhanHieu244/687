using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
   
    public GameObject player;
   
      public void LateUpdate()
        {
            transform.position = player.transform.position+new Vector3(0,1.4f,0);
        }
    
}
