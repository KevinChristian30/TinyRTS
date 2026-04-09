using Behaviours;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class LeftClickInputHandler : MonoBehaviour
    {
        private Camera _camera;

        [SerializeField] private PlayerMonoBehaviour player;

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
                HandleSelect(clickedGameObject);
            }
        }

        private void HandleSelect(GameObject go)
        {
            ILeftClickable clickedObject = go.GetComponent<ILeftClickable>();
            if (null == clickedObject)
            {
                return;
            }

            clickedObject.OnLeftClick();
        }
    }
}