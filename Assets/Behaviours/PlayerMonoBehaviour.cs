using TinyRTS.Player;
using UnityEngine;

namespace Behaviours
{
    public class PlayerMonoBehaviour : MonoBehaviour
    {
        public static PlayerMonoBehaviour Instance { get; private set; }

        public Player Player { get; private set; }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            Player = new Player();
        }
    }
}