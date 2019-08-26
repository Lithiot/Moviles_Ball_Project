using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpsManager : GenericSingleton<PickUpsManager>
{
    [SerializeField] private GameObject pickUpPrefab;
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 size;
    [SerializeField] private float spawnRate = 10;
    private float timer = 0;
    [SerializeField] private int initialPickUps = 5;

    public override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        for (int i = 0; i < initialPickUps; i++)
        {
            SpawnPickUps();
        }

        timer = spawnRate;
    }

    private void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0)
        {
            SpawnPickUps();
            timer = spawnRate;
        }
    }

    public void SpawnPickUps()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0.5f, Random.Range(-size.z / 2, size.z / 2));
        CreatePickUps(pos, Quaternion.identity);
    }

    public GameObject CreatePickUps(Vector3 pos, Quaternion rot)
    {
        GameObject aux = Instantiate(pickUpPrefab, pos, rot);
        return aux;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawCube(center, size);
    }
}
