using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		    public GameObject ArtChar1b;
		//public GameObject ArtChar1c;
        public GameObject ArtChar2;
	      public GameObject ArtChar2b;
        public GameObject ArtChar2c;
	   //public GameObject ArtChar2c;
	      public GameObject ArtChar3;
        public GameObject ArtBG1;
		    public GameObject ArtBG_black;
        public GameObject Choice1a;
        public GameObject Choice1b;
		    public GameObject Choice1c;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandler;
       //public AudioSource audioSource;
    private bool allowSpace = true;
		private bool isEndofScene = false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false); // pixeli monitor form1
		ArtChar1b.SetActive(false); // pixeli monitor form2
		ArtChar2.SetActive(false); // pixeli  collar1
		ArtChar2b.SetActive(false); // pixeli collar2
    ArtChar2c.SetActive(false); // pixeli collar3
		ArtChar3.SetActive(false); // stray dog
        ArtBG1.SetActive(true);
		ArtBG_black.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
        }
        else if (primeInt == 2){
          ArtChar1.SetActive(true);
          DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
				StartCoroutine(TypeText(Char2speech, "Sir? We've landed."));
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "You call that a landing? I should have traded your AI butt for a taoaster back on Saturn";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
				StartCoroutine(TypeText(Char2speech, "Indeed, Sir. Are you OK?"));
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I think I'm alright.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
				StartCoroutine(TypeText(Char2speech, "Scans show human settlements within 2 clicks."));
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "At least that's not too far. Anything still working?";
                Char2name.text = "";
                Char2speech.text = "";
        }

		else if (primeInt == 8){
      ArtChar1.SetActive(false);
      ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
				StartCoroutine(TypeText(Char2speech, "Not m-m-m-much sir..."));
        }
       else if (primeInt ==9){
                Char1name.text = "YOU";
                Char1speech.text = "Pixel..? Are YOU OK?";
                Char2name.text = "";
                Char2speech.text = "";
        }

		else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
				StartCoroutine(TypeText(Char2speech, "Pl-plLeasE T-aK-e CA-"));
        }
       else if (primeInt ==11){
         ArtChar1b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "(... \n Guess the crash busted her.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==12){
                Char1name.text = "YOU";
                Char1speech.text = "(I should get out of here.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==13){
			StartCoroutine(FadeOut(ArtBG_black));

                Char1name.text = "YOU";
                Char1speech.text = "(I can’t believe it. I’m really here.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==14){
			ArtChar3.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(Ah, a canine. \n I’ve heard humans find these creatures endearing. \nPerhaps I will take on its form!)";
                Char2name.text = "";
                Char2speech.text = "";
        }

		else if (primeInt ==15){
			ArtChar3.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "(I have a mission to fulfill. \n But first, .. what should I do first? \n The ship is in bad shape, and I don’t have a lot of time.)";
                Char2name.text = "";
                Char2speech.text = "";
        }

		else if (primeInt ==16){
			ArtChar2.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "(I could salvage my ship communicator– that takes a lot of time, but sure would help with speaking to humans \n I could focus on bringing proof of the coming invasion \n Or I could transfer the AI to my portable computer so she can help.)";
                Char2name.text = "";
                Char2speech.text = "";
        }


       else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "What do I do?";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1

       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "(Ugh, that took a whole light year. Well, let's get out there.)";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); //scene 2
        }

       else if (primeInt == 200){
                Char1name.text = "YOU";
                Char1speech.text = "I hope I can find a human computer to read them...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "OK. Off to meet the humans! And hopefully save their weird organic butts!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // scene 2
        }

		else if (primeInt == 300){
                Char1name.text = "YOU";
                Char1speech.text = "OK, I have extracted as much of Pixeli as I could. .. \n Pixeli, come online!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 301){
                Char1name.text = "YOU";
                Char1speech.text = "Pixeli...?";
                Char2name.text = "";
                Char2speech.text = "";
        }

		else if (primeInt == 302){
			ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
StartCoroutine(TypeText(Char2speech, "Sir! You're OK! \nYou look .. different, though."));
        }
       else if (primeInt == 303){
                Char1name.text = "YOU";
                Char1speech.text = "I found an organism to mimic already.\nA part of me was worried you wouldn’t activate.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 304){
                 Char1name.text = "YOU";
                 Char1speech.text = "You seem to be in stable coniditon \nFor the most part anyway.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }

		else if (primeInt == 305){
        ArtChar2.SetActive(false);
        ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
StartCoroutine(TypeText(Char2speech,"Am I on your collar computer? \nI’ve never been unplugged from the motherboard before."));
        }
       else if (primeInt == 306){
                Char1name.text = "YOU";
                Char1speech.text = "You’ll be alright. \nI’ll have my charger on me at all times.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 307){
      ArtChar2b.SetActive(false);
      ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
StartCoroutine(TypeText(Char2speech,"Always so prepared. \nLet’s be off then."));
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); //scene 2
				isEndofScene = true;
        }

     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Snargleflat. This going to take 10 earth hours. That leaves only about half a day to warn humanity!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				        Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
				GameHandler.hasComm = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "The humans will have no reason to believe me without these documents.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				        Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasProof = true;
				GameHandler.hasProof = true;
        }

		public void Choice1cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I can't imagine doing this mission witghout Pixeli.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				        Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasAi = true;
				GameHandler.hasAi = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2");
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

		//TYPE ON EFFECT
		 IEnumerator TypeText(Text target, string fullText){
                float delay = 0.01f;
                nextButton.SetActive(false);
                allowSpace = false;
                for (int i = 0; i < fullText.Length; i++){
                        string currentText = fullText.Substring(0,i);
                        target.text = currentText;
                        yield return new WaitForSeconds(delay);
                }
				if (isEndofScene == false){
					nextButton.SetActive(true);
					allowSpace = true;
				}
    }
}
