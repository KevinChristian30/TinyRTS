using System.Collections.Generic;
using TinyRTS.Units;
using Units;
using UnityEngine;

namespace Behaviours
{
    public class UnitSpawnerMonoBehaviour : MonoBehaviour
    {
        [SerializeField] private RuntimeAnimatorController pawnAnimatorController;

        void Start()
        {
            GameUnitSpawner spawner = new GameUnitSpawner();

            GameUnit pawn1 = new GameUnit
            {
                Unit = new Pawn(),
                AnimatorController = pawnAnimatorController,
                Position = new Vector2(1, 1),
                ColliderSize = new Vector2(0.5f, 0.5f)
            };

            GameUnit pawn2 = new GameUnit
            {
                Unit = new Pawn(),
                AnimatorController = pawnAnimatorController,
                Position = new Vector2(-1, -1),
                ColliderSize = new Vector2(0.5f, 0.5f)
            };

            List<GameUnit> units = new List<GameUnit> { pawn1, pawn2 };
            spawner.Spawn(units);
        }
    }
}