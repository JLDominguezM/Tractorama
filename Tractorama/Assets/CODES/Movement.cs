using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 10f;

    void Start()
    {

    }

    private void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float velocidadY = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;

        Vector3 posicion = transform.position;

        transform.position = new Vector3(velocidadX + posicion.x, velocidadY + posicion.y, posicion.z);

    }

}