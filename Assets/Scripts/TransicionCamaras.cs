using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionCamaras : MonoBehaviour
{
    public GameObject camaraTerceraPersona;
    public GameObject camaraGeneral;

    void Start()
    {
        camaraTerceraPersona.SetActive(true);
        camaraGeneral.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camaraGeneral.SetActive(!camaraGeneral.activeSelf);
        }
    }
}
