using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetToy : MonoBehaviour
{
    public FishingRod fishingRod;
    public bool hooked = false;
    public GameObject toy;

    void Update()
    {
        if (hooked == true)
        {
            toy.transform.position = fishingRod.GetHookPosition();
            if (fishingRod.GetHookPosition().y >= 5.0f)
            {
                Destroy(toy);
                hooked = false;
            }
        }
    }
    
    private void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log ("triggered");
        if (other.CompareTag("Toy"))
        {
            toy = other.gameObject;
            hooked = true;
        }
    }
}
