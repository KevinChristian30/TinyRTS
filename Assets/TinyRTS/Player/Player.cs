using System.Collections.Generic;
using TinyRTS.Core;
using UnityEngine;

namespace TinyRTS.Player
{
    public class Player
    {
        private ISet<ISelectable> SelectedObjects = new HashSet<ISelectable>();

        public void Select(ISet<ISelectable> selectables)
        {
            SelectedObjects.Clear();
            SelectedObjects.UnionWith(selectables);
        }

        public void Select(ISelectable selectable)
        {
            SelectedObjects.Clear();
            SelectedObjects.Add(selectable);
            
            Debug.Log(SelectedObjects);
        }
    }
}