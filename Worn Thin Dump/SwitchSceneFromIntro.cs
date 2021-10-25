using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000B RID: 11
public class SwitchSceneFromIntro : MonoBehaviour
{
	// Token: 0x06000018 RID: 24 RVA: 0x0000230F File Offset: 0x0000050F
	private void Start()
	{
		base.StartCoroutine(this.IntroToEnd());
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000231E File Offset: 0x0000051E
	private IEnumerator IntroToEnd()
	{
		yield return new WaitForSeconds(12f);
		SceneManager.LoadScene(1);
		yield break;
	}
}
