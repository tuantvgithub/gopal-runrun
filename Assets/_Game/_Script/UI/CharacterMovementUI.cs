using UnityEngine;

public class CharacterMovementUI : MonoBehaviour {
	private Vector3 _vectorTargetTouch;

	/*----------Listener----------------------------------------------------------------*/
	public void OnListen_VectorTargetTouch(Vector2 input) {
		_vectorTargetTouch = input;
	}

	public Vector3 GetVectorTargetTouch() {
		return _vectorTargetTouch;
	}
}