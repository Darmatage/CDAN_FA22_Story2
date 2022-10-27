using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
		public static bool hasComm = false;
		public static bool hasProof = false;
		public static bool hasAI = false;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

    if(GameHandler.hasComm==true){
          primeInt=299;

     // Find the gameHandler:
     // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
   }
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
                Char2name.text = "YOU";
                Char2speech.text = "Excellent. I've successfully entered a human containment unit. Out of the two human males, which one shoudl I relay my information to?(A meow is heard from a corner.)";
        }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Perhaps I could speak with the other specimen residing here too?";
                Char2name.text = "";
                Char2speech.text = "";
				Choice1a.SetActive(true);
				NextScene1Button.SetActive(true);//chris dialogue in Scene7
				NextScene2Button.SetActive(true);//frank(the cat)dialogue in Scene8
                //gameHandler.AddPlayerStat(1);

        }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Oh, hey little buddy! Attached already, huh? ";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "...";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "You alright? Poor thing...Come up with me!(Pats the dies next to him on the couch)";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
		else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "See? It's comfrotable. You're safe here.";
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		}
		else if (primeInt == 104){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "...";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
				Choice1b.SetActive(true);
				Choice1c.SetActive(true);
		}

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Human. I require your help immediately.";
        }
       else if (primeInt == 201){
                Char1name.text = "Evan";
                Char1speech.text = "...!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 202){
                Char1name.text = "YOU";
                Char1speech.text = "I mean you no harm. Please I need you to listen. Humanity is in danger.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 203){
                Char1name.text = "Evan";
                Char1speech.text = "Well, damn. I've seen my fair share or weird crap but this takes the cake. Anyway, these are... very serious claims. And what are you exactly?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 204){
                Char1name.text = "YOU";
                Char1speech.text = "I am of the planet Ginipera. My people wish to harvest your organic resources.Your planet must be wiped in order to do this.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 205){
                Char1name.text = "Evan";
                Char1speech.text = "And you want to warn us?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 206){
                Char1name.text = "YOU";
                Char1speech.text = "Yes. I need to inform your highest form of authority as soon as possible.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 207){
                Char1name.text = "Evan";
                Char1speech.text = " I don’t know why, but, .. I kind of believe you. I mean, a bizarre talking dog showed up at our doorstep out of nowhere so that must mean something.I work with the federal defense unit. I think I can get in touch with my night shift supervisor in a few hours. I think she can hook you up with some of the higher-ups.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 208){
                Char1name.text = "A";
                Char1speech.text = "I see. Thank you, human. I didn't take a human form to communicate with you, so I hope I didn't startle you.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 209){
                Char1name.text = "Evan";
                Char1speech.text = "Oh, no no! Of course not... I mean, I've been stationed to oversee Area 51 a few times. Still don't know why I'm still... shocked over all this.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 210){
                Char1name.text = "YOU";
                Char1speech.text = "Thank you, human. I will remember your generosity.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 211){
                Char1name.text = "Evan";
                Char1speech.text = "Well, it didn’t look like I had much of a choice, with the whole planet getting evaporated. My name is Evan by the way.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 212){
                Char1name.text = "YOU";
                Char1speech.text = "I see. I wished we could’ve met under more friendly circumstances, Evan.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 213){
                Char1name.text = "Evan";
                Char1speech.text = "I know. I wish we did too. (Evan stands up). Come on, I’m gonna need your help explaining this to Chris.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "You snuggle up to Evan and he allows you to come closer. ";
        }
       else if (primeInt == 301){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Well, aren't you a touch boy? Who's a good boy?";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "YOU";
                Char2speech.text = "Human. I require your help immediately.";
        }
       else if (primeInt == 303){
                Char1name.text = "Evan";
                Char1speech.text = "...!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 304){
                Char1name.text = "YOU";
                Char1speech.text = "I mean you no harm. Please I need you to listen. Humanity is in danger.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 305){
                Char1name.text = "Evan";
                Char1speech.text = "Well, damn. I've seen my fair share or weird crap but this takes the cake. Anyway, these are... very serious claims. And what are you exactly?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 306){
                Char1name.text = "YOU";
                Char1speech.text = "I am of the planet Ginipera. My people wish to harvest your organic resources.Your planet must be wiped in order to do this.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 307){
                Char1name.text = "Evan";
                Char1speech.text = "And you want to warn us?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 308){
                Char1name.text = "YOU";
                Char1speech.text = "Yes. I need to inform your highest form of authority as soon as possible.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 309){
                Char1name.text = "Evan";
                Char1speech.text = " I don’t know why, but, .. I kind of believe you. I mean, a bizarre talking dog showed up at our doorstep out of nowhere so that must mean something.I work with the federal defense unit. I think I can get in touch with my night shift supervisor in a few hours. I think she can hook you up with some of the higher-ups.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 310){
                Char1name.text = "A";
                Char1speech.text = "I see. Thank you, human. I didn't take a human form to communicate with you, so I hope I didn't startle you.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 311){
                Char1name.text = "Evan";
                Char1speech.text = "Oh, no no! Of course not... I mean, I've been stationed to oversee Area 51 a few times. Still don't know why I'm still... shocked over all this.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 312){
                Char1name.text = "YOU";
                Char1speech.text = "Thank you, human. I will remember your generosity.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 313){
                Char1name.text = "Evan";
                Char1speech.text = "Well, it didn’t look like I had much of a choice, with the whole planet getting evaporated. My name is Evan by the way.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 314){
                Char1name.text = "YOU";
                Char1speech.text = "I see. I wished we could’ve met under more friendly circumstances, Evan.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
		else if (primeInt == 315){
                Char1name.text = "Evan";
                Char1speech.text = "I know. I wish we did too. (Evan stands up). Come on, I’m gonna need your help explaining this to Chris.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){
               SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene8");
        }
    }
