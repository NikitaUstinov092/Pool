using UnityEngine;

namespace Pool.Scripts
{
    public class Input: MonoBehaviour
    {
        [SerializeField] private ShootController _shootController;
       
        private void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                _shootController.Fire();
            }
        }
    }
}