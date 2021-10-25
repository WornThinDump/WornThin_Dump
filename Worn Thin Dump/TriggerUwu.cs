using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000D RID: 13
public class TriggerUwu : MonoBehaviour
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002365 File Offset: 0x00000565
	private void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene(6);
	}
}
