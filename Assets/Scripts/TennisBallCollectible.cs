using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBallCollectible : CollectibleItems
{
    
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        DogController controller = other.GetComponent<DogController>();

        if (controller != null)
        {
            itemTracker++;
            Debug.Log(itemTracker);
            Destroy(gameObject);

            if (itemTracker == 2)
            {
                missionComplete = true;
                Debug.Log(missionComplete);
            }
        }
    }
}
