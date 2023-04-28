using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{ 
    [SerializeField] private Transform target; 
    [SerializeField] private float chaseRange = 10f;
    [SerializeField] private float chaseSpeed = 5f;

    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float distanceToTarget = Vector2.Distance(transform.position, target.position);

        if (distanceToTarget < chaseRange)
        {
            Vector2 direction = (target.position - transform.position).normalized;
            rigidbody.velocity = direction * chaseSpeed; 
            
        }
        else
        {
            rigidbody.velocity = Vector2.zero;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(GiveDamage());
        }
    }

    private IEnumerator GiveDamage()
    {
        yield return new WaitForSeconds(1);
        target.GetComponent<PlayerMovement>().health -= 5;
        Debug.Log(target.GetComponent<PlayerMovement>().health);
    }
}
