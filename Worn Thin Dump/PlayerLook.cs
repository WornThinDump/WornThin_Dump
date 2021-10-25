using System;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class PlayerLook : MonoBehaviour
{
	// Token: 0x06000012 RID: 18 RVA: 0x000020E2 File Offset: 0x000002E2
	private void Start()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002100 File Offset: 0x00000300
	private void Update()
	{
		this.x += -Input.GetAxis("Mouse Y") * this.MouseSensitivity;
		this.y += Input.GetAxis("Mouse X") * this.MouseSensitivity;
		this.x = Mathf.Clamp(this.x, -90f, 90f);
		base.transform.localRotation = Quaternion.Euler(this.x, 0f, 0f);
		this.player.transform.localRotation = Quaternion.Euler(0f, this.y, 0f);
	}

	// Token: 0x04000006 RID: 6
	public Transform player;

	// Token: 0x04000007 RID: 7
	public float MouseSensitivity = 5f;

	// Token: 0x04000008 RID: 8
	private float x;

	// Token: 0x04000009 RID: 9
	private float y;
}
