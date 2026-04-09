using Inputs;
using TinyRTS.Core;
using TinyRTS.Player;
using UnityEngine;

namespace Behaviours
{
    public class SelectableMonoBehaviour : MonoBehaviour, ILeftClickable
    {
        private Player _player;
        private ISelectable _selectable;

        public SelectableMonoBehaviour Init(ISelectable selectable)
        {
            _selectable = selectable;
            return this;
        }

        private void Start()
        {
            _player = PlayerMonoBehaviour.Instance.Player;
        }

        public void OnLeftClick()
        {
            _player.Select(_selectable);
        }
    }
}