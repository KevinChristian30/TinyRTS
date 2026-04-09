using TinyRTS.Core;
using TinyRTS.Units;
using UnityEngine;

namespace Units
{
    public class GameUnit : ISelectable
    {
        public GameUnitId Id { get; }
        public Unit Unit { get; set; }
        public RuntimeAnimatorController AnimatorController { get; set; }
        public Vector2? Position { get; set; }
        public Vector2? ColliderSize { get; set; }
        public GameObject GameObject { get; set; }

        public GameUnit(GameUnitId id)
        {
            Id = id;
        }
    }
}