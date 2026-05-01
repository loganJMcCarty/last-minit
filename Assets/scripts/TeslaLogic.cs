using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class TeslaLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider healthbar;
    public TMP_Text Health;
    public int maxHealth = 0;
    public int health = 100;
    public GameObject boom;
    public GameObject Light;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        maxHealth = health;

    }

    // Update is called once per frame
    void Update()
    {
        Health.text = health + " - " + maxHealth;
        healthbar.value = (float)health / (float)maxHealth;

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
            health = health - 1;
            
        }
    }
}
