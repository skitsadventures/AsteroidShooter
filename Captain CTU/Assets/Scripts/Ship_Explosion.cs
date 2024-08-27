using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Explosion : MonoBehaviour
{
    void FixedUpdate()
    {
        Destroy(gameObject, 0.8f);
    }
}
