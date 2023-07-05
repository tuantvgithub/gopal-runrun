using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	private static readonly int Run  = Animator.StringToHash("Run");
	private static readonly int Idle = Animator.StringToHash("Idle");
	
	
	[SerializeField] private Transform   characterVisual;
	[SerializeField] private Rigidbody2D characterRGBody;
	[SerializeField] private Animator    characterAnimator;

	private                  float   _speed;
	private                  Vector3 _vectorVelocity;
	[HideInInspector] public bool    _isFirstGamePlayTouch;

	private bool    _isStop;
	private float   _primalScale;
	private Vector3 _visualScale;

	private void Awake()
	{
		_visualScale = characterVisual.localScale;
		_primalScale = _visualScale.x;
	}

	public void Init(float speed, bool isFirstGamePlayTouch)
	{
		_speed                = speed;
		_isFirstGamePlayTouch = isFirstGamePlayTouch;
	}

	private void Update()
	{
		if (!_isFirstGamePlayTouch || _isStop) return;

		Vector3 vectorTouch = CanvasIngame.Instance.panelControl.GetVectorTargetTouch();
		Debug.Log(vectorTouch);
		
		if (vectorTouch != Vector3.zero)
		{
			characterAnimator.SetTrigger(Run);
			if (vectorTouch.x < 0)
			{
				_visualScale.x             = 1 * _primalScale;
				characterVisual.localScale = _visualScale;
			} else if (vectorTouch.x > 0)
			{
				_visualScale.x             = -1 * _primalScale;
				characterVisual.localScale = _visualScale;
			}

			characterRGBody.MovePosition(transform.position + vectorTouch.normalized * _speed * Time.deltaTime);
		} else
		{
			characterAnimator.SetTrigger(Idle);
		}
	}

	public void stop() { _isStop = true; }
}