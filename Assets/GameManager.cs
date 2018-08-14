using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static GameManager gm;

	[Tooltip("If not set, the player will default to the gameObject tagged as Player.")]
	public GameObject player;

	public enum gameStates {Playing, GameOver, BeatLevel};
	public gameStates gameState = gameStates.Playing;

	public int score=0;
	public bool canBeatLevel = true;
	public int beatLevelScore=5;
    public float startTime;
    public bool gameStarted;
    public float gameDuration = 180;
	public Text mainScoreDisplay;

	public GameObject mainCanvas;

	[Tooltip("Only need to set if canBeatLevel is set to true.")]
	public GameObject beatLevelCanvas;

	public AudioSource backgroundMusic;

    public GameObject apocalypticScene;
    public GameObject futuristicScene;
    public GameObject kingdomScene;
    public GameObject natureScene;
    public GameObject factoryScene;

	public Material naturebox;
	public Material futurebox;
	public Material pollutionbox;
	public Material kingdombox;

	public float _Skyboxblendfactor = 0.01f;
	public float _Skyboxblendfactor2 = 0.01f;
	public float _Skyboxblendfactor3 = 0.01f;
	public float _Skyboxblendfactor4 = 0.01f;

	public float _Skyboxblendspeed = 0.05f;

    [Tooltip("Only need to set if canBeatLevel is set to true.")]
	public AudioClip beatLevelSFX;




	void Start () {
		_Skyboxblendspeed = 0.0275f;


	{
		if (gm == null) 
			gm = gameObject.GetComponent<GameManager>();

		if (player == null) {
			player = GameObject.FindWithTag("Player");
		}

        gameStarted = true;
        // setup score display
        Collect (0);

		if (canBeatLevel && beatLevelCanvas!=null)
			beatLevelCanvas.SetActive (false);
	}
	}

	void Update () {
		/*switch (gameState)
		{
		case gameStates.Playing:
			if (canBeatLevel && score>=beatLevelScore) {
				// update gameState
				gameState = gameStates.BeatLevel;
				mainCanvas.SetActive (false);

				// TODO display select which future to go to canvas/menu

			}
			break;

		case gameStates.BeatLevel:
			backgroundMusic.volume -= 0.01f;
			if (backgroundMusic.volume<=0.0f) {
				AudioSource.PlayClipAtPoint (beatLevelSFX,gameObject.transform.position);
			}

			//TODO add more beat level stuff?

			break;

		case gameStates.GameOver:
			// nothing
			break;
		}*/
        
        if (gameStarted && (Time.time > startTime + gameDuration)) {
            gameStarted = false;
            if (score > 30) {
                //open futuristic scene
				RenderSettings.skybox = futurebox;
				_Skyboxblendfactor += _Skyboxblendspeed * Time.deltaTime;
				RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor);
                futuristicScene.SetActive(true);
                apocalypticScene.SetActive(false);
                player.transform.position = new Vector3(-40, 23.69f, 16.82f);
            } else if (score > 25) {
                //open Kingdom scene
				RenderSettings.skybox = kingdombox;
				_Skyboxblendfactor2 += _Skyboxblendspeed * Time.deltaTime;
				RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor2);
                kingdomScene.SetActive(true);
                apocalypticScene.SetActive(false);
                player.transform.position = new Vector3(469, 32, 515);
            } else if (score > 15) {
                //open nature scene
				RenderSettings.skybox = naturebox;
				_Skyboxblendfactor3 += _Skyboxblendspeed * Time.deltaTime;
				RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor3);
                natureScene.SetActive(true);
                apocalypticScene.SetActive(false);
                player.transform.position = new Vector3(-19.879f, 1.7f, 21.45f);
            } else {
                //open factory scene
				RenderSettings.skybox = pollutionbox;
				_Skyboxblendfactor4 += _Skyboxblendspeed * Time.deltaTime;
				RenderSettings.skybox.SetFloat ("_Blend", _Skyboxblendfactor4);
                factoryScene.SetActive(true);
                apocalypticScene.SetActive(false);
                player.transform.position = new Vector3(158, 17.2f, 34);
            }
        } 
	}


	public void Collect(int amount) {
		score += amount;
		if (canBeatLevel && mainScoreDisplay!=null) {
			mainScoreDisplay.text = score.ToString ();
		} else if(!canBeatLevel && mainScoreDisplay!=null) {
			mainScoreDisplay.text = score.ToString ();
		}

	}

    public void OnStartButtonClick() {
        startTime = Time.time;
        gameStarted = true;
    }
}
