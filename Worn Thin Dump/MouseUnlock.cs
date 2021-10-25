using System;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class MouseUnlock : MonoBehaviour
{
	// Token: 0x06000010 RID: 16 RVA: 0x000020F2 File Offset: 0x000002F2
	private void Start()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
