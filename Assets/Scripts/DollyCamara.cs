using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollyCamara : MonoBehaviour
{
    public Camera camaraPrincipal;
    public Transform posicionA;
    public float valorCampoVision = 30f;
    public float duracion = 5f;

    private float tiempoPasado = 0f;

    void Update()
    {
        tiempoPasado += Time.deltaTime;

        if (tiempoPasado < duracion && camaraPrincipal != null)
        {
            transform.position = Vector3.Lerp(transform.position, posicionA.position, tiempoPasado / duracion);
            camaraPrincipal.fieldOfView = Mathf.Lerp(camaraPrincipal.fieldOfView, valorCampoVision, tiempoPasado / duracion);
        }
        else if (camaraPrincipal != null)
        {
            transform.position = posicionA.position;
            camaraPrincipal.fieldOfView = valorCampoVision;
        }
    }
}
