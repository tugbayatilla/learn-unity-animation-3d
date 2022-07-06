using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeScript : MonoBehaviour
{
    private Animator _animator;
    private static readonly int MakeRed = Animator.StringToHash("MakeRed");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger(MakeRed);
            print("space clicked!");
        }
    }
}
