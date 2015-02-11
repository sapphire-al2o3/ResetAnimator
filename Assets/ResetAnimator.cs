using UnityEngine;
using System.Collections;

public class ResetAnimator : MonoBehaviour
{
	Animator _animator;

	void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var info = _animator.GetCurrentAnimatorStateInfo(0);
			_animator.Play(info.nameHash, 0, 0.0f);
		}
	}
}
