using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
	[SerializeField] private CharacterMovementUI character1UI;
	[SerializeField] private Button _btnStop;
	[SerializeField] private CharacterMovement character1;	

	public Vector3 GetVectorTargetTouch() { return character1UI.GetVectorTargetTouch(); }

	private void Awake() { _btnStop.onClick.AddListener(OnClick_StopBtn); }

	private void OnClick_StopBtn()
	{
		character1.stop();
	}
}