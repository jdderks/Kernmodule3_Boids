using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
public class FlockAgent : MonoBehaviour
{
    CapsuleCollider agentCollider;
    public CapsuleCollider AgentCollider { get { return agentCollider; } }

    void Start()
    {
        agentCollider = GetComponent<CapsuleCollider>();
    }

    public void Move(Vector2 velocity)
    {
        transform.up = velocity;
        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}
