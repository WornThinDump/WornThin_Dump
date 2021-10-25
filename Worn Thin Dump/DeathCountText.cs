using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class DeathCountText : MonoBehaviour
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
	private void Start()
	{
		base.GetComponent<Text>().text = PlayerPrefs.GetInt("DeathCount").ToString();
	}
}
