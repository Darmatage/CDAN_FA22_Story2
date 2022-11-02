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
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtBG;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject Choice1a;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject Choice2a;
        public GameObject Choice2b;
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
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtBG.SetActive(true);
        Choice1a.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(Excellent. I've successfully entered a human containment unit.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 3){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(Out of the two human males, which one shoud I relay my information to?)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "???";
                Char3speech.text = "(Meow.)";

        }
        else if (primeInt ==5){
                 Char1name.text = "YOU";
                 Char1speech.text = "(Oh. Perhaps I could speak with the other specimen residing here too?)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";

         }
         else if (primeInt ==6){
           DialogueDisplay.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          Choice1a.SetActive(true); //Evan dialogue
          NextScene1Button.SetActive(true);//chris dialogue in Scene7
          NextScene2Button.SetActive(true);//frank(the cat)dialogue in Scene8
                  //gameHandler.AddPlayerStat(1);

          }

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 101){
      ArtChar1a.SetActive(false);
      ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "You alright? Poor thing...Come up with me!";
        }
		else if (primeInt == 102){
      ArtChar1c.SetActive(false);
      ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "See? It's comfrotable. You're safe here.";
		}
		else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
  if(GameHandler.hasComm==true){
        Choice2a.SetActive(true);
				Choice2b.SetActive(false);
		}
    else if (GameHandler.hasProof==true){
        Choice2a.SetActive(false);
        Choice2b.SetActive(true);
    }
  }

       else if (primeInt == 200){
                Char1name.text = "YOU";
                Char1speech.text = "Human. I require your help immediately.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "...!";
        }
		else if (primeInt == 202){
                Char1name.text = "YOU";
                Char1speech.text = "I mean you no harm. Please I need you to listen.\nHumanity is in danger.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Well, damn. I've seen my fair share or weird stuff but this takes the cake.";
        }
        else if (primeInt == 204){
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(true);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Evan";
                    Char2speech.text = "Anyway, these are... very serious claims. And what are you exactly?";
            }
		else if (primeInt == 205){
                Char1name.text = "YOU";
                Char1speech.text = "I am of the planet Ginipera. My people wish to harvest your organic resources.";
                Char2name.text = "";
                Char2speech.text = "";
        }
    else if (primeInt == 206){
                Char1name.text = "YOU";
                Char1speech.text = "Your planet must be wiped in order to do this.";
                Char2name.text = "";
                Char2speech.text = "";
            }
		else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "And you want to warn us?";
        }
		else if (primeInt == 208){
                Char1name.text = "YOU";
                Char1speech.text = "Yes. I need to inform your highest form of authority as soon as possible.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 209){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "I don’t know why, but, .. I kind of believe you.";
        }
    else if (primeInt == 210){
      ArtChar1d.SetActive(false);
      ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "I mean, a bizarre talking dog showed up at our doorstep out of nowhere so that must mean something.";
            }
    else if (primeInt == 211){
      ArtChar1b.SetActive(false);
      ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "I work with the federal defense unit.\nI think I can get in touch with my night shift supervisor in a few hours.";
            }
    else if (primeInt == 212){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "I think she can hook you up with some of the higher-ups.";
                    }
		else if (primeInt == 213){
                Char1name.text = "YOU";
                Char1speech.text = "I see. Thank you, human.\nI didn't take a human form to communicate with you, so I hope I didn't startle you.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 214){
      ArtChar1d.SetActive(false);
      ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Oh, no no! Of course not. I mean, I've been stationed to oversee Area 51 a few times.";
        }
    else if (primeInt == 215){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Still don't know why I'm still ... shocked over all this.";
            }
		else if (primeInt == 216){
                Char1name.text = "YOU";
                Char1speech.text = "Thank you, human. I will remember your generosity.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 217){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Well, it didn’t look like I had much of a choice, with the whole planet getting evaporated.\nMy name is Evan by the way.";
        }
		else if (primeInt == 218){
                Char1name.text = "YOU";
                Char1speech.text = "I see. I wished we could’ve met under better circumstances, Evan.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 219){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "I know. I wish we did too.";
        }
    else if (primeInt == 220){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "You'll meet my superiors soon. Get some rest for now, alright?";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
            }
       else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Aww! Haha, who's a good boy?";
        }
        else if (primeInt == 301){
                 Char1name.text = "YOU";
                 Char1speech.text = "...";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
       else if (primeInt == 302){
                Char1name.text = "YOU";
                Char1speech.text = "Bark!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 303){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "What's the matter, bud?";
        }
    else if (primeInt == 304){
                Char1name.text = "YOU";
                Char1speech.text = "Bark! Bark, bark!";
                Char2name.text = "";
                Char2speech.text = "";
            }
    else if (primeInt == 305){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Haha, it's like you're trying to talk to me or something!";
            }
    else if (primeInt == 306){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Evan";
                Char2speech.text = "Keep it down though, okay?\nChris’s in the middle of making ravioli and he needs complete silent concentration.";
            }
    else if (primeInt == 307){
                Char1name.text = "YOU";
                Char1speech.text = "(Hmph, this was a bust.\nLooks like this human doesn't understand dog language. ..)";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
            }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Human. I require your help immediately.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Evan";
              Char2speech.text = "Hm..?";
              primeInt=299;
              Choice2a.SetActive(false);
              Choice2b.SetActive(false);
              nextButton.SetActive(true);
              allowSpace = true;
        }
        public void Choice1aFunct(){
          DialogueDisplay.SetActive(true);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Evan";
                 Char2speech.text = "Oh, hey little buddy! Getting adjusted already, huh?";
              primeInt = 99;
              Choice1a.SetActive(false);
              NextScene1Button.SetActive(false);
              NextScene2Button.SetActive(false);
              nextButton.SetActive(true);
              allowSpace = true;
          GameHandler.metEvan=true;
        }
        public void SceneChange1(){
               SceneManager.LoadScene("Scene7");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene8");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene9");
        }
      }
