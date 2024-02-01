using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] GameObject agent;

    private void Awake()
    {
        ObjectPoolManager.instance.ReservePool(agent, 20);
    }

    public void SpawnAgentButton(int count)
    {
        for (int i = 0; i < count; i++)
        {
            ObjectPoolManager.instance.GetObject(agent.name, true);
            //yield return new WaitForSeconds(0.01f);
        }
    }
}
