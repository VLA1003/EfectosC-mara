using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicaCamara : MonoBehaviour
{
    public CinemachineVirtualCamera camaraDolly;
   
    public Transform posicionFinalDolly;
    public float valorCampoVisionFinal = 15f;
    public float duracionDolly = 5f;
    public float contadorDolly = 0f;
    public float delayComienzoDolly = 1.5f;
    public float comienzoMovimiento = 5f;

    public CinemachineVirtualCamera camaraTrack;
    private CinemachineTrackedDolly camaraTrackDolly;
    public float velocidadDesplazamientoTrack = 1;
    public float contadorTrack = 0f;

    public GameObject camaraPaneo;

    private void Start()
    {
        camaraTrackDolly = camaraTrack.GetCinemachineComponent<CinemachineTrackedDolly>();
        camaraTrack.gameObject.SetActive(false);
        camaraPaneo.SetActive(false);
    }

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

        else
        {
            camaraTrack.gameObject.SetActive(true);
            camaraTrackDolly.m_PathPosition += velocidadDesplazamientoTrack * Time.deltaTime;
        }
        if (camaraTrackDolly.m_PathPosition >= 5)
        {
            camaraPaneo.SetActive(true);
            camaraTrackDolly.gameObject.SetActive(false);
        }

    }

}
