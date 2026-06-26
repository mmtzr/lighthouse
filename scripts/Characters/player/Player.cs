using Godot;
using System;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer animPlayerNode;
    [Export] public Sprite3D spriteNode;
    [Export] public StateMachine stateMachineNode;
    
    public Vector2 direction = new();


    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            GameConstants.INPUT_BWD, GameConstants.INPUT_FWD, GameConstants.INPUT_L, GameConstants.INPUT_R 
        );
    
    }
    public void Flip()
    {
        bool isNotMovingHorizontally = Velocity.X == 0;

        if (isNotMovingHorizontally) { return; }

        bool isMovingBack = Velocity.X<0;
        spriteNode.FlipH = isMovingBack;
    }
}
