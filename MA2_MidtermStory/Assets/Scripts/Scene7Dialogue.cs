using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text SoundText;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //ChrisNeutral
		    public GameObject ArtChar1b; //ChrisHappy
        public GameObject ArtChar1c; //ChrisSurprised
        public GameObject ArtChar1d; //ChrisAngry
        public GameObject ArtChar1e; //ChrisAnnoyed
		//public GameObject ArtChar1c;
	   //public GameObject ArtChar2b;
	   //public GameObject ArtChar2c;
        public GameObject ArtBG1;
        public GameObject Choice1a; // to bad end 3
        public GameObject Choice1b;
        public GameObject NextScene1Button; // to scene 9
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
        ArtChar1e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
       else if (primeInt ==2){
              DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(This is one of the two tall humans that welcomed me in. Let's try to have a conversation.)";
                Char2name.text = "";
                Char2speech.text = "";
                SoundText.text = "";

                if ((GameHandler.hasComm == true)||(GameHandler.hasAi==true)){
                  ArtChar1a.SetActive(true);
                  primeInt = 99;
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Chris";
                  Char2speech.text = "Hey bud! You must be hungry, aren't you?";
                }
                else if (GameHandler.hasProof == true){
                  primeInt = 199;
                  Char1name.text = "YOU";
                  Char1speech.text = "(That smell is amazing. This species sure does have an interesting number of sensory options.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                }

}

       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "I'm not like humans. I don't need human food to maintain my form.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "You shouldn't be too picky about food! Perhaps some meatballs?\nIt's a new recipe so try it and tell me what you think!";
        }

       else if (primeInt == 102){
                Char1name.text = "YOU";
                Char1speech.text = "(I don't sense any harm in these 'meatballs.'.. Perhaps I can try it?)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 103){
                 Char1name.text = "YOU";
                 Char1speech.text = "(I'm still not used to human food. Some could still be hazardous to my health. ...)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 // Turn off "Next" button, turn on "Choice" buttons
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true); // function Choice1aFunct()
                 Choice1b.SetActive(true); // function Choice1bFunct()
         }

         else if (primeInt == 200){
                 ArtChar1a.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Chris";
                   Char2speech.text = "Oh hey doggy. You must be hungry! Here.";
           }
           else if (primeInt == 201){
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "Chris";
                    Char2speech.text = "Here! Have one of my meatballs. You must be hungry.";
                    // Turn off "Next" button, turn on "Choice" buttons
                    nextButton.SetActive(false);
                    allowSpace = false;
                    Choice1a.SetActive(true); // function Choice1aFunct()
                    Choice1b.SetActive(true); // function Choice1bFunct()
            }


      //Encounter after choice2 to reject:
       else if (primeInt == 400){
                Char1name.text = "YOU";
                Char1speech.text = "First of all, aren't you surprised that I can talk?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // scene 2
        }

		    else if (primeInt == 401){
          ArtChar1a.SetActive(false);
          ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "Oh- wait, you ARE talking! B-but how? ";
        }
       else if (primeInt == 402){
                Char1name.text = "YOU";
                Char1speech.text = "I'm only borrowing a form of an organism.\nThe truth is that I'm from a different planet to warn you about the upcoming invasion.";
                Char2name.text = "";
                Char2speech.text = "";
        }

		   else if (primeInt == 403){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "Oh .. I see! So you are like an alien or something..?\nYou are here to... save us?";
        }
       else if (primeInt == 404){
                Char1name.text = "YOU";
                Char1speech.text = "I don't understand. You are just repeating over everything I said.\nYou are also stuttering as well.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 405){
                 Char1name.text = "YOU";
                 Char1speech.text = "If you are sick, I'll find a new human for help.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
        else if (primeInt == 406){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Chris";
                 Char2speech.text = "No, no, it's ok! .. I'm just shocked.";
        }

		    else if (primeInt == 407){
                Char1name.text = "YOU";
                Char1speech.text = "Please, help me. We have no time.\nPlease take me to the leader of this planet";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt == 408){
         ArtChar1c.SetActive(false);
         ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "I honestly have no idea what's happening.";
      }
	  	 else if (primeInt == 409){
         ArtChar1e.SetActive(false);
         ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "But ... since we took you in as our family, I have a responsibility to take care of you so I will help you.";

      }
              else if (primeInt == 410){
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "Chris";
                          Char2speech.text = "It's good that you chose us. I and my husband work for the government.";
                  }
                 else if (primeInt == 411){
                          Char1name.text = "YOU";
                          Char1speech.text = "So you will help me?";
                          Char2name.text = "";
                          Char2speech.text = "";
                  }
                  else if (primeInt == 412){
                    ArtChar1a.SetActive(false);
                    ArtChar1b.SetActive(true);
                              Char1name.text = "";
                              Char1speech.text = "";
                              Char2name.text = "Chris";
                              Char2speech.text = "Family meeting!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                GameHandler.metChris=true;
            }

     //Encounter without communication

    else if (primeInt == 300){
            ArtChar1a.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Chris";
              Char2speech.text = "Oh hey doggy. You must be hungry! Here.";
      }
      else if (primeInt == 301){
               Char1name.text = "";
               Char1speech.text = "Here! Have one of my meatballs. You must be hungry.";
               Char2name.text = "";
               Char2speech.text = "";
               // Turn off "Next" button, turn on "Choice" buttons
               nextButton.SetActive(false);
               allowSpace = false;
               Choice1a.SetActive(true); // function Choice1aFunct()
               Choice1b.SetActive(true); // function Choice1bFunct()
       }

       //Choice b (reject)for without communication device:
       else if (primeInt == 701){
             Char1name.text = "YOU";
             Char1speech.text = "That does smell good. But I must stay vigilant. Much of this planet is still a mystery to me.";
             Char2name.text = "";
             Char2speech.text = "";
    }
         else if (primeInt == 702){
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Chris";
             Char2speech.text = "Huh, I guess you weren't hungry.";
    }
    else if (primeInt == 703){
      ArtChar1a.SetActive(false);
      ArtChar1b.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Chris";
        Char2speech.text = "Which reminds me we should get dog food, if we're planning on keeping you.";
}
             else if (primeInt == 704){
                   Char1name.text = "YOU";
                   Char1speech.text = "(Seems like this one is a bust too. Is there anyone else I can try?)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   nextButton.SetActive(false);
                   allowSpace=false;
                   NextScene1Button.SetActive(true);
                   //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasProof = true;


    }
}
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
            public void Choice1bFunct(){
                    Char1name.text = "YOU";
                    Char1speech.text = "(I must stay viglant. Much of this planet is still a mystery to me.)";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 699;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
                    //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
                    //GameHandler.hasAi = true;
            }



// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
              SceneManager.LoadScene("End_GameEnd3");
				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
        }
        public void SceneChange1Funct(){
               SceneManager.LoadScene("Scene9");
        }
}
