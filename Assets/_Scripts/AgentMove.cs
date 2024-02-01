using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    [SerializeField] private Vector2 target;
    [SerializeField] private Vector2 begin;
    [SerializeField] private NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;   
    }

    private void OnEnable()
    {
        SetAgentPos();
    }

    private void OnDisable()
    {
        this.transform.position = new Vector3(begin.x + Random.Range(-1, 1), begin.y + Random.Range(-1, 1), 0);
    }
    private void Update()
    {
        OnMove();
    }

    void SetAgentPos()
    {
        agent.SetDestination(new Vector3(target.x, target.y, 0));
    }

    void OnMove()
    {
        if (Vector2.Distance(this.transform.position, target) < 0.5f)
        {
            this.gameObject.SetActive(false);
        }
    }



}
