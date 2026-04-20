using UnityEngine;
using UnityEngine.AI;

public class DogAI : MonoBehaviour
{
    public bool toyInBowl;

    public Transform insidePoint;
    public Transform outsidePoint;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (toyInBowl)
            agent.SetDestination(insidePoint.position);
        else
            agent.SetDestination(outsidePoint.position);
    }
}