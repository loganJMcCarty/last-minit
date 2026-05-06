using UnityEngine;

public class TeslaKiller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed = 2;
    private Rigidbody rb;
    public TeslaLogic tesla;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = transform.forward * speed;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bad")
        {
            tesla = other.gameObject.GetComponent<TeslaLogic>();
            
             Destroy(gameObject);
        }
    }
}
