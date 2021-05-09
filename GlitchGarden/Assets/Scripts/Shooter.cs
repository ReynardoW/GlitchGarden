using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;

    
    private void Start()
    {
        SetLaneSpawner();
    }
    void Update()
    {
        if(IsAttackerInLane())
        {
            Debug.Log("Pew Pew");
        }
        else
        {
            Debug.Log("NO SHOOT");
        }
    }
    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, gun.transform.rotation);
    }
    private void SetLaneSpawner()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in attackerSpawners)
        {
            bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - gun.transform.transform.position.y) <= Mathf.Epsilon);
            if(IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }
    private bool IsAttackerInLane()
    {
        if(myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
