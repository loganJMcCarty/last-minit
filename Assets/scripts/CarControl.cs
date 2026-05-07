using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEditorInternal;

public class CarControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private static CarControl instance;
   public static CarControl Instance { get { return instance; } }

    public Slider healthbar;
    public TMP_Text Health;
    public static event Action OnPlayerDeath;
    public int maxHealth = 0;
    public int health = 100;
    private int currentPoints = 0;
    public TextMeshProUGUI score;
    

    private void Awake()
    {
     instance = this;   
    }

    void Start()
    {
        maxHealth = health;
       score.text = "Score: " + currentPoints.ToString();
    }

    public void AddPoints(int pointsToAdd)
    {
        currentPoints += pointsToAdd;
    }

    private void OnEnable()
    {
        OnPlayerDeath += DisablePlayerMovement;

    }

    private void OnDisable()
    {
        OnPlayerDeath -= DisablePlayerMovement;
    }
    // Update is called once per frame
    void Update()
    {
        Health.text = health + " - " + maxHealth;
        healthbar.value = (float)health / (float)maxHealth;

        score.text = "Score - " + currentPoints.ToString();

        if (health <= 0 )
        {
            healthbar.gameObject.SetActive(false);
           
            //Destroy(gameObject, 7f);  //dont like this but keeping it just in case. 
            Debug.Log(" You are daed not big suprise");
            OnPlayerDeath?.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tesla")
        {
            health = health - 10;
        }
    }

    private void DisablePlayerMovement()
    {

        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<Shoot>().enabled = false;
        //playerInput.DeactivateInput();
        Cursor.lockState = CursorLockMode.None;

    }

    private void EnabledPlayerMovement()
    {

        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Shoot>().enabled = true;
        //playerInput.ActivateInput();
        Cursor.lockState = CursorLockMode.Locked;
    }
}
