using TinyRTS.Units;
using UnityEngine;

namespace Units
{
    public class GameUnit
    {
        public Unit Unit { get; set; }
        public RuntimeAnimatorController AnimatorController { get; set; }
        public Vector2? Position { get; set; }
        public Vector2? ColliderSize { get; set; }
    }
}