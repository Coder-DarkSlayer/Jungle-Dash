using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    private const string REACHED = "ReachedPlayer";
    private const string BLOCKED = "Intercepted";
    [SerializeField] private Enemy enemy;
    private Animator animator;
    private Vector2 screenBounds;
    private void Awake() {
        animator = GetComponent<Animator>();
    }
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width , Screen.height , Camera.main.transform.position.z));
    }

    void Update()
    {
        animator.SetBool(REACHED , enemy.HasReached());
        animator.SetBool(BLOCKED , false);
    }
}
