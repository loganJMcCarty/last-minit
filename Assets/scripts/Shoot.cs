using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform lfirePosition;
    public Transform rfirePosition;
    bool isFiring;
    private bool canFire = true;
    public GameObject bully;
    public GameObject bang;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        if(isFiring)
        {
            GameObject clone = Instantiate(bully, rfirePosition.position, rfirePosition.rotation);
            GameObject clone2 = Instantiate(bully, lfirePosition.position, lfirePosition.rotation);
            
        }
        
       
    }

    public void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFiring = true;
            bang.gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            isFiring = false;
            bang.gameObject.SetActive(false);
        }
    }

    
}
