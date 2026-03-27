using TinyRTS.Core;
using TinyRTS.Player;
using UnityEngine;

namespace Behaviours
{
    public class SelectableMonoBehaviour : MonoBehaviour, IClickable
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

        public void OnClick()
        {
            _player.Select(_selectable);
        }
    }
}