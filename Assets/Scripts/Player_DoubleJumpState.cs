using UnityEngine;

public class Player_DoubleJumpState : Player_JumpState
{
    public Player_DoubleJumpState(PlayerController player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        player.AddAirJumpCounter();
    }
}