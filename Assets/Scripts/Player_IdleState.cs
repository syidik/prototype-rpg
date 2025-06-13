using UnityEngine;

public class Player_IdleState : Player_GroundedState
{
    public Player_IdleState(PlayerController player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        player.SetVelocity(0, rb.linearVelocity.y);
    }

    public override void Update()
    {
        base.Update();

        if (player.moveInput.x != 0 && !player.input.Player.Jump.WasPerformedThisFrame())
        {
            stateMachine.ChangeState(player.moveState);
        }
    }
}