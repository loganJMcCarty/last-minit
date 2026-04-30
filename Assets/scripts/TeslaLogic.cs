using UnityEngine;
using UnityEngine.AI;

public class TeslaLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 100;
    public GameObject boom;
    public GameObject Light;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            boom.gameObject.SetActive(true);
            Light.gameObject.SetActive(false);
            navMeshAgent.enabled = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "bully")
        {
            health = health - 25;
            
        }
    }
}
