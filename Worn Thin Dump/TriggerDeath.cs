using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200000C RID: 12
public class TriggerDeath : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002328 File Offset: 0x00000528
	private void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene(3);
		GameManager gameManager = Object.FindObjectOfType<GameManager>();
		int deathCount = gameManager.DeathCount;
		gameManager.DeathCount = deathCount + 1;
		PlayerPrefs.SetInt("DeathCount", PlayerPrefs.GetInt("DeathCount") + 1);
	}
}
