using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDelete : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
     if(collision.otherCollider.TryGetComponent(out BallDelete ball))
        {
            Destroy(gameObject);
        }
    }
}
