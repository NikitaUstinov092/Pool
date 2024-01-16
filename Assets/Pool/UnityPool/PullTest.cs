using UnityEngine;


namespace Pool.UnityPool
{
    public class PullTest: MonoBehaviour
    {
        [SerializeField] private GameObject _prefab; 
        [SerializeField] private GameObject _objFromPool;
        private CustomUnityPool _pool;
        
        
        private void Start()
        {
            _pool = new CustomUnityPool(_prefab, 30);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _objFromPool = _pool.Get();
            }
            else if (Input.GetKeyDown(KeyCode.E) && _objFromPool!=null)
            {
                _pool.Release(_objFromPool);
            }
        }
    }
}