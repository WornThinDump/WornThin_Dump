using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class PlayerMove : MonoBehaviour
{
	// Token: 0x06000015 RID: 21 RVA: 0x000021BD File Offset: 0x000003BD
	private void Start()
	{
		this.rb = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000021CC File Offset: 0x000003CC
	private void Update()
	{
		float d = Input.GetAxis("Horizontal") * this.moveSpeed;
		float d2 = Input.GetAxis("Vertical") * this.moveSpeed;
		if (Input.GetKeyDown(KeyCode.Space) && this.Grounded)
		{
			this.rb.velocity = new Vector3(this.rb.velocity.x, this.jumpForce, this.rb.velocity.z);
		}
		Vector3 vector = base.transform.right * d + base.transform.forward * d2;
		Vector3 velocity = new Vector3(vector.x, this.rb.velocity.y, vector.z);
		this.rb.velocity = velocity;
		this.Grounded = Physics.CheckSphere(new Vector3(base.transform.position.x, base.transform.position.y - 1f, base.transform.position.z), 0.4f, this.layerMask);
	}

	// Token: 0x0400000A RID: 10
	private Rigidbody rb;

	// Token: 0x0400000B RID: 11
	public float moveSpeed = 6f;

	// Token: 0x0400000C RID: 12
	public float jumpForce = 12f;

	// Token: 0x0400000D RID: 13
	public LayerMask layerMask;

	// Token: 0x0400000E RID: 14
	public bool Grounded;
}
