using UnityEngine;

public class PersistentSingleton<T> : MonoBehaviour where T : Component
{
	public static T Instance;

	protected virtual void Awake()
	{
		if (Instance == null)
		{
			Instance = this as T;
			DontDestroyOnLoad(gameObject);
		} else
		{
			Debug.LogWarning("Destroy because already exist!");
			Destroy(gameObject);
		}
	}
}