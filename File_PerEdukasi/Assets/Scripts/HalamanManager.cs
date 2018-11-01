using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HalamanManager : MonoBehaviour {

	public bool isEscapeToExit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp (KeyCode.Escape)){
			if(isEscapeToExit){
				Application.Quit();
			}else{
				MenuUtama();
			}
		}
	}

	public void KategoriPermainan(){
		SceneManager.LoadScene("Kat_Game");
	}

	public void MenuUtama(){
		SceneManager.LoadScene("Menu");
	}

	public void PermainanAngka(){
		SceneManager.LoadScene("angka");
	}

	public void PermainanHuruf(){
		SceneManager.LoadScene("huruf");
	}
}
