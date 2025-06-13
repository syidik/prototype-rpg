using UnityEngine;

public class Player_AnimationTriggers : MonoBehaviour {
    private PlayerController player;
    void Awake()
    {
        player = GetComponentInParent<PlayerController>();
    }

    public void CurrentStateTrigger()
    {
        player.CallAnimationTrigger();
    }
}