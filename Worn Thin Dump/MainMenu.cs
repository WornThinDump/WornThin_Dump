using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000006 RID: 6
public class MainMenu : MonoBehaviour
{
	// Token: 0x0600000A RID: 10 RVA: 0x000020D3 File Offset: 0x000002D3
	public void PlayGame()
	{
		SceneManager.LoadScene(2);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000020DB File Offset: 0x000002DB
	public void QuitGame()
	{
		Application.Quit();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020E2 File Offset: 0x000002E2
	public void HideUI()
	{
	}
}
