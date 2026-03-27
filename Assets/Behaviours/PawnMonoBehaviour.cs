using TinyRTS.Player;
using TinyRTS.Units;
using UnityEngine;

namespace Behaviours
{
    public class PawnMonoBehaviour : MonoBehaviour, IClickable
    {
        private Player _player;
        private Pawn _pawn;

        private void Awake()
        {
            _pawn = new Pawn();
        }

        private void Start()
        {
            _player = PlayerMonoBehaviour.Instance.Player;
        }

        public void OnClick()
        {
            _player.Select(_pawn);
        }
    }
}