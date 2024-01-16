using UnityEngine;

namespace Pool.Scripts
{
    public class ShootController: MonoBehaviour
    {
        [SerializeField] private PoolBullets _pool;
        [SerializeField] private Transform _firePoint;
        public void Fire()
        {
            GameObject bullet = _pool.GetAvailableGameObject();
           
            bullet.transform.position = _firePoint.position;
            bullet.transform.rotation = _firePoint.rotation;
            
            bullet.SetActive(true);
        }
    }
}