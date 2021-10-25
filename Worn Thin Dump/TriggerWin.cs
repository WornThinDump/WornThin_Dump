using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000E RID: 14
public class TriggerWin : MonoBehaviour
{
	// Token: 0x0600001F RID: 31 RVA: 0x0000236D File Offset: 0x0000056D
	private void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene(5);
	}
}
