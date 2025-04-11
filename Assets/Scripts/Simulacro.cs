using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro : MonoBehaviour
{

    public string gustoHelado;
    public float gramos;
    float precioGramo = 1.25f;
    float precioFinal;
    void Start()
    {
        

        if (gramos < 250 || gramos > 3000)
        {
            Debug.Log("ERROR: Cantidad de gramos menor a 250 o mayor a 3000");
        } else
        {
            if (gustoHelado == "CHO" || gustoHelado == "DDL")
            {
                precioFinal = precioGramo * gramos;
                Debug.Log("Costo total: " + precioFinal + "$");
            } else if (gustoHelado == "FRU")
            {
                precioFinal = precioGramo * gramos * 0.90f;
                Debug.Log("Costo total: " + precioFinal + "$");
            } else
            {
                Debug.Log("ERROR: Codigo no valido");
            }
        }
    }

    void Update()
    {
        
    }
}
