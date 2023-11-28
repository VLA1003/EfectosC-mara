using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamaraDolly : MonoBehaviour
{
    public CinemachineVirtualCamera camaraDolly;
    
    public float contadorDolly = 0f;
    public Transform posicionFinalDolly;
    public float valorCampoVisionFinal = 15f;
    public float duracionDolly = 5f;
    public float comienzoMovimiento = 5f;
    public float delayComienzoDolly = 1.5f;


    void Update()
    {
        contadorDolly += Time.deltaTime;
        if (contadorDolly <= delayComienzoDolly)
        {

        }

        else if (contadorDolly <= comienzoMovimiento)
        {
            camaraDolly.transform.position = Vector3.Lerp(camaraDolly.transform.position, posicionFinalDolly.position, duracionDolly * Time.deltaTime);
            camaraDolly.m_Lens.FieldOfView = Mathf.Lerp(camaraDolly.m_Lens.FieldOfView, valorCampoVisionFinal, duracionDolly * Time.deltaTime);
        }
    }
}
