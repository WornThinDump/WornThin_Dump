using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class ButtonFx : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public void HoverSound()
	{
		this.myFx.PlayOneShot(this.hoverFX);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002063 File Offset: 0x00000263
	public void ClickSound()
	{
		this.myFx.PlayOneShot(this.clickFx);
	}

	// Token: 0x04000001 RID: 1
	public AudioSource myFx;

	// Token: 0x04000002 RID: 2
	public AudioClip hoverFX;

	// Token: 0x04000003 RID: 3
	public AudioClip clickFx;
}
