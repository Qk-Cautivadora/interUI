using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    //variables de movimiento
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    //variable de velocidad
    public float velocidadMovimiento = 1.5f;
   

    // Update is called once per frame
    void Update()
    {
        //recoge la posicion mediante el uso de las teclas w,a,s,d
       movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
       movimientoEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;

        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
