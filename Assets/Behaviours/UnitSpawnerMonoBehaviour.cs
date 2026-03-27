using Units;
using UnityEngine;

namespace Behaviours
{
    public class UnitSpawnerMonoBehaviour : MonoBehaviour
    {
        [SerializeField] private RuntimeAnimatorController pawnAnimatorController;

        void Start()
        {
            new PawnGameObject(transform, new Vector2(1, 1), pawnAnimatorController);
            new PawnGameObject(transform, new Vector2(-1, -1), pawnAnimatorController);
        }
    }
}