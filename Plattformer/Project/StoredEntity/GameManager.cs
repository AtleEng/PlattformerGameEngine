using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using CoreEngine;

namespace Engine
{
    public class GameManager : GameEntity
    {
        public override void OnInnit()
        {
            EntityManager.SpawnEntity(new Player(), Vector2.Zero);
        }
    }
}