public class CanvasIngame : DestroyableSingleton<CanvasIngame>
{
	public PanelControl panelControl;
	public PanelStart   PanelStart;

	private void Start()
	{
		OpenStartPanel();
	}


	public void OpenControlPanel()
	{
		panelControl.gameObject.SetActive(true);
		PanelStart.gameObject.SetActive(false);
	}
	
	
	public void OpenStartPanel()
	{
		panelControl.gameObject.SetActive(false);
		PanelStart.gameObject.SetActive(true);
	}
}