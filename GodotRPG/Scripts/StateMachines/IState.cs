using System;
using Godot;

public interface IState
{
    public void EnterState() {}
    public void Update(double delta) {}
    public void ExitState() {}
}