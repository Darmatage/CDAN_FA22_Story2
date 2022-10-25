using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
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
	   //public GameObject ArtChar2b;
	   //public GameObject ArtChar2c;
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
        public static bool hasComm=false;
        public static bool hasProof=false;
        public static bool hasAi=false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false); // pixeli motherboard form
		ArtChar1b.SetActive(false); // pixeli  collar form
		ArtChar2.SetActive(false); // stray dog
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
                // AudioSource.Play();
        }
        else if (primeInt == 2){
          ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Woof! Woof, woof.";
                Char2name.text = "";
				StartCoroutine(TypeText(Char2speech, ""));
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Here, doggy, doggy!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "(Right..without communication device, this human won't understand me)";
                Char2name.text = "";
				StartCoroutine(TypeText(Char2speech, ""));
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Wait a minute!/nyou are not just a dog, are you?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(Huh? DOes..does this human know?)";
                Char2name.text = "";
				StartCoroutine(TypeText(Char2speech, ""));
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "How? Your head told me";
        }

		else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "A psychic? Humans have developed enough to possess that ability?";
                Char2name.text = "";
				StartCoroutine(TypeText(Char2speech, ""));
        }
       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "You're friends are coming too? But they're not coming to visit right? They are coming..to fight?";
        }

		else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "It's complicated but yes this planet is in danger. I need to talk to the leader of this planet NOW";
                Char2name.text = "";
				StartCoroutine(TypeText(Char2speech, ""));
        }
       else if (primeInt ==11){
         ArtChar1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Oh you want to go see my dads? They are pretty rad. They work in big office and beat bad guys for living";
        }
		else if (primeInt ==12){
                Char1name.text = "YOU";
                Char1speech.text = "(it'd be best to follow this little human who seems to understand my words)";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==13){
			StartCoroutine(FadeOut(ArtBG_black));

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
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
                nextButton.SetActive(true);
                allowSpace = true;
        }
}
