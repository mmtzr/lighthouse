using Godot;
using System;

public partial class StateMachine : Node
{
    [Export] private Node currentState;
    [Export] private Node[] states;

    public override void _Ready()
    {
        currentState.Notification(5001);
    }

    public void SwitchStates<T>()
    {
        Node newState = null;

        foreach(Node state in states)
        {
            if (state is T)
            {
                newState = state;
            }
        }

        if (newState == null){return;}
        // disable old state
        currentState.Notification(GameConstants.NOTIFICATION_EXIT_STATE);
        // disable new state
        currentState = newState;
        currentState.Notification(GameConstants.NOTIFICATION_ENTER_STATE);
    }
}
