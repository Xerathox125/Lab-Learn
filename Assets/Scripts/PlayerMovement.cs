using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public InputActionReference move;
    private PlayerInput PlayerInput;
    private InputAction Jump;
    private Ray rayo;
    private AudioSource AudioSource;

    private float horizontal, vertical;
    public float fuerza, fuerzaSalto;
    private float maxGroundedDistance = 0.6f;

    public float MaxGroundedDistance { get => maxGroundedDistance; set => maxGroundedDistance = value; }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        PlayerInput = GetComponent<PlayerInput>();
        AudioSource = GetComponent<AudioSource>();

        Jump = PlayerInput.actions.FindAction("Jump");
    }

    void Update()
    {
        rayo = new Ray(transform.position, Vector3.down);
        PlayerMovementNew();
    }

    /*
    void PlayerMovementOld()
    {
        Ray rayo = new Ray(transform.position, Vector3.down);

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.right * horizontal * fuerza);
        rb.AddForce(Vector3.forward * vertical * fuerza);

        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(rayo, 0.6f))
        {
            rb.AddForce(Vector3.up * fuerzaSalto);
        }
    }
    */

    void PlayerMovementNew()
    {   
        Vector2 direccion = move.action.ReadValue<Vector2>();
        rb.AddForce(direccion.x * fuerza, 0, direccion.y * fuerza);
    }

    private void PlayerJump(InputAction.CallbackContext context)
    {
        if (Physics.Raycast(rayo, maxGroundedDistance)) //el rayo tiene que ser un poco más largo que el radio de la bola, para que detecte el piso y pueda saltar
        {
            AudioSource.Play();
            rb.AddForce(Vector3.up * fuerzaSalto);
        }
    }

    private void OnEnable()
    {
        move.action.Enable(); 

        Jump.started += PlayerJump;
        Jump.Enable();
    }
      
    private void OnDisable()
    {
        move.action.Disable();

        Jump.started -= PlayerJump;
        Jump.Disable();  
    }
}




