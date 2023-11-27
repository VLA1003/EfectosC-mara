using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneo : MonoBehaviour
{
    public Transform puntoFinal;
    public float velocidadMovimiento = 2.0f;
    public GameObject camaraPaneo;

    private Vector3 posicionInicial;
    private float tiempoPasado = 0f;

    void Start()
    {
        camaraPaneo.SetActive(true);
        posicionInicial = transform.position;
    }

    void Update()
    {
        MovPaneoCamara();
        tiempoPasado += Time.deltaTime;
        if (tiempoPasado >5f)
        {
            camaraPaneo.SetActive(false);
        }
    }

    void MovPaneoCamara()
    {
        float distancia = Vector3.Distance(transform.position, puntoFinal.position);
        float step = Mathf.Min(velocidadMovimiento * Time.deltaTime, distancia);
        transform.position = Vector3.MoveTowards(transform.position, puntoFinal.position, step);
    }
}
