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
        public GameObject ArtBG2;
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
        ArtChar1.SetActive(false);
		    ArtChar1b.SetActive(false);
		    ArtChar2.SetActive(false);
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
                if (GameHandler.hasComm == true)||(GameHandler.hasAi == true){primeInt = 199;}
                else if (GameHandler.hasProof == true){primeInt = 299;}

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
                Char1name.text = "";
                Char1speech.text = "<Amazing smell leads you to Chris's kitchen when Christ notices you>";
                Char2name.text = "";
                Char2speech.text = "";
    }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "(This is one of the two tall humans that welcomed me in. Let's try to have a conversation.)";
                Char2name.text = "";
                Char2speech.text = "";

                //gameHandler.AddPlayerStat(1);
                if (GameHandler.hasProof == true){
                  Choice1a.SetActive(true); // bark
                  Choice1b.SetActive(true);
                  Choice1c.SetActive(false);
                  Choice1d.SetActive(false);
                  Debug.Log("hasProof is true, showing bark button");
                }
                else if ((GameHandler.hasComm == true)||(GameHandler.hasAi == true)){
                  Choice1a.SetActive(false); // bark
                  Choice1b.SetActive(false);
                  Choice1c.SetActive(true);
                  Choice1d.SetActive(true);
                  Debug.Log("hasComm or hasAi is true, showing talk button");
                }



        //scene 7a: with communication device

       else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "Hi doggy! You must be hungry, aren't you?";
        }
       else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "I'm not like humans. I don't need human food to maintain my form.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "You shouldn't be too picky about food! Perhaps some meatballs? \nIt's a new recipe so try it and tell me what you think!";
        }

       else if (primeInt == 203){
                Char1name.text = "YOU";
                Char1speech.text = "(I don't feel any harm in this 'meatballs'.. perhaps I can try it? / I'm not used to human food- let's avoid getting into trouble.)";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
			        	Choice1c.SetActive(true); // function Choice1bFunct()
                Choice1d.SetActive(true);// function Choice1dFunct()
        }




// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 500){
                Char1name.text = "";
                Char1speech.text = "<YOU start munching on>";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "Urk! What is the foul..!";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); //scene 2
        }

       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "<A passes out before finishing the rest of its sentence and time passes..";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt ==103){
          DialogueDisplay.SetActive(false);
          Char1name.text = "";
          Char1speech.text = "";
          Char2name.text = "";
          Char2speech.text = "";
          StartCoroutine(FadeOut(ArtBG2));

        }


      //Encounter after choice2 to reject:
       else if (primeInt == 600){
                Char1name.text = "YOU";
                Char1speech.text = "First of all, aren't you surprised that I can talk?";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // scene 2
        }

		    else if (primeInt == 601){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "Oh- wait, you ARE talking! B-but how? ";
        }
       else if (primeInt == 602){
                Char1name.text = "YOU";
                Char1speech.text = "I'm only borrowing a form of an organism. The truth is that I'm from a different planet to warn you about the upcoming invasion.";
                Char2name.text = "";
                Char2speech.text = "";
        }

		   else if (primeInt == 603){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "Oh .. I see! So you are like an alien or something..? \nYou are here to... save us?";
        }
       else if (primeInt == 604){
                Char1name.text = "YOU";
                Char1speech.text = "I don't understand. You are just repeating over everything I said. \nYou are also stuttering as well.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 605){
                 Char1name.text = "YOU";
                 Char1speech.text = "If you are sick, I'll find a new human for help.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
        else if (primeInt == 606){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Chris";
                 Char2speech.text = "No, it's ok. I'm just shocked.";
        }

		    else if (primeInt == 607){
                Char1name.text = "YOU";
                Char1speech.text = "Please, help me. We have no time. \nPlease find the leader of this planet";
                Char2name.text = "";
                Char2speech.text = "";
      }
       else if (primeInt == 608){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "I honestly have no idea what's happening.";
                Char2speech.text = "";
      }
	  	 else if (primeInt == 609){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Chris";
                Char2speech.text = "BUT... since we took you in as our family, I have a responsibility to take care of you so I will help you.";

      }
              else if (primeInt == 610){
                          Char1name.text = "";
                          Char1speech.text = "";
                          Char2name.text = "Chris";
                          Char2speech.text = "It's good that you chose us..I and my husband work for the government.";
                  }
                 else if (primeInt == 611){
                          Char1name.text = "Alien";
                          Char1speech.text = "So you will help me?";
                          Char2name.text = "";
                          Char2speech.text = "";
                  }
                  else if (primeInt == 612){
                              Char1name.text = "";
                              Char1speech.text = "";
                              Char2name.text = "Chris";
                              Char2speech.text = "Family meeting!";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); //scene 2

            }

     //Encounter without communication
        else if (primeInt == 300){
              Char1name.text = "YOU";
              Char1speech.text = "That smell is amazing. This species sure does have an interesting number of sensory options.";
              Char2name.text = "";
              Char2speech.text = "";
      }
          else if (primeInt == 301){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Chris";
              Char2speech.text = "Oh hey doggy. You must be hungry! Here.";
              nextButton.SetActive(false);
              allowSpace = false;
              NextScene1Button.SetActive(true); //scene 2
      }
      else if (primeInt == 302){
               Char1name.text = "";
               Char1speech.text = "(Holds out a meatball on a fork)";
               Char2name.text = "";
               Char2speech.text = "";
               // Turn off "Next" button, turn on "Choice" buttons
               nextButton.SetActive(false);
               allowSpace = false;
               Choice1a.SetActive(true); // function Choice1aFunct()
               Choice1b.SetActive(true); // function Choice1bFunct()
               Choice1c.SetActive(true); // function Choice1bFunct()
               Choice1d.SetActive(true);
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
             Char2speech.text = "Huh, I guess you weren't hungry. Which reminds me we should get dog food, if we're planning on keeping you.";
             nextButton.SetActive(false);
             allowSpace = false;
             NextScene1Button.SetActive(true); //scene 2
    }
             else if (primeInt == 703){
                   Char1name.text = "YOU";
                   Char1speech.text = "Seems like this one is a bust too. Is there anyone else I can try?";
                   Char2name.text = "";
                   Char2speech.text = "";
                   //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasProof = true;
                   GameHandler.hasProof = true;


    }
  }
    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
            public void Choice1aFunct(){
                    Char1name.text = "YOU";
                    Char1speech.text = "I can't let down this human's favor.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 499;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
    				        Choice1c.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
    				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
            }
            public void Choice1bFunct(){
                    Char1name.text = "YOU";
                    Char1speech.text = "I must stay viglant. Much of this planet is still a mystery to me.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    primeInt = 699;
                    Choice1a.SetActive(false);
                    Choice1b.SetActive(false);
    				        Choice1c.SetActive(false);
                    nextButton.SetActive(true);
                    allowSpace = true;
                    //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
                    //GameHandler.hasAi = true;
            }

  }



// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I can't let down this human's favor.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 499;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				        Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				//GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
        }
        public void Choice1dFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I must stay viglant. Much of this planet is still a mystery to me.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 599;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				        Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                //GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>().hasComm = true;
                //GameHandler.hasAi = true;
        }
      




        public void SceneChange1(){
               SceneManager.LoadScene("Scene9");
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
        //public void SceneChange2(){
        //        SceneManager.LoadScene("Scene2b");
        //}
    }
