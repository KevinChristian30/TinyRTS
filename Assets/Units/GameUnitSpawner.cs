using System;
using System.Collections.Generic;
using Behaviours;
using UnityEngine;

namespace Units
{
    public class GameUnitSpawner
    {
        public void Spawn(GameUnit gameUnit)
        {
            var gameObject = new GameObject(gameUnit.Id.Value);

            SetPosition(gameObject, gameUnit.Position);
            SetAnimation(gameObject, gameUnit.AnimatorController);
            SetCollider(gameObject, gameUnit.ColliderSize);

            gameObject.AddComponent<SelectableMonoBehaviour>().Init(gameUnit.Unit);
        }

        public void Spawn(ICollection<GameUnit> gameUnits)
        {
            foreach (GameUnit gameUnit in gameUnits)
            {
                Spawn(gameUnit);
            }
        }

        private void SetPosition(GameObject gameObject, Vector2? position)
        {
            gameObject.transform.position = position ?? Vector2.zero;
        }

        private void SetAnimation(GameObject gameObject, RuntimeAnimatorController animatorController)
        {
            var animator = gameObject.AddComponent<Animator>();
            gameObject.AddComponent<SpriteRenderer>();
            animator.runtimeAnimatorController = animatorController;
        }

        private void SetCollider(GameObject gameObject, Vector2? size)
        {
            if (!size.HasValue)
            {
                return;
            }

            var boxCollider = gameObject.AddComponent<BoxCollider2D>();
            boxCollider.size = size.Value;
        }
    }
}