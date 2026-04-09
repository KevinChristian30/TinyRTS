using System.Collections.Generic;
using Inputs;
using TinyRTS.Core;
using TinyRTS.Player;
using Units;
using UnityEngine;

namespace Behaviours
{
    public class NavigableMonoBehaviour : MonoBehaviour, IRightClickable
    {
        private Player _player;
        private Camera _camera;

        private void Start()
        {
            _player = PlayerMonoBehaviour.Instance.Player;
            _camera = Camera.main;
        }

        public void OnRightClick(Position position)
        {
            Vector3 worldPosition = _camera.ScreenToWorldPoint(new Vector3(position.X, position.Y, 0));
            worldPosition.z = 0;

            ISet<ISelectable> selectedObjects = _player.GetSelectedObjects();
            foreach (ISelectable selectedObject in selectedObjects)
            {
                if (selectedObject is GameUnit gameUnit)
                {
                    gameUnit.Position = new Vector2(worldPosition.x, worldPosition.y);
                    gameUnit.GameObject.transform.position = worldPosition;
                }
            }
        }
    }
}