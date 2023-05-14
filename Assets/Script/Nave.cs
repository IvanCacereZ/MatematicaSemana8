using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField] private Rigidbody myRB;
    [SerializeField] private float velocityModifier = 3f;
    public Vector3 angulos;
    
    float anguloSen, anguloCos;
    void Update()
    {
        float GetHorizontal = Input.GetAxis("Horizontal");
        float GetVertical = Input.GetAxis("Vertical");
        Vector2 movementPlayer = new Vector2(GetHorizontal, GetVertical);
        if (Input.GetKey("space"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1 * Time.deltaTime);
        }
        if(GetHorizontal > 0)
        {
            angulos.z = -55f;
        }
        else if (GetHorizontal < 0)
        {
            angulos.z = 55f;
        }
        else
        {
            angulos.z = 0f;
        }
        if (GetVertical > 0)
        {
            angulos.x = 30f;
        }
        else if (GetVertical < 0)
        {
            angulos.x = -30f;
        }
        else
        {
            angulos.x = 90;
        }
        myRB.velocity = movementPlayer * velocityModifier;
        GetRotation();
    }
    private void GetRotation()
    {
        Quaternion qx = Quaternion.identity;
        Quaternion qy = Quaternion.identity;
        Quaternion qz = Quaternion.identity;
        Quaternion r = Quaternion.identity;
        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulos.z * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulos.z * 0.5f);
        qz.Set(0, 0, anguloSen, anguloCos);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulos.x * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulos.x * 0.5f);
        qx.Set(anguloSen, 0, 0, anguloCos);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulos.y * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulos.y * 0.5f);
        qy.Set(0, anguloSen, 0, anguloCos);

        r = qy * qx * qz;
        transform.rotation = r;
    }
}
