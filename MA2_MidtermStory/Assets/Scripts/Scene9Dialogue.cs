using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name; //you
        public Text Char1speech;
        public Text Char2name; //Matilda
        public Text Char2speech;
		    public Text Char3name; //Evan
        public Text Char3speech;
		    public Text Char4name; //Chris
        public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //MatildaExcited
        public GameObject ArtChar1b; //MatildaHappy
        public GameObject ArtChar1c; //MatildaLeanin
        public GameObject ArtChar1d; //MatildaConfused
        public GameObject ArtChar2a; // EvanNeutral
        public GameObject ArtChar2b; // EvanHappy
        public GameObject ArtChar2c; // EvanShocked
        public GameObject ArtChar2d; // EvanAngry
        public GameObject ArtChar2e; // EvanAnnoyed
        public GameObject ArtChar3a; // ChrisNeuteal
        public GameObject ArtChar3b; // ChrisHappy
        public GameObject ArtChar3c; // ChrisShocked
        public GameObject ArtChar3d; // ChrisAngry
        public GameObject ArtChar3e; // ChrisAnnoyed
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		    public GameObject Choice2a;
        public GameObject Choice2b;
		    public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar2c.SetActive(false);
        ArtChar2d.SetActive(false);
        ArtChar2e.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar3c.SetActive(false);
        ArtChar3d.SetActive(false);
        ArtChar3e.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		    Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);

    if (GameHandler.metMatilda==false){
      primeInt=1;
      ArtChar1b.SetActive(true);
       DialogueDisplay.SetActive(true);
       Char1name.text = "";
       Char1speech.text = "";
       Char2name.text = "Matilda";
       Char2speech.text = "Hey, Dad!";
       Char3name.text = "";
       Char3speech.text = "";
       Char4name.text = "";
       Char4speech.text = "";
       allowSpace=true;
    }
     else if (GameHandler.metMatilda==true){
       primeInt=699;
       ArtChar1a.SetActive(true);
        DialogueDisplay.SetActive(true);
       Char1name.text = "";
       Char1speech.text = "";
       Char2name.text = "Matilda";
       Char2speech.text = "Dads! I have a surprise!";
       Char3name.text = "";
       Char3speech.text = "";
       Char4name.text = "";
       Char4speech.text = "";
       allowSpace=true;
     }


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

       else if (primeInt ==2){
         ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "Hey, honey how was school?";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 3){
         ArtChar1b.SetActive(false);
         ArtChar1a.SetActive(true);
                Char2name.text = "Matilda";
                Char2speech.text = "School was fine, but you will not believe what I saw when I coming home.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 4){
         ArtChar3a.SetActive(true);
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "Yeah? What did you see, Mat'?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "I saw a star fall down from the sky. Isn't that wierd?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 6){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Matilda";
                 Char2speech.text = "Stars aren't supposed to be out in the middle of the day.";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
         }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "(Oh. I forgot about the wreckage of my ship. .. )";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "Wow, I wonder what that coudld've been. Well, don't worry honey. I'm sure it's nothing.";
	   }
		else if (primeInt == 9){
                Char2name.text = "Matilda";
                Char2speech.text = "Oh hey doggy! .. Wait, when did we get a dog?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 10){
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "Oh, Daddy and I found this little fella outside our door earlier. Wanna say hi?";
	   }
	   else if (primeInt == 11){
       ArtChar1a.SetActive(false);
       ArtChar1c.SetActive(true);
                Char2name.text = "Matilda";
                Char2speech.text = "Wow, your fur is so pretty.";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 12){
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "Don't you have homework to do, Mat'? You can play with the doggy after you're done with that.";
	   }
		else if (primeInt == 13){
      ArtChar1c.SetActive(false);
      ArtChar1d.SetActive(true);
                Char2name.text = "Matilda";
                Char2speech.text = "Awww, but I want to play with the new doggy now!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 14){
      ArtChar2a.SetActive(false);
      ArtChar2b.SetActive(true);
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "There’ll be plenty of time to play AFTER you’re done. Don’t worry, the doggy isn’t going anywhere.";
	   }
		else if (primeInt == 15){
                Char2name.text = "Matilda";
                Char2speech.text = "Hmph. Fine, fine.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 16){
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "That’s the spirit. I‘m gonna help daddy finish up dinner now. You behave now. Don’t get into trouble.";
	   }
     else if (primeInt == 17){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "Chris";
                  Char4speech.text = "You behave now, boy. Don’t get into trouble.";
    }

    else if (primeInt == 18){
      ArtChar2b.SetActive(false);
      ArtChar3a.SetActive(false);
      ArtChar1d.SetActive(false);
      ArtChar1b.SetActive(true);
      DialogueDisplay.SetActive(false);
      Char1name.text = "";
      Char1speech.text = "";
      Char2name.text = "";
      Char2speech.text = "";
      Char3name.text = "";
      Char3speech.text = "";
      Char4name.text = "";
      Char4speech.text = "";
      allowSpace=true;
      nextButton.SetActive(true);
			if ((GameHandler.hasComm == true)||(GameHandler.hasAi==true)){
        primeInt = 99;
        DialogueDisplay.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Matilda";
               Char2speech.text = "What should we do, doggy? You like playing catch?";
               Char3name.text = "";
               Char3speech.text = "";
               Char4name.text = "";
               Char4speech.text = "";
             }
    else if (GameHandler.hasProof == true){
      primeInt = 399;
      DialogueDisplay.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Matilda";
        Char2speech.text ="...";
        Char3name.text = "";
        Char3speech.text = "";
        Char4name.text = "";
        Char4speech.text = "";
      }
   }


// ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "I most certainly do not.";
                Char2name.text = "";
                Char2speech.text = "";
     }
     else if (primeInt == 101){
             Char1name.text = "YOU";
             Char1speech.text = "I don’t think it’s appropriate for someone of my intellectual standing to be involved in such boorish activities.";
             Char2name.text = "";
             Char2speech.text = "";
  }
  else if (primeInt == 102){
          Char1name.text = "YOU";
          Char1speech.text = "You should also most definitely not be disobeying your parental figues.";
          Char2name.text = "";
          Char2speech.text = "";
}
	  else if (primeInt == 103){
      ArtChar1b.SetActive(false);
      ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Ohhh a talking doggy? I don’t see that every day.";
     }
     else if (primeInt == 104){
       ArtChar1a.SetActive(false);
       ArtChar1d.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Matilda";
                  Char2speech.text = "Are there .. a lot of talking dogs on Ginipera?";
       }
	 else if (primeInt == 105){
                Char1name.text = "YOU";
                Char1speech.text = "How do you know that? Have humans discovered my planet already? I didn’t think you humans have advanced your technological expertise that far yet.";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 106){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="I don’t know what this “tec-oh-ology” thing is. I just heard it from you.";
     }
	 else if (primeInt == 107){
                Char1name.text = "YOU";
                Char1speech.text ="But I haven’t said anything about my home planet. How could you know?";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 108){
     ArtChar1d.SetActive(false);
     ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="I didn’t hear your mouth saying it. I heard it from your head.";
     }
	 else if (primeInt == 109){
                Char1name.text = "YOU";
                Char1speech.text ="A psychic? I’ve never heard of a human psychic.\nYour species aren't that advanced. ..";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 110){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="People’s heads have always talked to me. Their head voices are quieter, but I can hear them.";
     }
     else if (primeInt == 111){
                Char2name.text = "Matilda";
                Char2speech.text ="No one else seems to be able to. .. Your friends are coming too?";
     }
     else if (primeInt == 112){
       ArtChar1b.SetActive(false);
       ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="But they’re not coming to visit right? They’re coming ... to fight?";
     }
	 else if (primeInt == 113){
				        Char1name.text = "YOU";
                Char1speech.text ="It’s a complicated situation. Your fathers seem to have a level of authority here.";
                Char2name.text = "";
                Char2speech.text = "";
     }
     else if (primeInt == 114){
  				        Char1name.text = "YOU";
                  Char1speech.text ="I plan to consult with them in more detail.";
                  Char2name.text = "";
                  Char2speech.text = "";
       }
	 	 else if (primeInt == 115){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="Well that’s good. Both of my dads are the smartest people I know.";
	 }
   else if (primeInt == 116){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Matilda";
               Char2speech.text ="So what do you do on Ginipera? It doesn’t sound like a fun place.";
      Choice1a.SetActive(true);
      Choice1b.SetActive(true);
 }


     else if (primeInt == 200){
                Char1name.text = "YOU";
                 Char1speech.text ="Our civilization relies on organic resources to survive much like yours.";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
      else if (primeInt == 201){
                 Char1name.text = "YOU";
                  Char1speech.text ="Our planet's landscape is .. not suitable for growth, though.";
                  Char2name.text = "";
                  Char2speech.text = "";
       }
      else if (primeInt == 202){
                 Char1name.text = "YOU";
                  Char1speech.text ="We barely survive on technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable.";
       }
       else if (primeInt == 203){
                  Char1name.text = "YOU";
                   Char1speech.text ="We need other resources outside of our planet. And your planet has been chosen as the target.";
                   Char2name.text = "";
                   Char2speech.text = "";
        }
	 else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="Ohh. I see. So .. why are you here? Why do you want to warn us?";
     }
	 else if (primeInt == 205){
				        Char1name.text = "YOU";
                Char1speech.text ="I’ve always been fascinated with you humans. Your culture is so rich and diverse.";
                Char2name.text = "";
                Char2speech.text = "";
     }
     else if (primeInt == 206){
                   Char1name.text = "YOU";
                   Char1speech.text ="I just .. want to preserve that. I also believe cooperation is better than complete domination";
                   Char2name.text = "";
                   Char2speech.text = "";
        }
	 else if (primeInt == 207){
     ArtChar1d.SetActive(false);
     ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="Hmmm, I think it’s also good to have peace rather than fight for things too!";
     }
     else if (primeInt == 208){
                   Char2name.text = "Matilda";
                   Char2speech.text ="Dad has always told me that peace is always the first option we should go for.";
        }
	 else if (primeInt == 209){
				        Char1name.text = "YOU";
                Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them.";
                Char2name.text = "";
                Char2speech.text = "";
     }
     else if (primeInt == 210){
                  Char1name.text = "YOU";
                   Char1speech.text ="Unfortunately, some of my people believe that there's no other choice but to take what we need by force.";
                   Char2name.text = "";
                   Char2speech.text = "";
        }
        else if (primeInt == 211){
                     Char1name.text = "YOU";
                      Char1speech.text ="That is why I’m here to prevent that.";
                      Char2name.text = "";
                      Char2speech.text = "";
           }
	 else if (primeInt == 212){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="Don’t worry. My dads will take you to work tomorrow. You’ll save the world!";
     }
	 else if (primeInt == 213){
				        Char1name.text = "YOU";
                Char1speech.text ="Your parents seem like very capable people. I hope your government understands how urgent this is.";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 214){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be!";
     }
     else if (primeInt == 215){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Matilda";
                  Char2speech.text ="They can't ignore something this big, right?";
        }
	 else if (primeInt == 216){
				        Char1name.text = "YOU";
                Char1speech.text ="Like I said, I hope so.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
     }
	 else if (primeInt == 217){
     ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Hey, I got good news! The President--";
     }
     else if (primeInt == 218){
       ArtChar2b.SetActive(false);
       ArtChar2e.SetActive(true);
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "Evan";
                   Char3speech.text ="... Matilda. I thought I told you to do your homework.";
        }
	 else if (primeInt == 219){
     ArtChar1b.SetActive(false);
     ArtChar1a.SetActive(true);
				        Char2name.text = "Matilda";
                Char2speech.text ="Well the doggy started talking! Way cooler than doing some boring old math problems.";
                Char3name.text = "";
                Char3speech.text = "";
	 }
	 else if (primeInt == 220){
     ArtChar2e.SetActive(false);
     ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text = "You .. spoke in front of Matilda?!";
	 }
	 else if (primeInt == 221){
				        Char1name.text = "YOU";
                Char1speech.text ="I .. was not aware that my ability to talk was supposed to be a secret.";
                Char3name.text = "";
                Char3speech.text = "";
	 }
   else if (primeInt == 222){
                 Char1name.text = "YOU";
                 Char1speech.text ="I assumed that, if you were seemingly unfazed by my oherworldly origins, your child would be as well.";
                 Char3name.text = "";
                 Char3speech.text = "";
   }
	 else if (primeInt == 223){
                Char1name.text = "";
                Char1speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Tha--That’s not how that works! ... Whatever, it‘s okay. Everything’s fine. It’s fine.";
	 }
   else if (primeInt == 224){
     ArtChar2c.SetActive(false);
     ArtChar2a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "Evan";
                 Char3speech.text ="So. Now you know, sweetie.";
   }
		else if (primeInt == 225){
				        Char2name.text = "Matilda";
                Char2speech.text ="Yep. And I want to help!";
                Char3name.text = "";
                Char3speech.text = "";
	 }
	 else if (primeInt == 226){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Of course you do. Well, as I was saying, the President has agreed to meeting you, boy.";
	 }
   else if (primeInt == 226){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char3name.text = "Evan";
                 Char3speech.text ="I know you've probably had a long day and need to rest, but to meet him we'd need to leave now.";
   }
	 else if (primeInt == 227){
				        Char1name.text = "YOU";
                Char1speech.text ="Where are we going exactly?";
                Char3name.text = "";
                Char3speech.text = "";
	 }
	 else if (primeInt == 228){
                Char1name.text = "";
                Char1speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="To the nearest military encampment: Fort MacHeath.";
	 }
	 else if (primeInt == 229){
				        Char1name.text = "YOU";
                Char1speech.text ="Huh. I assumed it would’ve been more of a hassle to convince your government to agree to a meeting.";
                Char3name.text = "";
                Char3speech.text = "";
	 }
	 else if (primeInt == 230){
                Char1name.text = "";
                Char1speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Honestly, so did I. The Preseident must know something.";
	 }
   else if (primeInt == 231){
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "Evan";
                 Char3speech.text ="Anyway that’s enough talking, we need to head for Fort MacHeath. It’ll be about a three hour drive.";
   }
	 else if (primeInt == 232){
     ArtChar1a.SetActive(false);
     ArtChar1b.SetActive(true);
				        Char2name.text = "Matilda";
                Char2speech.text ="Ohhh, can I come?";
                Char3name.text = "";
                Char3speech.text = "";
	 }
	 else if (primeInt == 233){
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Well .. it's not like we have a choice. You can't be left alone in the house by yourself.";
	 }
	 else if (primeInt == 234){
				        Char2name.text = "Matilda";
                Char2speech.text ="Yay! Off to save the world! This is way better than math homework!";
                Char3name.text = "";
                Char3speech.text = "";
				NextScene1Button.SetActive(true);
	 }

	//SCENE 9 CHOICE 2:
	// ENCOUNTER AFTER CHOICE #1

	  else if (primeInt == 300){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text = "Ha! Try me, space doggy. I know more than you think.";
	  }
	   else if (primeInt == 301){
				        Char1name.text = "YOU";
                Char1speech.text = "Hmm, I guess so. You could always just pull the information from my head, can’t you?";
                Char2name.text = "";
                Char2speech.text = "";
	  }
	   else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text = "Exactly. It doesn't really work that way .. but close enough!";
	  }
    else if (primeInt == 303){
                Char1name.text = "YOU";
                Char1speech.text ="Well, Ginipera, in simple terms, is a rather vast planet, much larger than this one.";
                Char2name.text = "";
                Char2speech.text = "";
    }
    else if (primeInt == 304){
                Char1name.text = "YOU";
                ArtChar1b.SetActive(false);
                ArtChar1d.SetActive(true);
                Char1speech.text ="Our civilization relies on organic resources to survive much like yours.";
                Char2name.text = "";
                Char2speech.text = "";
     }
     else if (primeInt == 305){
                 Char1name.text = "YOU";
                 Char1speech.text ="Our planet's landscape is .. not suitable for growth, though.";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
     else if (primeInt == 306){
                 Char1name.text = "YOU";
                 Char1speech.text ="We barely survive on technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable.";
      }
      else if (primeInt == 307){
                  Char1name.text = "YOU";
                  Char1speech.text ="We need other resources outside of our planet. And your planet has been chosen as the target.";
                  Char2name.text = "";
                  Char2speech.text = "";
       }
    else if (primeInt == 308){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Matilda";
               Char2speech.text ="Ohh. I see. So .. why are you here? Why do you want to warn us?";
    }
    else if (primeInt == 309){
               Char1name.text = "YOU";
               Char1speech.text ="I’ve always been fascinated with you humans. Your culture is so rich and diverse.";
               Char2name.text = "";
               Char2speech.text = "";
    }
    else if (primeInt == 310){
                  Char1name.text = "YOU";
                  Char1speech.text ="I just .. want to preserve that. I also believe cooperation is better than complete domination";
                  Char2name.text = "";
                  Char2speech.text = "";
       }
  else if (primeInt == 311){
    ArtChar1d.SetActive(false);
    ArtChar1b.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Matilda";
               Char2speech.text ="Hmmm, I think it’s also good to have peace rather than fight for things too!";
    }
    else if (primeInt == 312){
                  Char2name.text = "Matilda";
                  Char2speech.text ="Dad has always told me that peace is always the first option we should go for.";
       }
   else if (primeInt == 313){
               Char1name.text = "YOU";
               Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them.";
               Char2name.text = "";
               Char2speech.text = "";
    }
    else if (primeInt == 314){
                 Char1name.text = "YOU";
                  Char1speech.text ="Unfortunately, some of my people believe that there's no other choice but to take what we need by force.";
                  Char2name.text = "";
                  Char2speech.text = "";
       }
       else if (primeInt == 315){
                    Char1name.text = "YOU";
                     Char1speech.text ="That is why I’m here to prevent that.";
                     Char2name.text = "";
                     Char2speech.text = "";
          }
  else if (primeInt == 316){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Matilda";
               Char2speech.text ="Don’t worry. My dads will take you to work tomorrow.You’ll save the world!";
    }
  else if (primeInt == 317){
               Char1name.text = "YOU";
               Char1speech.text ="Your parents seem like very capable people. I hope your government understands how urgent this is.";
               Char2name.text = "";
               Char2speech.text = "";
    }
  else if (primeInt == 318){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Matilda";
               Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be!";
    }
    else if (primeInt == 319){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Matilda";
                 Char2speech.text ="They can't ignore something this big, right?";
       }
  else if (primeInt == 320){
               Char1name.text = "YOU";
               Char1speech.text ="Like I said, I hope so.";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "";
               Char3speech.text = "";
    }
  else if (primeInt == 321){
    ArtChar2b.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Hey, I got good news! The President--";
    }
    else if (primeInt == 322){
      ArtChar2b.SetActive(false);
      ArtChar2e.SetActive(true);
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Evan";
                  Char3speech.text ="... Matilda. I thought I told you to do your homework.";
       }
  else if (primeInt == 323){
               Char2name.text = "Matilda";
               Char2speech.text ="Well the doggy started talking! Way cooler than doing some boring old math problems.";
               Char3name.text = "";
               Char3speech.text = "";
  }
  else if (primeInt == 324){
    ArtChar2e.SetActive(false);
    ArtChar2c.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text = "You .. spoke in front of Matilda?!";
  }
  else if (primeInt == 325){
               Char1name.text = "YOU";
               Char1speech.text ="I .. was not aware that it was supposed to be a secret that I could talk.";
               Char3name.text = "";
               Char3speech.text = "";
  }
  else if (primeInt == 326){
    ArtChar2c.SetActive(false);
    ArtChar2d.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text ="I assumed that, if you were seemingly unfazed by my oherworldly origins, your child would be as well.";
                Char3name.text = "";
                Char3speech.text = "";
  }
  else if (primeInt == 327){
               Char1name.text = "";
               Char1speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Tha--That’s not how that works! ... Whatever, it‘s okay. Everything’s fine.";
  }
  else if (primeInt == 328){
    ArtChar2d.SetActive(false);
    ArtChar1a.SetActive(true);
    ArtChar1b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text ="So. Now you know, sweetie.";
  }
   else if (primeInt == 329){
               Char2name.text = "Matilda";
               Char2speech.text ="Yep. And I want to help!";
               Char3name.text = "";
               Char3speech.text = "";
  }
  else if (primeInt == 330){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Of course you do. Well, as I was saying, the President has agreed to meeting you, boy.";
  }
  else if (primeInt == 331){
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text ="I know you've probably had a long day and need to rest, but to meet him we'd need to leave now.";
  }
  else if (primeInt == 332){
               Char1name.text = "YOU";
               Char1speech.text ="Where are we going exactly?";
               Char3name.text = "";
               Char3speech.text = "";
  }
  else if (primeInt == 333){
               Char1name.text = "";
               Char1speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="To the nearest military encampment: Fort MacHeath.";
  }
  else if (primeInt == 334){
               Char1name.text = "YOU";
               Char1speech.text ="Huh. I assumed it would’ve been more of a hassle to convince your government to agree to a meeting.";
               Char3name.text = "";
               Char3speech.text = "";
  }
  else if (primeInt == 335){
               Char1name.text = "";
               Char1speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Honestly, so did I. The Preseident must know something.";
  }
  else if (primeInt == 336){
    ArtChar2d.SetActive(false);
    ArtChar2a.SetActive(true);
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text ="Anyway that’s enough talking, we need to head for Fort MacHeath. It’ll be about a three hour drive.";
  }
  else if (primeInt == 337){
    ArtChar1a.SetActive(false);
    ArtChar1b.SetActive(true);
               Char2name.text = "Matilda";
               Char2speech.text ="Ohhh, can I come?";
               Char3name.text = "";
               Char3speech.text = "";
  }
  else if (primeInt == 338){

               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Well .. it's not like we have a choice. You can't be left alone in the house by yourself.";
  }
  else if (primeInt == 339){
               Char2name.text = "Matilda";
               Char2speech.text ="Yay! Off to save the world! This is way better than math homework!";
               Char3name.text = "";
               Char3speech.text = "";
       NextScene1Button.SetActive(true);
  }



//SCENE 9: NO COMM DEVICE
	 else if (primeInt == 400){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="You're not acutally a dog, are you?";
	 }
	 else if (primeInt == 401){
				        Char1name.text = "YOU";
                Char1speech.text ="(Huh? How .. how does this human know?)";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 402){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="How? Your head told me. I can hear your head voice!";
	 }
	 else if (primeInt == 403){
				        Char1name.text = "YOU";
                Char1speech.text ="A psychic? I’ve never heard of a human psychic.\nYour species shouldn’t have developed enough to possess that ability.";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 404){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="People’s heads have always talked to me. Their heads voices are quieter but I can hear them.";
	 }
   else if (primeInt == 405){
                 Char1name.text = "";
                 Char1speech.text = "";
                Char2name.text = "Matilda";
                 Char2speech.text ="No one else seems to be able to. But don’t tell anyone. Nobody knows about it and I want to keep it that way.";
   }
   else if (primeInt == 406){
                 Char1name.text = "";
                 Char1speech.text = "";
                Char2name.text = "Matilda";
                 Char2speech.text ="Up until something big comes by where I get to surprise the heck out of everyone, obviously.";
   }
	 else if (primeInt == 407){
        				Char1name.text = "YOU";
                Char1speech.text ="(What a strange human. .. )";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 408){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="You might think I’m strange, but I prefer the word cooky like this!";
	 }
   else if (primeInt == 408){
                 Char1name.text = "";
                 Char1speech.text = "";
                Char2name.text = "Matilda";
                 Char2speech.text ="Now let’s see what’s going on in that noggin of yours. Your .. friends .. are coming too? But they’re not coming to visit right? They’re coming… to fight?";
   }
   else if (primeInt == 409){
                 Char1name.text = "";
                 Char1speech.text = "";
                Char2name.text = "Matilda";
                 Char2speech.text ="But they’re not coming to visit, right? They’re coming .. to fight?";
   }
	 else if (primeInt == 410){
				        Char1name.text = "YOU";
                Char1speech.text ="It’s complicated, but yes this planet is in danger. I need to talk to the person in charge.";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 411){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="Hmm, that would probably be my dads. They work in an office where they beat bad guys and talk to people in neat suits.";
	 }
   else if (primeInt == 412){
                 Char1name.text = "";
                 Char1speech.text = "";
                Char2name.text = "Matilda";
                 Char2speech.text ="They’re the coolest! Though not as cool as me. They can’t read brains. ";
   }
	 else if (primeInt == 413){
				        Char1name.text = "YOU";
                Char1speech.text ="I figured at much. What can I do to convince them?";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 414){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="I could translate for you but first you have to tell me a bit more about yourself.";
	 }
   else if (primeInt == 414){
                 Char1name.text = "";
                 Char1speech.text = "";
                Char2name.text = "Matilda";
                 Char2speech.text ="What’s Ginipera like?";
        Choice2a.SetActive(true);
        Choice2b.SetActive(true);
   }

   else if (primeInt == 500){
              Char1name.text = "YOU";
               Char1speech.text ="Our civilization relies on organic resources to survive much like yours.";
               Char2name.text = "";
               Char2speech.text = "";
    }
    else if (primeInt == 501){
               Char1name.text = "YOU";
                Char1speech.text ="Our planet's landscape is .. not suitable for growth, though.";
                Char2name.text = "";
                Char2speech.text = "";
     }
    else if (primeInt == 502){
               Char1name.text = "YOU";
                Char1speech.text ="We barely survive on technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable.";
     }
     else if (primeInt == 503){
                Char1name.text = "YOU";
                 Char1speech.text ="We need other resources outside of our planet. And your planet has been chosen as the target.";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
   else if (primeInt == 504){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Matilda";
              Char2speech.text ="Ohh. I see. So .. why are you here? Why do you want to warn us?";
   }
   else if (primeInt == 505){
              Char1name.text = "YOU";
              Char1speech.text ="I’ve always been fascinated with you humans. Your culture is so rich and diverse.";
              Char2name.text = "";
              Char2speech.text = "";
   }
   else if (primeInt == 506){
                 Char1name.text = "YOU";
                 Char1speech.text ="I just .. want to preserve that. I also believe cooperation is better than complete domination";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
   else if (primeInt == 507){
   ArtChar1d.SetActive(false);
   ArtChar1b.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Matilda";
              Char2speech.text ="Hmmm, I think it’s also good to have peace rather than fight for things too!";
   }
   else if (primeInt == 508){
                 Char2name.text = "Matilda";
                 Char2speech.text ="Dad has always told me that peace is always the first option we should go for.";
      }
   else if (primeInt == 509){
              Char1name.text = "YOU";
              Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them.";
              Char2name.text = "";
              Char2speech.text = "";
   }
   else if (primeInt == 510){
                Char1name.text = "YOU";
                 Char1speech.text ="Unfortunately, some of my people believe that there's no other choice but to take what we need by force.";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
      else if (primeInt == 511){
                   Char1name.text = "YOU";
                    Char1speech.text ="That is why I’m here to prevent that.";
                    Char2name.text = "";
                    Char2speech.text = "";
         }
   else if (primeInt == 512){
     ArtChar1b.SetActive(false);
     ArtChar1a.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Matilda";
              Char2speech.text ="Don’t worry. My dads will take you to work tomorrow and you’ll save the world!";
   }
   else if (primeInt == 513){
              Char1name.text = "YOU";
              Char1speech.text ="Your parents seem like very capable people. I hope your government understands how urgent this is.";
              Char2name.text = "";
              Char2speech.text = "";
   }
   else if (primeInt == 514){
     ArtChar1a.SetActive(false);
     ArtChar1b.SetActive(true);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Matilda";
              Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be!";
   }
   else if (primeInt == 515){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="They can't ignore something this big, right?";
      }
   else if (primeInt == 516){
              Char1name.text = "YOU";
              Char1speech.text ="Like I said, I hope so.";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "";
   }

	 else if (primeInt == 517){
     ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Hey Mat', I told you to go get your homework done. The doggy is seriously not going to go anywhere I promise.";
     }
	 else if (primeInt == 518){
     ArtChar1b.SetActive(false);
     ArtChar1d.SetActive(true);
				        Char2name.text = "Matilda";
                Char2speech.text ="Actually Dad, there is something I wanna tell you. I can read minds.";
                Char3name.text = "";
                Char3speech.text = "";
     }
	 else if (primeInt == 519){
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Haha very funny. If you think saying something like that will get you out of doing homework then think again.";
     }
	 else if (primeInt == 520){
				        Char2name.text = "Matilda";
                Char2speech.text ="Dad, I’m serious. I can read what you’re thinking.";
                Char3name.text = "";
                Char3speech.text = "";
     }
     else if (primeInt == 521){
                  Char2name.text = "Matilda";
                   Char2speech.text ="Like right now, you’re thinking about how much paperwork you and Dad have to do because of the damage that was caused during drug farm raid.";
                   Char3name.text = "";
                   Char3speech.text = "";
        }
        else if (primeInt == 522){
                     Char2name.text = "Matilda";
                      Char2speech.text =" .. And now you’re thinking about how cute Dad looked while he was shoo--";
                      Char3name.text = "";
                      Char3speech.text = "";
           }
	 else if (primeInt == 523){
     ArtChar2d.SetActive(false);
     ArtChar2c.SetActive(true);
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Woah woah, that is .. more than enough, thank you very much!";
     }
     else if (primeInt == 523){
                   Char2name.text = "";
                   Char2speech.text = "";
                  Char3name.text = "Evan";
                   Char3speech.text ="Jesus, you really weren’t lying. How long have you been able to do that?";
        }
	 else if (primeInt == 524){
				Char2name.text = "Matilda";
                Char2speech.text ="Since I could remember.";
                Char3name.text = "";
                Char3speech.text = "";
     }
	 else if (primeInt == 525){
     Char2name.text = "";
     Char2speech.text = "";
				Char3name.text = "Evan";
                Char3speech.text ="So you’re telling me that you’ve always been able to read people’s minds? That you’ve always know what I was thinking about? ";
     }
     else if (primeInt == 526){
        Char2name.text = "";
        Char2speech.text = "";
          Char3name.text = "Evan";
                   Char3speech.text ="That you’ve always known what I was thinking about? ";
        }
	 else if (primeInt == 527){
				Char2name.text = "Matilda";
                Char2speech.text ="For the most part. It’s not like I’m ALWAYS listening to what your head has to say.";
                Char3name.text = "";
                Char3speech.text = "";
     }
	 else if (primeInt == 528){
     Char2name.text = "";
     Char2speech.text = "";
				Char3name.text = "Evan";
                Char3speech.text ="Wow .. just wow. I can’t believe I’ve never noticed..";
     }
     else if (primeInt == 529){
       Char2name.text = "";
       Char2speech.text = "";
          Char3name.text = "Evan";
                   Char3speech.text ="My daughter's a freakin’ psychic.";
        }
        else if (primeInt == 530){
          ArtChar3a.SetActive(true);
          Char2name.text = "";
          Char2speech.text = "";
             Char3name.text = "";
                      Char3speech.text ="";
                      Char4name.text= "Chris";
                      Char4speech.text="Eh, I always had a hunch.";
           }
           else if (primeInt == 531){
             ArtChar3a.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(true);
             Char2name.text = "";
             Char2speech.text = "";
                Char3name.text = "Evan";
                         Char3speech.text ="Not helping!";
                         Char4name.text= "";
                         Char4speech.text="";
              }
	 else if (primeInt == 532){
				Char2name.text = "Matilda";
                Char2speech.text ="It's’s great that you’re freaked out and all, because you’re about to hear something freakier.";
                Char3name.text = "";
                Char3speech.text = "";
     }
     else if (primeInt == 533){
          Char2name.text = "Matilda";
                   Char2speech.text ="We’re all going to die by this time tomorrow .. because of an alien invasion!";
                   Char3name.text = "";
                   Char3speech.text = "";
        }
	 else if (primeInt == 534){
     ArtChar2d.SetActive(false);
     ArtChar2c.SetActive(true);
     Char2name.text = "";
     Char2speech.text = "";
				Char3name.text = "Evan";
                Char3speech.text ="Wait, wait ... what?";
     }
	 else if (primeInt == 535){
				Char2name.text = "Matilda";
                Char2speech.text ="Yeah. By tomorrow, our planet will be drained of life! People will get really hurt!";
                Char3name.text = "";
                Char3speech.text = "";
     }
     else if (primeInt == 536){
          Char2name.text = "Matilda";
                   Char2speech.text ="People might even... ";
                   Char3name.text = "";
                   Char3speech.text = "";
        }
	 else if (primeInt == 537){
     Char2name.text = "";
     Char2speech.text = "";
				Char3name.text = "Evan";
                Char3speech.text ="How is that even possible? How could you even know that such a thing will happen?";
     }
	 else if (primeInt == 538){
     ArtChar1d.SetActive(false);
     ArtChar1b.SetActive(true);
				Char2name.text = "Matilda";
                Char2speech.text ="Because of the doggy here. He’s not actually a doggy..";
                Char3name.text = "";
                Char3speech.text = "";
     }
     else if (primeInt == 539){
        ArtChar1d.SetActive(false);
        ArtChar1b.SetActive(true);
          Char2name.text = "Matilda";
                   Char2speech.text ="He’s a alien from another planet! Say hi, doggy-alien-thing!";
                   Char3name.text = "";
                   Char3speech.text = "";
        }
	 else if (primeInt == 540){
     Char2name.text = "";
     Char2speech.text = "";
				Char3name.text = "Evan";
                Char3speech.text ="Wait, the dog? What is even going on right now? Matilda. I’m gonna need you to explain everything.";
        allowSpace=false;
        nextButton.SetActive(false);
				NextScene1Button.SetActive(true);
	 }

//CHOICE 2
else if (primeInt == 600){
            Char1name.text = "";
            Char1speech.text = "";
           Char2name.text = "Matilda";
            Char2speech.text = "Ha! Try me, space doggy. I know more than you think.";
}
else if (primeInt == 601){
           Char1name.text = "YOU";
            Char1speech.text = "Hmm, I guess so. You could always just pull the information from my head, can’t you?";
            Char2name.text = "";
            Char2speech.text = "";
}
else if (primeInt == 602){
            Char1name.text = "";
            Char1speech.text = "";
           Char2name.text = "Matilda";
            Char2speech.text = "Exactly. It doesn't really work that way .. but close enough!";
}
else if (primeInt == 603){
           Char1name.text = "YOU";
            Char1speech.text ="Our civilization relies on organic resources to survive much like yours.";
            Char2name.text = "";
            Char2speech.text = "";
 }
 else if (primeInt == 604){
            Char1name.text = "YOU";
             Char1speech.text ="Our planet's landscape is .. not suitable for growth, though.";
             Char2name.text = "";
             Char2speech.text = "";
  }
 else if (primeInt == 605){
            Char1name.text = "YOU";
             Char1speech.text ="We barely survive on technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable.";
  }
  else if (primeInt == 606){
             Char1name.text = "YOU";
              Char1speech.text ="We need other resources outside of our planet. And your planet has been chosen as the target.";
              Char2name.text = "";
              Char2speech.text = "";
   }
else if (primeInt == 607){
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "Matilda";
           Char2speech.text ="Ohh. I see. So .. why are you here? Why do you want to warn us?";
}
else if (primeInt == 608){
           Char1name.text = "YOU";
           Char1speech.text ="I’ve always been fascinated with you humans. Your culture is so rich and diverse.";
           Char2name.text = "";
           Char2speech.text = "";
}
else if (primeInt == 609){
              Char1name.text = "YOU";
              Char1speech.text ="I just .. want to preserve that. I also believe cooperation is better than complete domination";
              Char2name.text = "";
              Char2speech.text = "";
   }
else if (primeInt == 610){
ArtChar1d.SetActive(false);
ArtChar1b.SetActive(true);
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "Matilda";
           Char2speech.text ="Hmmm, I think it’s also good to have peace rather than fight for things too!";
}
else if (primeInt == 611){
              Char2name.text = "Matilda";
              Char2speech.text ="Dad has always told me that peace is always the first option we should go for.";
   }
else if (primeInt == 612){
           Char1name.text = "YOU";
           Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them.";
           Char2name.text = "";
           Char2speech.text = "";
}
else if (primeInt == 613){
             Char1name.text = "YOU";
              Char1speech.text ="Unfortunately, some of my people believe that there's no other choice but to take what we need by force.";
              Char2name.text = "";
              Char2speech.text = "";
   }
   else if (primeInt == 614){
                Char1name.text = "YOU";
                 Char1speech.text ="That is why I’m here to prevent that.";
                 Char2name.text = "";
                 Char2speech.text = "";
      }
else if (primeInt == 615){
  ArtChar1b.SetActive(false);
  ArtChar1a.SetActive(true);
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "Matilda";
           Char2speech.text ="Don’t worry. My dads will take you to work tomorrow and you’ll save the world!";
}
else if (primeInt == 616){
           Char1name.text = "YOU";
           Char1speech.text ="Your parents seem like very capable people. I hope your government understands how urgent this is.";
           Char2name.text = "";
           Char2speech.text = "";
}
else if (primeInt == 617){
  ArtChar1a.SetActive(false);
  ArtChar1b.SetActive(true);
           Char1name.text = "";
           Char1speech.text = "";
           Char2name.text = "Matilda";
           Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be!";
}
else if (primeInt == 618){
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "Matilda";
             Char2speech.text ="They can't ignore something this big, right?";
   }
else if (primeInt == 619){
           Char1name.text = "YOU";
           Char1speech.text ="Like I said, I hope so.";
           Char2name.text = "";
           Char2speech.text = "";
           Char3name.text = "";
           Char3speech.text = "";
}

else if (primeInt == 620){
  ArtChar2d.SetActive(true);
             Char1name.text = "";
             Char1speech.text = "";
             Char2name.text = "";
             Char2speech.text = "";
             Char3name.text = "Evan";
             Char3speech.text ="Hey Mat', I told you to go get your homework done. The doggy is seriously not going to go anywhere I promise.";
  }
else if (primeInt == 621){
  ArtChar1b.SetActive(false);
  ArtChar1d.SetActive(true);
             Char2name.text = "Matilda";
             Char2speech.text ="Actually Dad, there is something I wanna tell you. I can read minds.";
             Char3name.text = "";
             Char3speech.text = "";
  }
else if (primeInt == 622){
             Char2name.text = "";
             Char2speech.text = "";
             Char3name.text = "Evan";
             Char3speech.text ="Haha very funny. If you think saying something like that will get you out of doing homework then think again.";
  }
else if (primeInt == 623){
             Char2name.text = "Matilda";
             Char2speech.text ="Dad, I’m serious. I can read what you’re thinking.";
             Char3name.text = "";
             Char3speech.text = "";
  }
  else if (primeInt == 624){
               Char2name.text = "Matilda";
                Char2speech.text ="Like right now, you’re thinking about how much paperwork you and Dad have to do because of the damage that was caused during drug farm raid.";
                Char3name.text = "";
                Char3speech.text = "";
     }
     else if (primeInt == 625){
                  Char2name.text = "Matilda";
                   Char2speech.text =" .. And now you’re thinking about how cute Dad looked while he was shoo--";
                   Char3name.text = "";
                   Char3speech.text = "";
        }
else if (primeInt == 626){
  ArtChar2d.SetActive(false);
  ArtChar2c.SetActive(true);
             Char2name.text = "";
             Char2speech.text = "";
             Char3name.text = "Evan";
             Char3speech.text ="Woah woah, that is .. more than enough, thank you very much!";
  }
  else if (primeInt == 627){
                Char2name.text = "";
                Char2speech.text = "";
               Char3name.text = "Evan";
                Char3speech.text ="Jesus, you really weren’t lying. How long have you been able to do that?";
     }
else if (primeInt == 628){
     Char2name.text = "Matilda";
             Char2speech.text ="Since I could remember.";
             Char3name.text = "";
             Char3speech.text = "";
  }
else if (primeInt == 629){
  Char2name.text = "";
  Char2speech.text = "";
     Char3name.text = "Evan";
             Char3speech.text ="So you’re telling me that you’ve always been able to read people’s minds? That you’ve always know what I was thinking about? ";
  }
  else if (primeInt == 630){
     Char2name.text = "";
     Char2speech.text = "";
       Char3name.text = "Evan";
                Char3speech.text ="That you’ve always known what I was thinking about? ";
     }
else if (primeInt == 631){
     Char2name.text = "Matilda";
             Char2speech.text ="For the most part. It’s not like I’m ALWAYS listening to what your head has to say.";
             Char3name.text = "";
             Char3speech.text = "";
  }
else if (primeInt == 632){
  Char2name.text = "";
  Char2speech.text = "";
     Char3name.text = "Evan";
             Char3speech.text ="Wow .. just wow. I can’t believe I’ve never noticed..";
  }
  else if (primeInt == 633){
    Char2name.text = "";
    Char2speech.text = "";
       Char3name.text = "Evan";
                Char3speech.text ="My daughter's a freakin’ psychic.";
                Char4name.text= "";
                Char4speech.text="";
     }
     else if (primeInt == 634){
       ArtChar3a.SetActive(true);
       Char2name.text = "";
       Char2speech.text = "";
          Char3name.text = "";
                   Char3speech.text ="";
                   Char4name.text= "Chris";
                   Char4speech.text="Eh, I always had a hunch.";
        }
        else if (primeInt == 635){
          ArtChar3a.SetActive(false);
          ArtChar2c.SetActive(false);
          ArtChar2d.SetActive(true);
          Char2name.text = "";
          Char2speech.text = "";
             Char3name.text = "Evan";
                      Char3speech.text ="Not helping!";
                      Char4name.text= "";
                      Char4speech.text="";
           }
else if (primeInt == 636){
     Char2name.text = "Matilda";
             Char2speech.text ="It's’s great that you’re freaked out and all, because you’re about to hear something freakier.";
             Char3name.text = "";
             Char3speech.text = "";
  }
  else if (primeInt == 637){
       Char2name.text = "Matilda";
                Char2speech.text ="We’re all going to die by this time tomorrow .. because of an alien invasion!";
                Char3name.text = "";
                Char3speech.text = "";
     }
else if (primeInt == 638){
  ArtChar2d.SetActive(false);
  ArtChar2c.SetActive(true);
  Char2name.text = "";
  Char2speech.text = "";
     Char3name.text = "Evan";
             Char3speech.text ="Wait, wait ... what?";
  }
else if (primeInt == 639){
     Char2name.text = "Matilda";
             Char2speech.text ="Yeah. By tomorrow, our planet will be drained of life! People will get really hurt!";
             Char3name.text = "";
             Char3speech.text = "";
  }
  else if (primeInt == 640){
       Char2name.text = "Matilda";
                Char2speech.text ="People might even... ";
                Char3name.text = "";
                Char3speech.text = "";
     }
else if (primeInt == 641){
  Char2name.text = "";
  Char2speech.text = "";
     Char3name.text = "Evan";
             Char3speech.text ="How is that even possible? How could you even know that such a thing will happen?";
  }
else if (primeInt == 642){
  ArtChar1d.SetActive(false);
  ArtChar1b.SetActive(true);
     Char2name.text = "Matilda";
             Char2speech.text ="Because of the doggy here. He’s not actually a doggy..";
             Char3name.text = "";
             Char3speech.text = "";
  }
  else if (primeInt == 643){
     ArtChar1d.SetActive(false);
     ArtChar1b.SetActive(true);
       Char2name.text = "Matilda";
                Char2speech.text ="He’s a alien from another planet! Say hi, doggy-alien-thing!";
                Char3name.text = "";
                Char3speech.text = "";
     }
else if (primeInt == 644){
  Char2name.text = "";
  Char2speech.text = "";
     Char3name.text = "Evan";
             Char3speech.text ="Wait, the dog? What is even going on right now? Matilda. I’m gonna need you to explain everything.";
     allowSpace=false;
     nextButton.SetActive(false);
     NextScene1Button.SetActive(true);
}

else if (primeInt==700){
  ArtChar2a.SetActive(true);
  ArtChar3b.SetActive(true);
Char1name.text= "";
Char1speech.text= "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "Chris";
Char4speech.text = "Oh? Could this be another one of your art--";
}
else if (primeInt==701){
  ArtChar2a.SetActive(false);
  ArtChar3b.SetActive(false);
  ArtChar2c.SetActive(true);
  ArtChar3c.SetActive(true);
DialogueDisplay.SetActive(false);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==702){
DialogueDisplay.SetActive(true);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "Chris";
Char4speech.text = "Mat', is that .. a dog?";
}
else if (primeInt==703){
  ArtChar2c.SetActive(false);
  ArtChar2b.SetActive(true);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "Aww, and he's a cute one at that! How'd you find him?";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==704){
Char2name.text = "Matilda";
Char2speech.text = "Came up to me and followed me home!";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==705){
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "How sweet!";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==706){
  ArtChar3c.SetActive(false);
  ArtChar3d.SetActive(true);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "Chris";
Char4speech.text = "... Won't be very sweet once it starts to foam at the mouth.";
}
else if (primeInt==707){
  ArtChar2b.SetActive(false);
  ArtChar2d.SetActive(true);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "Honestly honey, how likely is that going to happen?";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==708){
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "The vet is closed now anyway so we wouldn't even be able to take him there.";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==709){
  ArtChar2d.SetActive(false);
  ArtChar2a.SetActive(true);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "Evan";
Char3speech.text = "Come on .. just for one night?";
Char4name.text = "";
Char4speech.text = "";
}
else if (primeInt==710){
  ArtChar3d.SetActive(false);
  ArtChar3a.SetActive(true);
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "Chris";
Char4speech.text = " .. Fine, fine. Oh, and we need to start making dinner.";
}
else if (primeInt==711){
Char1name.text= "";
Char1speech.text= "";
Char2name.text = "";
Char2speech.text = "";
Char3name.text = "";
Char3speech.text = "";
Char4name.text = "Chris";
Char4speech.text = " Behave well, you two. We'll tell you when it's ready!";
}
else if (primeInt==712){
  ArtChar2a.SetActive(false);
  ArtChar3a.SetActive(false);
          Char1name.text= "YOU";
          Char1speech.text= " .. So, those are your fathers.";
          Char2name.text = "";
          Char2speech.text = "";
          Char4name.text = "";
          Char4speech.text = "";
        }
      else if (primeInt==713){
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(true);
        Char1name.text= "";
        Char1speech.text= "";
        Char2name.text = "Matilda";
        Char2speech.text = "Mhm!";
            }
    else if (primeInt==714){
            Char1name.text= "YOU";
            Char1speech.text= "And you mentioned them having some kind of government connections.";
            Char2name.text = "";
            Char2speech.text = "";
          }
    else if (primeInt==715){
        Char1name.text= "";
        Char1speech.text= "";
        Char2name.text = "Matilda";
        Char2speech.text = "Yeah! I have an idea, but .. I gotta be kinda sneaky about it.";
          }
    else if (primeInt==716){
        Char1name.text= "YOU";
        Char1speech.text= "You aren't going to put yourself in danger are you..?!";
        Char2name.text = "";
        Char2speech.text = "";
          }
    else if (primeInt==717){
        Char1name.text= "";
        Char1speech.text= "";
        Char2name.text = "Matilda";
        Char2speech.text = "What, no! My dads have this cool new oval office communicator thingy.";
          }
    else if (primeInt==718){
          Char1name.text= "";
          Char1speech.text= "";
          Char2name.text = "Matilda";
          Char2speech.text = "It's like, super top secret too.";
          }
    else if (primeInt==720){
          Char1name.text= "YOU";
          Char1speech.text= "Oh. .. Well, that's convenient.";
          Char2name.text = "";
          Char2speech.text = "";
          }
          else if (primeInt==721){
          Char1name.text= "";
          Char1speech.text= "";
          Char2name.text = "Matilda";
          Char2speech.text = "Yeah! The message will go through the communi-thing, the president'll have to take it super seriously!";
          }
          else if (primeInt==722){
          Char1name.text= "YOU";
          Char1speech.text= "Wonderful. .. Human, your help has been much appreciated.";
          Char2name.text = "";
          Char2speech.text = "";
          }
          else if (primeInt==723){
          Char1name.text= "";
          Char1speech.text= "";
          Char2name.text = "Matilda";
          Char2speech.text = "No problem! Now let's go save the world!";
          allowSpace=false;
          nextButton.SetActive(false);
          NextScene1Button.SetActive(true);
          }
}



// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)

		public void Choice1aFunct(){
      Char1name.text = "YOU";
      Char1speech.text ="Well, Ginipera, in simple terms, is a rather vast planet, much larger than this one.";
      Char2name.text = "";
      Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = true;
        }

		public void Choice1bFunct(){
              Char1name.text = "YOU";
              Char1speech.text = "I don't think someone of your age would be able to comprehend it.";
              Char2name.text = "";
              Char2speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				nextButton.SetActive(true);
                allowSpace = true;
		}

		public void Choice2aFunct(){
      Char1name.text = "YOU";
      Char1speech.text ="Well, Ginipera, in simple terms, is a rather vast planet, much larger than this one.";
      Char2name.text = "";
      Char2speech.text = "";
                primeInt = 499;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
		}

		public void Choice2bFunct(){
              Char1name.text = "YOU";
              Char1speech.text = "I don't think someone of your age would be able to comprehend it.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 599;
                Choice2a.SetActive(false);
				Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("End_GoodEnd2");
        }
}
