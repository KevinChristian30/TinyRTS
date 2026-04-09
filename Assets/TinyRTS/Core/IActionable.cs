using System.Collections.Generic;

namespace TinyRTS.Core
{
    public interface IActionable
    {
        void Action(ISet<ISelectable> selectable);
    }
}