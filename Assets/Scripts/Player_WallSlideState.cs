using UnityEngine;

public class Player_WallSlideState : EntityState
{
    public Player_WallSlideState(PlayerController player, StateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Update()
    {
        base.Update();

        if (player.groundDetected)
        {
            stateMachine.ChangeState(player.idleState);
        }

        if (!player.wallDetected && !player.groundDetected)
        {
            stateMachine.ChangeState(player.fallState);
        }
    }
}