using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Velocidad = 5f;
    private CharacterController chController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    private void Move()
    {
        //input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 input = new Vector3(horizontal, 0, vertical);
        input = Vector3.ClampMagnitude(input, 1f);

        //4Calcular la veocidad
        Vector3 targetVelocity = input * Velocidad;

        //6
        chController.Move(targetVelocity * Time.deltaTime);
    }

    //Recoger el input--WASD//Joystick
    //obtener las coordenadas o direcciones de la cámara
    //Calcular la dirección del movimiento
    //Calculos de la velocidad
    //FANTASÍA aceleraciones, frenos, cambios de dirección, BLABALBLABLABLABLAL
    //Mover al personaje
}