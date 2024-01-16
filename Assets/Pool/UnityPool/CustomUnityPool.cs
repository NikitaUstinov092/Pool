using UnityEngine;
using UnityEngine.Pool;

public class CustomUnityPool 
{
   private ObjectPool<GameObject> _pool;
   private GameObject _prefab;

   public CustomUnityPool(GameObject prefab, int count)
   {
      _prefab = prefab;
      _pool = new ObjectPool<GameObject>(OnCreate, OnGet, OnRelease, OnDestroy, false, count);
   }
   public GameObject Get()
   {
      return _pool.Get();
   }

   public void Release(GameObject obj)
   {
      _pool.Release(obj);
   }
   
   private void OnDestroy(GameObject obj)
   {
      GameObject.Destroy(obj);
   }
   private void OnRelease(GameObject obj)
   {
      obj.SetActive(false);
   }
   private void OnGet(GameObject obj)
   {
      obj.SetActive(true);
   }
   private GameObject OnCreate()
   {
      return GameObject.Instantiate(_prefab);
   }
}
