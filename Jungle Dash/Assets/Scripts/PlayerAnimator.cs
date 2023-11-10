using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string RUNNING = "Running";
    private const string HIT = "HitMade";
    private const string FRONTHIT = "FrontHit";
    private const string BACKHIT = "BackHit";
    private const string UPHIT = "UpHit";
    private const string DOWNHIT = "DownHit";
    private const string THROWITEM = "ThrowItem";
    private const string DAMAGE = "DamageTaken";
    private const string DEAD = "Alive";
    [SerializeField] private PlayerController player;

    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }
    private void Update() {
        animator.SetBool(RUNNING, player.IsRunning());
        animator.SetBool(HIT, player.Hitting());
        animator.SetBool(FRONTHIT, player.FrontHIT());
        animator.SetBool(BACKHIT, player.BackHIT());
        animator.SetBool(UPHIT, player.upHIT());
        animator.SetBool(DOWNHIT, player.DownHIT());
        animator.SetBool(THROWITEM, player.ThrowITEM());
        animator.SetBool(DEAD,player.IsAlive());
        animator.SetBool(DAMAGE , player.Damage());
    }
}
