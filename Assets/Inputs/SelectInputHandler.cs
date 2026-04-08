using Behaviours;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class SelectInputHandler : MonoBehaviour
    {
        private Camera _camera;

        [SerializeField] private PlayerMonoBehaviour player;

        private void Awake()
        {
            _camera = Camera.main;
        }

        public void OnClick(InputAction.CallbackContext context)
        {
            if (!context.started)
            {
                return;
            }

            Ray ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(ray);
            if (!rayHit.collider)
            {
                return;
            }

            HandleSelect(rayHit.collider.gameObject);
        }

        private void HandleSelect(GameObject go)
        {
            IClickable clickedObject = go.GetComponent<IClickable>();
            if (clickedObject == null)
            {
                return;
            }

            clickedObject.OnClick();
        }
    }
}