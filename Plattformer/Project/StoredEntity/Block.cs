using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using CoreEngine;

namespace Engine
{
    public class Block : GameEntity
    {
        public override void OnInnit()
        {
            Sprite sprite = new()
            {
                colorTint = Color.BLUE
            };
            AddComponent<Sprite>(sprite);

        }
    }
}