using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000011 RID: 17
public class LevelLoader : MonoBehaviour
{
	// Token: 0x06000026 RID: 38 RVA: 0x00002399 File Offset: 0x00000599
	private void Start()
	{
		this.LoadNextLevel();
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000023A1 File Offset: 0x000005A1
	public void LoadNextLevel()
	{
		base.StartCoroutine(this.LoadLevel());
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000023B0 File Offset: 0x000005B0
	private IEnumerator LoadLevel()
	{
		yield return new WaitForSeconds(9f);
		this.transition.SetTrigger("Start");
		yield return new WaitForSeconds(this.transitionTime);
		SceneManager.LoadScene(1);
		yield break;
	}

	// Token: 0x04000010 RID: 16
	public Animator transition;

	// Token: 0x04000011 RID: 17
	public float transitionTime = 1f;
}
