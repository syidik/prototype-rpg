using UnityEngine;

public class Player_AiredState : EntityState
{
    public Player_AiredState(PlayerController player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();

        if (player.moveInput.x != 0)
        {
            player.SetVelocity(player.moveInput.x * (player.moveSpeed * player.inAirMoveMultiplier), rb.linearVelocity.y);
        }

        if (player.input.Player.Jump.WasPressedThisFrame() && CanAirJump())
        {
            stateMachine.ChangeState(player.doubleJumpState);
            // airJumpCounter += 1;
        }
    }

    private bool CanAirJump()
    {
        return player.airJumpCounter < player.maxAirJump;
    }
}