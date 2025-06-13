using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBulletManager : MonoBehaviour
{
    [SerializeField] private Transform BulletSpawnPoint;

    // Start is called before the first frame pdate
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    { 
        // todo add a way to trigger the shooting for the AI
    }

    private void Fire()
    {
        SpawnPhysicsBullet(transform);
    }
}
