using Behaviours;
using TinyRTS.Core;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class RightClickInputHandler : MonoBehaviour
    {
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        public void OnClick(InputAction.CallbackContext context)
        {
            ClickDetector clickDetector = new ClickDetector(_camera);
            GameObject clickedGameObject = clickDetector.GetClickedGameObject(context);

            if (null != clickedGameObject)
            {
                HandleAction(clickedGameObject);
            }
        }

        private void HandleAction(GameObject go)
        {
            IRightClickable clickedObject = go.GetComponent<IRightClickable>();
            if (null == clickedObject)
            {
                return;
            }
            
            Position position = new Position(Mouse.current.position.x.value, Mouse.current.position.y.value);
            clickedObject.OnRightClick(position);
        }
    }
}