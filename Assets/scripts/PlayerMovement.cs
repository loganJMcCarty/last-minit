using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed, rotationspeed;
    private float xInput, yInput;
    private Rigidbody rb;
    public GameObject boast;
    public GameObject fire;
    public GameObject braek;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, xInput *rotationspeed * Time.deltaTime );

        if (Input.GetMouseButton(1))
        {
            rb.AddForce(yInput * speed * transform.forward * 0.5f);
            boast.gameObject.SetActive(true);
            fire.gameObject.SetActive(false);
            Debug.Log("held");
        }
        if (Input.GetMouseButtonUp(1))
        {
            boast.gameObject.SetActive(false);
            fire.gameObject.SetActive(true);
            Debug.Log("realase");
        }
        if(Input.GetKey(KeyCode.Q))
        {
            braek.gameObject.SetActive(true);
            rb.linearVelocity = Vector3.zero;
            Debug.Log("break");
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            braek.gameObject.SetActive(false);
            Debug.Log("go");
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(yInput * speed * transform.forward);
    }
}
