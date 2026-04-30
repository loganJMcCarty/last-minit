using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Windows;

public class EnemyAi : MonoBehaviour
{
    public float speed, rotationspeed;
    private NavMeshAgent ai;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (ai != null && ai.isActiveAndEnabled && player != null)
        {
            ai.SetDestination(player.position);
        }
    }

    
}
