using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int orientation = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            orientation = orientation + 1;
            if (orientation > 3)
            {
                orientation = 0;
            }
        }
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 90.0f * orientation);
    }
}
