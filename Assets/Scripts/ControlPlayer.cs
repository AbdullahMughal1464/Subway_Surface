using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    private float zPressA = 6.2f;
    private float zPressD=-6.23f;
    private bool isOnLeft = true;
    private bool isOnRight = true;
    private float zPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        zPosition = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
      
        
        Debug.Log("zPoint" + zPosition);
        if (Input.GetKeyDown(KeyCode.A) && isOnLeft)
        {
            zPosition += zPressA;
            isOnRight = true;
            Vector3 newPosition = transform.position;
            newPosition.z = zPosition;
            transform.position = newPosition;
            isOnLeft = false;

        }
        if (Input.GetKeyDown(KeyCode.D) && isOnRight)
        {
            zPosition += zPressD;
            isOnLeft = true;
            Vector3 newPosition = transform.position;
            newPosition.z = zPosition;
            transform.position = newPosition;
            isOnRight = false;
        }

    }
  
}

