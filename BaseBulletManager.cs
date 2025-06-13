using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBulletManager : MonoBehaviour
{
    [Header("Physics Bullets")]
    [SerializeField] private PhysicsBullet PhysicsBulletperfab;

    private void SpawnPhysicsBullet(Transform shootersTransform)
    { 
        // does not call collisioc until physics systam collides

        PhysicsBullet spawnedBillet = Instantiate(PhysicsBulletperfab, Cam.transform.position, Cam.transform.rotation);
        spawnedBillet.Initialize(this);
    }

    public void OnProjectileCollision(Vector3 positon, Vector3 rotation)
    {
        // do stuff


        SpawnParticle(positon, rotation);
    }

    public void SpawnParticle(Vector3 position, Vector3 rotation)
    {

        Instantiate(Bulletparticle, position, Quaternion.Euler(rotation));
    }
}
