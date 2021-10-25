using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class UrlOpener : MonoBehaviour
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002375 File Offset: 0x00000575
	public void Open()
	{
		Application.OpenURL(this.Url);
	}

	// Token: 0x0400000F RID: 15
	public string Url;
}
