using System;
using Godot;

public class PlayerMoveState : PlayerBaseState
{
    public PlayerMoveState(Player player) : base(player)
    {
    }

    public override void EnterState()
    {
        GD.Print("Entering the Movement State friend");
        _player.AnimPlayer.Play("Move");
        _player.MoveSpeed = _player.WalkSpeed;
    }

    public override void Update()
    {
        _player.Velocity = new(_player.MovementVector.X, 0f, _player.MovementVector.Y);
        _player.Velocity *= _player.MoveSpeed;

        _player.MoveAndSlide();
    }
}