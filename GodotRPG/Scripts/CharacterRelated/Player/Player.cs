using Godot;
using System;
using System.Diagnostics;

public partial class Player : CharacterBody3D
{
    #region Components
    public PlayerStateMachine PlayerStates;
    [ExportCategory("Required Components")]
    [Export]
    public AnimationPlayer AnimPlayer { get; private set; }
    #endregion

    #region Movement Variables
    [ExportCategory("Movement Variables")]
    public Vector2 MovementVector = new Vector2();
    public float MoveSpeed;
    [Export]
    public float WalkSpeed { get; private set; } = 2.5f;
    [Export]
    public float SprintSpeed { get; private set; } = 7f;
    public bool IsSprinting { get; private set; } = false;
    #endregion

    public override void _Ready()
    {
        PlayerStates = new PlayerStateMachine(this);
        PlayerStates.Initialize(PlayerStates.IdleState);
    }

    public override void _PhysicsProcess(double delta)
    {
        PlayerStates.Update(delta);
    }

    public override void _Process(double delta)
    {
        // 
    }

    public override void _Input(InputEvent @event)
    {
        MovementVector = Input.GetVector("MoveLeft", "MoveRight", "MoveUp", "MoveDown");
    }
}
