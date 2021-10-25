using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class DoorDown : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x000020AA File Offset: 0x000002AA
	private void Start()
	{
		this.animator = base.GetComponent<Animator>();
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020B8 File Offset: 0x000002B8
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			this.animator.SetTrigger("DoorClose");
		}
	}

	// Token: 0x04000004 RID: 4
	private Animator animator;
}
