using UnityEngine;
using UnityEngine.UI;

public class PanelStart : MonoBehaviour
{
	[SerializeField] private Button _btnStart;


	private void Awake() { _btnStart.onClick.AddListener(OnClick_StartBtn); }

	private void OnClick_StartBtn()
	{
		CanvasIngame.Instance.OpenControlPanel();
		GameManager.Instance.StartGame();
	}
}