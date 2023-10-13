using System.Collections.Generic;
using System.Numerics;
using Engine;

namespace Engine
{
    public abstract class Component
    {
        public GameEntity gameEntity = new();

        public virtual void Start() { }
        public virtual void Update(float delta) { }
        public virtual void OnDestroy() { }
        public virtual void OnTrigger() { }
    }
    public class GameEntity
    {
        public string name = "GameEntity";
        public Transform transform = new(Vector2.Zero, Vector2.One);
        public Dictionary<Type, Component> components = new();

        public bool HasComponent<T>()
        {
            return components.ContainsKey(typeof(T));
        }
        public T? GetComponent<T>() where T : Component
        {
            if (components.TryGetValue(typeof(T), out var component))
            {
                return (T)component;
            }
            return null;
        }
        public void AddComponent<T>(Component component) where T : Component
        {
            component.gameEntity = this;
            components.Add(typeof(T), component);
        }
        public void RemoveComponent<T>()
        {
            components.Remove(typeof(T));
        }
    }
    public class Transform
    {
        public Transform(Vector2 position, Vector2 size)
        {
            this.position = position;
            this.size = size;
        }
        public Vector2 position;
        public Vector2 size;
    }
    public abstract class GameSystem
    {
        public List<Component> validComponents = new();
        public virtual void Start() { }
        public virtual void Update(float delta) { }
    }

    public interface IScript { }
}