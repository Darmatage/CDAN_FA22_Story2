using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
		public Text Char4name;
		public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar1b;
        public GameObject ArtChar2;
		public GameObject ArtChar2b;
		public GameObject ArtChar3;
		public GameObject ArtChar3b;
		//public GameObject ArtChar4;
        public GameObject ArtBG1;
        //public GameObject Choice1a;
        //public GameObject Choice1b;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        //Choice1a.SetActive(false);
        //Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units! This is the main story function. Players hit [NEXT] to progress to the next primeInt:
public void talking(){
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Pixeli";
                Char2speech.text = "Sir, we seem to have arrived in the living facilitate of this metropolitan city. How–ho–ho shou-should–o-we–!";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Pixeli? Oh crap, the transition from the ship’s generator must’ve been too much. She’s broken and I don’t think I have the resources or the time to fix her. MAybe the humans can lend me some of their materials. But first,,,";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "How do I get the attention of the humans in this containment unit? Perhaps this could work...BARK! BARK!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "(Two men appear at the door, one looking surprised and ready to dote on the dog, the other more confused and perplexed.)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Evan";
                Char3speech.text = "Oh my god. Chris, look! It's so cute!";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char4name.text = "Chris";
				Char4speech.text = "Yeah. He's a cute little guy alright. Wierd how we haven't seen him around before.";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "It doesn’t look like he has a collar. ..And the poor thing looks like he’s starving!";
	   }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "…What if he hasn’t had his rabies shot?";
		}
		else if (primeInt == 10){
				Char3name.text = "Evan";
				Char3speech.text = "Oh come on: the vet’s closed now and he needs to eat! We’ll take him in first thing in the morning. How about that?";
		}
		else if (primeInt == 11){
				Char4name.text = "Chris";
				Char4speech.text = "Hm. .. Alright, sure.I bet Matilda will get a kick out of this too, hon.";
		} 
		else if (primeInt == 12) {
				Char3name.text = "Evan";
				Char3speech.text = "For sure! Come on, little buddy.";
				nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
		}
				
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                //Choice1a.SetActive(true); // function Choice1aFunct()
                //Choice1b.SetActive(true); // function Choice1bFunct()
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene6");
        }
        
}
