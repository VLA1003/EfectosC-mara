using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPaneo : MonoBehaviour
{
    public Transform puntoFinal;
    public float velocidadMovimiento = 2.0f;
    private Vector3 posicionInicial;
    private bool acaboPaneo = false;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        if (!acaboPaneo)
        {
            PaneoCamara();
        }
    }

    void PaneoCamara()
    {
        float step = velocidadMovimiento * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, puntoFinal.position, step);
        if (transform.position == puntoFinal.position)
        {
            acaboPaneo = true;
        }
    }
}
