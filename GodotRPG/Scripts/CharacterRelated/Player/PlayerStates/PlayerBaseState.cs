using System;
using Godot;

public class PlayerBaseState : IState
{
    protected Player _player;

    public PlayerBaseState(Player player)
    {
        _player = player;
    }

    public virtual void EnterState() {}
    public virtual void Update() {}
    public virtual void ExitState() {}
}