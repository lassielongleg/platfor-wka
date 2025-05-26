using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        //TODo sned info to player
        inventoey playerinventoey = null;
        collision.gameObject.GetComponent<inventoey>();

        Destroy(gameObject);
    }
}
