using System;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class MouseLock : MonoBehaviour
{
	// Token: 0x0600000E RID: 14 RVA: 0x000020E4 File Offset: 0x000002E4
	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
}
