using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000010 RID: 16
public class Wait5 : MonoBehaviour
{
	// Token: 0x06000023 RID: 35 RVA: 0x00002382 File Offset: 0x00000582
	private void Start()
	{
		base.StartCoroutine(this.BellybuttonLint());
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002391 File Offset: 0x00000591
	private IEnumerator BellybuttonLint()
	{
		yield return new WaitForSeconds(6f);
		SceneManager.LoadScene(4);
		yield break;
	}
}
