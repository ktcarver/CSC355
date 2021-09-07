using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItems : MonoBehaviour
{
    //public AudioClip collectedClip;
    protected int itemTracker = 0;
    protected bool missionComplete = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*DogController controller = other.GetComponent<DogController>();
        
        if (controller != null)
        {
            totalItems = totalItems - 1;
            Debug.Log(totalItems);

            itemTracker += 1;
            Debug.Log(itemTracker);
            Destroy(gameObject);
            
            if(totalItems ==0)
            {
                missionComplete = true;
                Debug.Log(missionComplete);
            }
        }
        */
    }
}
