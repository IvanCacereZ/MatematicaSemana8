using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField] private Rigidbody myRB;
    [SerializeField] private float velocityModifier = 3f;
    [SerializeField] Vector3 angulos;
    [SerializeField] Quaternion qx = Quaternion.identity;
    [SerializeField] Quaternion qy = Quaternion.identity;
    [SerializeField] Quaternion qz = Quaternion.identity;

    [SerializeField] Quaternion r = Quaternion.identity;
    float anguloSen, anguloCos;
    void Update()
    {
        float GetHorizontal = Input.GetAxis("Horizontal");
        float GetVertical = Input.GetAxis("Vertical");
        Vector2 movementPlayer = new Vector2(GetHorizontal, GetVertical);
        myRB.velocity = movementPlayer * velocityModifier;
        /*if(GetHorizontal == 0 && GetVertical == 0){
            angulos = new Vector3(90,0,0);
        }
        else if(GetHorizontal < 0){
            angulos = new Vector3(90,-20,0);
        }
        else if(GetHorizontal > 0){
            angulos = new Vector3(90,20,0);
        }
        else if(GetVertical < 0){
            angulos = new Vector3(65,0,0);
        }
        else if(GetVertical > 0){
            angulos = new Vector3(115,0,0);
        }*/
    }
    private void FixedUpdate()
    {

        /*anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulos.x * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulos.x * 0.5f);
        qx.Set(anguloSen, 0, 0, anguloCos);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulos.y * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulos.y * 0.5f);
        qy.Set(0, anguloSen, 0, anguloCos);

        anguloSen = Mathf.Sin(Mathf.Deg2Rad * angulos.z * 0.5f);
        anguloCos = Mathf.Cos(Mathf.Deg2Rad * angulos.z * 0.5f);
        qz.Set(0, 0, anguloSen, anguloCos);

        r = qy * qx * qz;
        transform.rotation = r;*/
    }
}
