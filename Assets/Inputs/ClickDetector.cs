using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class ClickDetector
    {
        private Camera Camera;

        public ClickDetector(Camera camera)
        {
            Camera = camera;
        }

        public GameObject GetClickedGameObject(InputAction.CallbackContext context)
        {
            if (!context.started)
            {
                return null;
            }

            Ray ray = Camera.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(ray);
            if (!rayHit.collider)
            {
                return null;
            }

            return rayHit.collider.gameObject;
        }
    }
}