using UnityEngine;

public class BulletCollide : MonoBehaviour
{
   private const string STOP_TAG_NAME = "Finish";
   private void OnCollisionEnter(Collision other)
   {
      if(other.collider.CompareTag(STOP_TAG_NAME))
         gameObject.SetActive(false);
   }
}
