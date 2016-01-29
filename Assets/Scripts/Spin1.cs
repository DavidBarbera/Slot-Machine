using UnityEngine;
using System.Collections;

public class Spin1 : MonoBehaviour
{

    private bool isSpinning = false;
    private float spinCounter = 0;
    private float spinStep = 360.0f / 4.0f;
    public int value = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            isSpinning = !isSpinning;
            spinCounter = Random.Range(90, 120);
        }

        if (isSpinning && spinCounter > 0)
        {
            transform.Rotate(new Vector3(0, 0, 1), spinStep);
            --spinCounter;
            value = (value + 1) % 4;
        }
        else if (isSpinning && spinCounter <= 0)
        {
            isSpinning = false;
        }
        if (isSpinning == false && Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 1), spinStep);
        }
    }
}
