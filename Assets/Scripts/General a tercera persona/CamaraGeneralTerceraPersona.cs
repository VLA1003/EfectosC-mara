using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraGeneralTerceraPersona : MonoBehaviour
{
    public GameObject camaraGeneral;
    public GameObject camaraTerceraPersona;

    void Start()
    {
        camaraGeneral.SetActive(true);
        camaraTerceraPersona.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camaraTerceraPersona.SetActive(!camaraTerceraPersona.activeSelf);
        }
    }
}
