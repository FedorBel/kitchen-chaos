using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string _IS_WALKING = "IsWalking";

    [SerializeField] private Player _player;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(_IS_WALKING, false);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (true)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool(_IS_WALKING, _player.IsWalking());
    }
}
