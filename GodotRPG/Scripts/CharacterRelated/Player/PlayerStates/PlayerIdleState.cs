using System;
using Godot;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState(Player player) : base(player)
    {
    }

    public override void EnterState()
    {
        GD.Print("Now entering the Idle state, y'all!");
        _player.AnimPlayer.Play("Idle");
        _player.MoveSpeed = 0f;
    }

    public override void Update()
    {
        if (_player.MovementVector != Vector2.Zero)
        {
            _player.PlayerStates.ChangeState(_player.PlayerStates.MoveState);
        }
    }
}