using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {


	// Use this for initialization
	void Start () {

	
	}


	// Update is called once per frame
	void Update()
	{

        if (Input.anyKey)
        {
            Debug.Log("A key or mouse click has been detected");
            //SceneManager.LoadScene(LevelEnum.ToString(), LoadSceneMode.Single);
        }

	}

   
}
