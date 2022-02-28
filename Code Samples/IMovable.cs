using UnityEngine;


public interface IMovable
{
    public float Speed { get; set; }

    public void Move(Vector3 destination);
}