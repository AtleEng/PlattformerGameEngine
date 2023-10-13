using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using CoreEngine;

namespace Engine
{
    public class Player : GameEntity
    {
        public override void OnInnit()
        {
            AddComponent<PlayerMovement>(new PlayerMovement());
            AddComponent<Sprite>(new Sprite());

        }
    }
}