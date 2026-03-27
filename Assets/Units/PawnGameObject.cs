using Behaviours;
using TinyRTS.Units;
using UnityEngine;

namespace Units
{
    public class PawnGameObject
    {
        private Pawn Pawn { get; set; }

        public PawnGameObject(Transform parent, Vector2 position, RuntimeAnimatorController pawnAnimatorController)
        {
            var go = new GameObject("Pawn");
            go.transform.SetParent(parent);
            go.transform.position = position;

            go.AddComponent<SpriteRenderer>();

            var animator = go.AddComponent<Animator>();
            animator.runtimeAnimatorController = pawnAnimatorController;

            var boxCollider = go.AddComponent<BoxCollider2D>();
            boxCollider.size = new Vector2(0.5f, 0.5f);

            Pawn = new Pawn();
            go.AddComponent<SelectableMonoBehaviour>().Init(Pawn);
        }
    }
}