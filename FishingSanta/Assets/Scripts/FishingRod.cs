using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    public float rodSpeed = 2.0f;
    private float x_pos = 0.8f;
    private float y_pos = 5.0f;
    public LineRenderer rod;
    public GameObject hook;
    // public bool isCasting = false;
    public GameObject toy;

    // Start is called before the first frame update
    void Start()
    {
        rod = GetComponent<LineRenderer>();
        rod.positionCount = 2;
        rod.SetPosition(0, new Vector3 (x_pos, y_pos, 0f));
        rod.SetPosition(1, new Vector3 (x_pos, y_pos - 2, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))  
        {
            ExtendRod();
        }
        else
        {
            ReelInRod();
        }

        // if (present != null)
        // {
        //     // Move the hooked present with the hook
        //     present.transform.position = hook.transform.position;

        //     // Despawn the fish when it reaches the top
        //     if (hook.transform.position.y >= 10.0f)
        //     {
        //         Destroy(present);
        //         present = null;
        //     }
        // }
    }

    private void ExtendRod()
    {
        Vector3 currentPosition = rod.GetPosition(1);
        if (currentPosition.y > -5.0f) 
        {
            currentPosition.y -= rodSpeed * Time.deltaTime;
            rod.SetPosition(1, currentPosition);     
        }
        hook.transform.position = rod.GetPosition(1);
    }

    private void ReelInRod() 
    {
        Vector3 currentPosition = rod.GetPosition(1);
        if (currentPosition.y < 5.0f) {
            currentPosition.y += rodSpeed * Time.deltaTime;
            rod.SetPosition(1, currentPosition);
        }
        hook.transform.position = rod.GetPosition(1);
    }

    public Vector3 GetHookPosition()
    {
        return hook.transform.position;
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.CompareTag("Toy"))
    //     {
    //         // Hook the toy when it touches the hook
    //         toy = other.gameObject;

    //         // Move the hooked toy with the hook
    //         toy.transform.position = hook.transform.position;

    //         // Despawn the toy when it reaches the top
    //         if (hook.transform.position.y >= 5.0f)
    //         {
    //             Destroy(toy);
    //             toy = null;
    //         }
    //     }
    // }

}
