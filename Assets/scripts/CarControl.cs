using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CarControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider healthbar;
    public TMP_Text Health;

    public int maxHealth = 0;

    public int health = 100;

    
    void Start()
    {
        maxHealth = health;
       
    }

    // Update is called once per frame
    void Update()
    {
        Health.text = health + " - " + maxHealth;
        healthbar.value = (float)health / (float)maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tesla")
        {
            health = health - 10;
        }
    }
}
