using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMoneda : MonoBehaviour
{
    public float velocidadRotacion = 5.0f;
    public float amplitudMovimiento = 1.0f;
    public float velocidadMovimiento = 2.0f;

    private float tiempoInicio;
    private float posicionInicialY;

    void Start()
    {
        tiempoInicio = Time.time;
        posicionInicialY = transform.position.y;
    }

    void Update()
    {
        transform.Rotate(Vector3.right, velocidadRotacion * Time.deltaTime);

        float movimientoX = Mathf.Sin((Time.time - tiempoInicio) * velocidadMovimiento) * amplitudMovimiento;
        transform.position = new Vector3(transform.position.x, posicionInicialY + movimientoX, transform.position.z);
    }
}
