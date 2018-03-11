using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour {

	bool upOrDown;
	int times = 10;

	public void StartShake()
	{
		InvokeRepeating ("Shake", 0, 0.1f);
	}

	void Shake()
	{
		float shakeAmountX = 0f;
		float shakeAmountY = 0f;
		if (upOrDown) {
			shakeAmountX = Random.Range (0f, 0.5f);
			shakeAmountY = Random.Range (0f, 0.5f);
		} else {
			shakeAmountX = Random.Range (0f, -0.5f);
			shakeAmountY = Random.Range (0f, -0.5f);
		}
		upOrDown = !upOrDown;
		Camera.main.transform.position = new Vector3 (shakeAmountX, shakeAmountY, -10);
		times--;
		if (times == 0) {
			Camera.main.transform.position = new Vector3 (0, 0, -10);
			CancelInvoke ("Shake");
		}
	}
}