using UnityEngine;
using UnityEngine.UI;

public class RollScript : MonoBehaviour {

	public Text score;
	public Text heighestScoreText;

	void Start(){
		heighestScoreText.GetComponent<Text>().text=PlayerPrefs.GetInt("HeighestScore",0).ToString();
	}

	public void rollDice(){
		int rollNumber=Random.Range(1,7);
		score.GetComponent<Text>().text=rollNumber.ToString();
		int highScore=PlayerPrefs.GetInt("HeighestScore");
		if(highScore<rollNumber){
			PlayerPrefs.SetInt("HeighestScore",rollNumber);
		}
		heighestScoreText.GetComponent<Text>().text=PlayerPrefs.GetInt("HeighestScore",0).ToString();
		
	}

	public void resetScore(){
		score.GetComponent<Text>().text="0";
		heighestScoreText.GetComponent<Text>().text="0";
		PlayerPrefs.SetInt("HeighestScore",0);
	}
}
