using UnityEngine;
using System.Collections;

public class Handle : MonoBehaviour {
    int angle = 90;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 1, 0), angle);
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 1, 0), -angle);
        }
    }
}
