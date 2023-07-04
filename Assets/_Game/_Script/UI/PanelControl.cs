using UnityEngine;

public class PanelControl : MonoBehaviour
{
	[SerializeField] private CharacterMovementUI character1UI;

	public Vector3 GetVectorTargetTouch() { return character1UI.GetVectorTargetTouch(); }
}