using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float             speed = 5;
	[SerializeField] private CharacterMovement character1;


	[HideInInspector] public bool isFirstGamePlayTouch;

	private void Start()
	{
		isFirstGamePlayTouch = false;
		character1.Init(this, speed, isFirstGamePlayTouch);
	}

	public void SetIsFirstGamePlayTouch(bool value)
	{
		isFirstGamePlayTouch             = value;
		character1._isFirstGamePlayTouch = isFirstGamePlayTouch;
	}
}