using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolly : MonoBehaviour
{
    public CinemachineVirtualCamera camaraPrincipal;
    
    public Transform posicionFinalDolly;
    public float valorCampoVisionDeseado = 15f;
    public float duracionDolly = 5f;
    public float contadorDolly = 0f;
    public float delayComienzoDolly = 1.5f;
    public float comienzoMovimiento = 5f;

    void Update()
    {
        contadorDolly += Time.deltaTime;

        if (contadorDolly > delayComienzoDolly)
        {
            transform.position = Vector3.Lerp(transform.position, posicionFinalDolly.position, duracionDolly * Time.deltaTime);
            camaraPrincipal.m_Lens.FieldOfView = Mathf.Lerp(camaraPrincipal.m_Lens.FieldOfView, valorCampoVisionDeseado, duracionDolly * Time.deltaTime);
        }

        if (contadorDolly > comienzoMovimiento)
        {
            Debug.Log("Ha llegado al punto de destino, comienza movimiento");
        }
    }
}
