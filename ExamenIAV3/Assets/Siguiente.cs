using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siguiente : MonoBehaviour
{
    //creamos una herencia de la clase patrullaje llamada trulla
    public Patrullaje trulla;
    void Start()
    {
        //igualamos patrulla con el objeto findobjectoftype
        trulla = FindObjectOfType<Patrullaje>();
        //guarda una nueva posicion 
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        //agrega la posicion del nuevo punto a la lista que creamos en el codigo de patrullaje
        trulla.puntosMovimientos.Add(transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
