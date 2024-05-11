using System;
using Godot;

[Serializable]
public class Statemachine
{
    public IState CurrentState { get; private set; }

    public event Action<IState> stateChanged;

    public void Initialize(IState state)
    {
        if (CurrentState == null)
        {
            CurrentState = state;
        }

        state?.EnterState();
        stateChanged?.Invoke(state);
    }

    public void Update(double delta)
    {
        if (CurrentState != null)
        {
            CurrentState.Update();
        }
    }

    public void ChangeState(IState nextState)
    {
        CurrentState?.ExitState();
        CurrentState = nextState;
        nextState.EnterState();

        stateChanged?.Invoke(nextState);
    }
}