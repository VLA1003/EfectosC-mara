using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaneoCamara : MonoBehaviour
{
    public Transform puntoFinal;
    public float velocidadMovimiento = 2.0f;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        MovPaneoCamara();
    }

    void MovPaneoCamara()
    {
        float step = velocidadMovimiento * Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, puntoFinal.position, step);
    }
}
