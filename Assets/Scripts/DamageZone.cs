using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerStay2D(Collider2D other)
    {
        DogController controller = other.GetComponent<DogController>();
        
        if (controller != null)
        {
            controller.ChangeHealth(-1);
            controller.PlaySound(collectedClip);
        }
    }
}
