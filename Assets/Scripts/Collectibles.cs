using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public AudioClip collectedClip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        DogController controller = other.GetComponent<DogController>();
        if (controller != null)
        {
            ScoreTextScript.itemAmount++;
            Debug.Log(ScoreTextScript.itemAmount);
            Destroy(gameObject);

            controller.PlaySound(collectedClip);

            if (ScoreTextScript.itemAmount ==10)
            {
                DogController.missionComplete = true;
                Debug.Log(DogController.missionComplete);
            }
        }
    }
}
