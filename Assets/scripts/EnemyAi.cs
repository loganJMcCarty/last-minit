using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Windows;

public class EnemyAi : MonoBehaviour
{
    public float speed;
    private NavMeshAgent ai;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
       speed += 0.1f * Time.deltaTime;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (ai != null && ai.isActiveAndEnabled && player != null)
        {
            ai.SetDestination(player.position);
            
        }
    }

    
}
