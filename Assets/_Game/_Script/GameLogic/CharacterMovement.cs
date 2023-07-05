using Sirenix.OdinInspector;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	[SerializeField] private Rigidbody2D characterRGBody;
	
	private                  float            _speed;
	private                  Vector3          _vectorVelocity;
	[HideInInspector] public bool             _isFirstGamePlayTouch;

	private bool _isStop;

	public void Init(PlayerController player, float speed, bool isFirstGamePlayTouch)
	{
		_speed = speed;

		_isFirstGamePlayTouch = isFirstGamePlayTouch;
	}

	private void Update()
	{
		if (!_isFirstGamePlayTouch || _isStop) return;

		Vector3 vectorTouch = CanvasIngame.Instance.panelControl.GetVectorTargetTouch();
		Twist(vectorTouch.x, vectorTouch.y);
		Debug.Log(vectorTouch);
		if (vectorTouch != Vector3.zero)
		{
			characterRGBody.MovePosition(transform.position + vectorTouch.normalized * _speed * Time.deltaTime);
		}
	}

	private void Twist(float h1, float v1)
	{
		//get radian angle
		if (h1 == 0f && v1 == 0f) { return; }

		transform.localEulerAngles = new Vector3(0f, 0f, -1 * Mathf.Atan2(h1, v1) * 180 / Mathf.PI);
	}

	public void stop()
	{
		_isStop = true;
	}
}