using UnityEngine;

public class Player_JumpState : Player_AiredState
{
    public Player_JumpState(PlayerController player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        player.SetVelocity(rb.linearVelocity.x, player.jumpForce);
    }

    public override void Update()
    {
        base.Update();

        // Jump Cutting
        // if (player.input.Player.Jump.WasReleasedThisFrame())
        // {
        //     player.SetVelocity(rb.linearVelocity.x, 0);
        // }

        if (rb.linearVelocity.y < 0)
        {
            stateMachine.ChangeState(player.fallState);
        }

        if (player.wallDetected)
        {
            stateMachine.ChangeState(player.wallSlideState);
        }
    }
}