using System;
using System.Collections.Generic;
using UnityEngine;

public class PoolBullets : MonoBehaviour
{
    [SerializeField] private List<GameObject> _bullets;

    public GameObject GetAvailableGameObject()
    {
        foreach (GameObject bullet in _bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                return bullet;
            }
        }
        return InstantiateBullet();
    }
    private GameObject InstantiateBullet(int index = 0)
    {
        GameObject bulletClone = Instantiate(_bullets[index]);
        bulletClone.SetActive(false);
        _bullets.Add(bulletClone);
        
        return bulletClone;
    }
    
}
