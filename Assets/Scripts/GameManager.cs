using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int currLevel=0;
    //public static int currScore;
    //public static int highScore;
    //public static int unlockedLevel;

    public static void OnCompleteLevel() {
	currLevel++;

	if(currLevel >= 2)
		print("You win!");	
	
	else
		Application.LoadLevel(currLevel);
	
	
    }
}
