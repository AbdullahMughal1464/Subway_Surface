using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerPosition : MonoBehaviour
{
    private float zBound = 6.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ContainPlayerPosition();
    }
    void ContainPlayerPosition()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }

    }

}
