using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetToy : MonoBehaviour
{
    public FishingRod fishingRod;
    public bool hooked = false;
    public GameObject toy;
    public LogicScript ls;

    void Update()
    {
        if (hooked == true)
        {
            toy.transform.position= new Vector3(fishingRod.GetHookPosition().x, fishingRod.GetHookPosition().y - 2.0f, 0f);
            if (fishingRod.GetHookPosition().y >= 5.0f)
            {
                Destroy(toy);
                hooked = false;
                ls.AddScore();
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
