using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //MatildaExcited
		    public GameObject ArtChar1b; //MatildaHappy
        public GameObject ArtChar1c; //MatilaLeaningIn
        public GameObject ArtChar1d; //MatildaQuestioning
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
        public static bool hasComm=false;
        public static bool hasProof=false;
        public static bool hasAi=false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
		    ArtChar1b.SetActive(false);
		    ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
      if (GameHandler.hasComm==true){primeInt=1;}
      if (GameHandler.hasAi==true){}
      if (GameHandler.hasProof==true){}
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
              }
        else if (primeInt == 2){
          ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(I’m not sure how well a conversation will go with this one, but I’ll try.)";
                Char2name.text = "";
                Char2speech.text = "";
              }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Hello, underdeveloped female human. I need your help.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
              }
       else if (primeInt == 4){
         ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "Woah, a talking dog?";
              }
       else if (primeInt == 5){
         ArtChar1a.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "Here, doggy doggy!";
                //gameHandler.AddPlayerStat(1);
              }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(She is .. touching my head?)/n(.. Huh. It’s strangely nice.)";
                Char2name.text = "";
				        Char2speech.text = "";
              }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "(This must be a common gesture among humans.)/n(I should cooperate with this underdeveloped specimen so things go smoothly.)";
                Char2name.text = "";
                Char2speech.text = "";
              }

		   else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "It is a pleasure to meet you human, but time is of the essence and we don’t have the luxury of dawdling.";
                Char2name.text = "";
                Char2speech.text = "";
              }
       else if (primeInt ==9){
                Char1name.text = "YOU";
                Char1speech.text = "Please take me to your leader.";
                Char2name.text = "";
                Char2speech.text = "";
              }

		else if (primeInt == 10){
      ArtChar1c.SetActive(false);
      ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "You want to meet my dads? They’re pretty rad.";
              }
       else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "They work in a big office where they beat bad guys and talk to people in neat suits./nThey’re the coolest!";
              }
		else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "Do you wanna a jelly sandwich, by the way?";
                nextButton.SetActive(false);
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
              }
    else if (primeInt ==100){
                Char1name.text = "YOU";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "?";

	             }
}



        public void Choice1aFunct(){
          primeInt=99;
          nextButton.SetActive(true);
          Choice1a.SetActive(false);
          Choice1b.SetActive(false);
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5");
        }
        //public void SceneChange2(){
        //        SceneManager.LoadScene("Scene2b");
        //}

		//FADE IN AND FADE OUT EFFECTS
		IEnumerator FadeIn(GameObject fadeImage){
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage){
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }
}
