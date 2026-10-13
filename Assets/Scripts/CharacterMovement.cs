using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //Variables se escriben en camelCase
    //Los métodos, clases y funciones en PascalCase

    Rigidbody rb; //declara la variable
    private Vector3 movementDirection; 

    [Header("Movement Properties")]
    [SerializeField] private float horizontalMovement = 0;
    [SerializeField] private float forwardMovement = 0;
    [SerializeField] private float movementVelocity = 15;

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        movementDirection = new Vector3(horizontalMovement, 0, forwardMovement);
    }


    void Update()
    {
        
        horizontalMovement = Input.GetAxisRaw("Horizontal");
        forwardMovement = Input.GetAxisRaw("Vertical");
        
        movementDirection = new Vector3(horizontalMovement, 0, forwardMovement).normalized;
    }

    private void FixedUpdate()
    {
        
        rb.linearVelocity = new Vector3(movementDirection.x * movementVelocity, rb.linearVelocity.y, movementDirection.z * movementVelocity);
        
        /*
         * ForceMode.Acceleration; Aceleracion constante -- Un coche
         * ForceMode.Impulse; De un solo impulso -- Si me empujan en un hielo
         * ForceMode.VelocityChange; Cambia la velocidad del rigidbody -- si voy a una velocidad, se establece una velocidad concreta
         * ForceMode.Force; Añade una fuerza -- el da un empujon
         */
    }
}