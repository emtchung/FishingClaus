using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToySpawnerScript : MonoBehaviour
{
    public GameObject toy;
    public float spawnRate;
    private float _timer;
    public float lowestPoint;
    public float highestPoint;
    public List<Sprite> spriteList;

    // Start is called before the first frame update
    void Start()
    {
        SpawnToy();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= spawnRate)
        {
            _timer = 0.0f;
            SpawnToy();
        }
    }

    void SpawnToy()
    {
        GameObject newToy = Instantiate(toy, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        newToy.GetComponent<SpriteRenderer>().sprite = spriteList[Random.Range(0, spriteList.Count)];
    }
}