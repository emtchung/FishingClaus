using UnityEngine;

namespace Scripts1
{
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
                Debug.Log("Toy Deleted");
                Destroy(gameObject);
            }
        }
    }
}