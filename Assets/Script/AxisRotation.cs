using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRotation : MonoBehaviour
{
    [SerializeField] private float Xspeed;
    [SerializeField] private float Yspeed;
    [SerializeField] private float Zspeed;

    void Update()
    {
        transform.Rotate(Xspeed, Yspeed, Zspeed);
    }
}
