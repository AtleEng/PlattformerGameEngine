using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using CoreEngine;

namespace Engine
{
    public class PlayerMovement : Component, IScript
    {
        public override void Start()
        {
            System.Console.WriteLine("Player Start");
        }
        public override void Update(float delta)
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT))
            {
                Vector2 spawnPos = WorldSpace.GetVirtualMousePos();
                spawnPos = new Vector2((int)spawnPos.X, (int)spawnPos.Y);
                EntityManager.SpawnEntity(new Block(), spawnPos);
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP))
            {
                gameEntity.transform.size.Y += 2f;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN))
            {
                gameEntity.transform.size.Y -= 2f;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
            {
                gameEntity.transform.size.X += 2f;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT))
            {
                gameEntity.transform.size.X -= 2f;
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
            {
                gameEntity.transform.position.Y -= 1f;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
            {
                gameEntity.transform.position.Y += 1f;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
            {
                gameEntity.transform.position.X += 1f;
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
            {
                gameEntity.transform.position.X -= 1f;
            }
        }
    }
}