using UnityEngine;

public class ToyMovementScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone;
    public Transform toy;

    private void Update()
    {
        toy.position = transform.position + Vector3.right * (moveSpeed * Time.deltaTime);

        if (toy.position.x > deadZone)
        {
            Destroy(gameObject);
        }
    }
}