using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : DestroyableSingleton<GameManager>
{
	[SerializeField] private PlayerController playerController;


	public void StartGame() { Debug.Log("Game is started, let's play!"); }
}