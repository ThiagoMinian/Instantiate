using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public int cantclones;
    public GameObject objectToClone;

    public void CloneObject()
    {
        int contador = 0;
        while (contador < cantclones)
        {
            Instantiate(objectToClone);
            contador++; 

        }

    }
}
