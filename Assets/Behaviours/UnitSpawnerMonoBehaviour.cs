using TinyRTS.Units;
using UnityEngine;

namespace Behaviours
{
    public class UnitSpawnerMonoBehaviour : MonoBehaviour
    {
        void Start()
        {
            SpawnPawn(transform.position);
        }

        private void SpawnPawn(Vector3 position)
        {
            var go = new GameObject("Pawn");
            go.transform.position = position;

            go.AddComponent<BoxCollider2D>();

            var pawn = new Pawn();
            go.AddComponent<SelectableMonoBehaviour>().Init(pawn);
        }
    }
}