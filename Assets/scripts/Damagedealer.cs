using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagedealer : MonoBehaviour
{
    public float damage = 40;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

       playrhealh health = collision.gameObject.GetComponent<playrhealh>();

        if (health == null )
        {
            return;
        }

        health.TakeDamage(damage);
    }
}
