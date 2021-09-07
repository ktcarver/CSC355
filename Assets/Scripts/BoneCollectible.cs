using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollectible : DogController
{
    public AudioClip collectedClip;
    private int time = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        ComputeVelocity();
        DogController controller = other.GetComponent<DogController>();

        while (time < time+10)
        {
            maxSpeed = 10;

            time += 1;
        }

        maxSpeed = 7;

        /*
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }*/
    }
}
