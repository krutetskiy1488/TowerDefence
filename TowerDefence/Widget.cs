using System;
using System.Collections.Generic;
using System.Text;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace TowerDefence
{
    public abstract class Widget : Transformable, Drawable
    {


        public void Draw(RenderTarget target, RenderStates states)
        {
            throw new NotImplementedException();
        }
    }
}
