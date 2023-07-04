using UnityEngine;

public class DestroyableSingleton<T> : MonoBehaviour where T : Component {
	public static T Instance;

	protected virtual void Awake() {
		Instance = this as T;
	}
}