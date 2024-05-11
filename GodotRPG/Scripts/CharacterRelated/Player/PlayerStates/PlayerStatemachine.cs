using System;
using Godot;

public class PlayerStateMachine : Statemachine
{
    #region States
    public PlayerIdleState IdleState;
    public PlayerMoveState MoveState;
    #endregion

    public PlayerStateMachine(Player player)
    {
        this.IdleState = new PlayerIdleState(player);
        this.MoveState = new PlayerMoveState(player);
    }
}