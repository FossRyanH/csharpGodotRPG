using System;
using Godot;

public interface IState
{
    public void EnterState() {}
    public void Update() {}
    public void ExitState() {}
}