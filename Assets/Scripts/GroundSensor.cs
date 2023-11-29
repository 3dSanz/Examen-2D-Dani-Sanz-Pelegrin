using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
public static bool _groundSensor;

void OnTriggerEnter2D (Collider2D other)
{
    if(other.gameObject.layer == 3)
    {
        _groundSensor = true;
    }
}

void OnTriggerStay2D (Collider2D other)
{
    if(other.gameObject.layer == 3)
    {
        _groundSensor = true;
    }
}

void OnTriggerExit2D (Collider2D other)
{
    if(other.gameObject.layer == 3)
    {
        _groundSensor = false;
    }
}

}
