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
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c; // EvanShocked
        public GameObject ArtChar1d; // EvanAngry // EvanAnnoyed
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
    }
     else if (GameHandler.metMatilda==true){
       primeInt=699;
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
        else if (primeInt == 2){
               ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Hey, Dad!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==3){
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "Hey, honey how was school?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char2name.text = "Matilda";
                Char2speech.text = "School was fine, but you will not believe what I saw when I coming home.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 5){
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "Yeah? What did you see, Mat'?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "I saw a star fall down from the sky. Isn't that wierd?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 7){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Matilda";
                 Char2speech.text = "Stars aren't supposed to be out in the middle of the day.";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
         }
       else if (primeInt ==8){
                Char1name.text = "YOU";
                Char1speech.text = "(Oh. I forgot about the wreckage of my ship. .. )";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "Wow, I wonder what that coudld've been. Well, don't worry honey. I'm sure it's nothing.";
	   }
		else if (primeInt == 10){
                Char2name.text = "Matilda";
                Char2speech.text = "Oh hey doggy! .. Wait, when did we get a dog?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 11){
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "Oh, Daddy and I found this little fella outside our door earlier. Wanna say hi?";
	   }
	   else if (primeInt == 12){
                Char2name.text = "Matilda";
                Char2speech.text = "Wow, your fur is so pretty.";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 13){
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "Don't you have homework to do, Mat'? You can play with the doggy after you're done with that.";
	   }
		else if (primeInt == 14){
                Char2name.text = "Matilda";
                Char2speech.text = "Awww, but I want to play with the new doggy now!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 15){
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text = "There’ll be plenty of time to play AFTER you’re done. Don’t worry, the doggy isn’t going anywhere.";
	   }
		else if (primeInt == 16){
                Char2name.text = "Matilda";
                Char2speech.text = "Hmph. Fine, fine.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
	   }
		else if (primeInt == 17){
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Chris";
                Char4speech.text = "That’s the spirit. I‘m gonna help daddy finish up dinner now. You behave now. Don’t get into trouble.";
	   }
     else if (primeInt == 18){
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char4name.text = "Chris";
                  Char4speech.text = "You behave now, boy. Don’t get into trouble.";
      }

			if (GameHandler.hasComm == true){
        primeInt = 99;}
    else if (GameHandler.hasProof == true){
        primeInt = 399;}



// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "What should we do, doggy? You like playing catch?";
                Char4name.text = "";
                Char4speech.text = "";
	   }
        else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "I most certainly do not.";
                Char2name.text = "";
                Char2speech.text = "";
     }
     else if (primeInt == 102){
             Char1name.text = "YOU";
             Char1speech.text = "I don’t think it’s appropriate for someone of my intellectual standing to be involved in such boorish activities.";
             Char2name.text = "";
             Char2speech.text = "";
  }
  else if (primeInt == 103){
          Char1name.text = "YOU";
          Char1speech.text = "You should also most definitely not be disobeying your parental figues.";
          Char2name.text = "";
          Char2speech.text = "";
}
	  else if (primeInt == 104){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Ohhh a talking doggy? I don’t see that every day.";
     }
     else if (primeInt == 105){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Matilda";
                  Char2speech.text = "Are there .. a lot of talking dogs on Ginipera?";
       }
	 else if (primeInt == 106){
                Char1name.text = "YOU";
                Char1speech.text = "How do you know that? Have humans discovered my planet already? I didn’t think you humans have advanced your technological expertise that far yet.";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 107){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="I don’t know what this “tec-oh-ology” thing is. I just heard it from you.";
     }
	 else if (primeInt == 108){
                Char1name.text = "YOU";
                Char1speech.text ="But I haven’t said anything about my home planet. How could you know?";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 109){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="I didn’t hear your mouth saying it. I heard it from your head.";
     }
	 else if (primeInt == 110){
                Char1name.text = "YOU";
                Char1speech.text ="A psychic? I’ve never heard of a human psychic.\nYour species shouldn’t have developed enough to possess that ability.";
                Char2name.text = "";
                Char2speech.text = "";
     }
	 else if (primeInt == 111){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="People’s heads have always talked to me. Their head voices are quieter, but I can hear them.";
     }
     else if (primeInt == 112){
                Char2name.text = "Matilda";
                Char2speech.text ="No one else seems to be able to. .. Your friends are coming too?";
     }
     else if (primeInt == 113){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text ="But they’re not coming to visit right? They’re coming ... to fight?";
     }
	 else if (primeInt == 114){
				        Char1name.text = "YOU";
                Char1speech.text ="It’s a complicated situation but I’ve talked with your parental figures. They understand the situation.";
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
                Char2speech.text ="Don’t worry. My dads will take you to work tomorrow.You’ll save the world!";
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
                Char2name.text = "";
                Char2speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text ="Hey, I got good news! The President--";
     }
     else if (primeInt == 218){
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "Evan";
                   Char3speech.text ="... Matilda. I thought I told you to do your homework.";
        }
	 else if (primeInt == 219){
				        Char2name.text = "Matilda";
                Char2speech.text ="Well the doggy started talking! Way cooler than doing some boring old math problems.";
                Char3name.text = "";
                Char3speech.text = "";
	 }
	 else if (primeInt == 220){
                Char1name.text = "";
                Char1speech.text = "";
				        Char3name.text = "Evan";
                Char3speech.text = "You .. spoke in front of Matilda?!";
	 }
	 else if (primeInt == 221){
				        Char1name.text = "YOU";
                Char1speech.text ="I .. was not aware that it was supposed to be a secret that I could talk.";
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
                Char3speech.text ="Tha--That’s not how that works! ... Whatever, it‘s okay. Everything’s fine. It’s fine.(turns to Matilda) So now you know Matilda.";
	 }
   else if (primeInt == 224){
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
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Hey, I got good news! The President--";
    }
    else if (primeInt == 322){
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
               Char1name.text = "";
               Char1speech.text = "";
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
                Char1name.text = "YOU";
                Char1speech.text ="I assumed that, if you were seemingly unfazed by my oherworldly origins, your child would be as well.";
                Char3name.text = "";
                Char3speech.text = "";
  }
  else if (primeInt == 327){
               Char1name.text = "";
               Char1speech.text = "";
               Char3name.text = "Evan";
               Char3speech.text ="Tha--That’s not how that works! ... Whatever, it‘s okay. Everything’s fine. It’s fine.(turns to Matilda) So now you know Matilda.";
  }
  else if (primeInt == 328){
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
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Evan";
                Char3speech.text ="Anyway that’s enough talking, we need to head for Fort MacHeath. It’ll be about a three hour drive.";
  }
  else if (primeInt == 337){
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
                Char2speech.text ="People’s heads have always talked to me. Their heads’ voices are quieter but I can hear them.  No one else seems to be able to. But don’t tell anyone. Nobody knows about it and I want to keep it that way until something big comes by where I get to surprise the heck out of everyone.";
	 }
	 else if (primeInt == 405){
        				Char1name.text = "YOU";
                Char1speech.text ="What a strange human. ..";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 406){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="You might think I’m strange, but I prefer the word cooky like this! Now let’s see what’s going on in that noggin of yours. Your friends are coming too? But they’re not coming to visit right? They’re coming… to fight?";
	 }
	 else if (primeInt == 407){
				        Char1name.text = "YOU";
                Char1speech.text ="It’s complicated, but yes this planet is in danger. I need to talk to the person in charge.";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 408){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="Hmm, that would probably be my dads. They work in a big office where they beat bad guys and talk to people in neat suits. They’re the coolest! Though not as cool as me. They can’t read brains. ";
	 }
	 else if (primeInt == 409){
				        Char1name.text = "YOU";
                Char1speech.text ="I figured at much. What can I do to convince them?";
                Char2name.text = "";
                Char2speech.text = "";
	 }
	 else if (primeInt == 410){
                Char1name.text = "";
                Char1speech.text = "";
				        Char2name.text = "Matilda";
                Char2speech.text ="I could translate for you but first you have to tell me a bit more about yourself. Like, what’s Ginipera is like?";
				Choice2a.SetActive(true);
				Choice2b.SetActive(true);
	 }

	 else if (primeInt == 500){
				        Char1name.text = "YOU";
                Char1speech.text =" Well, Guinpera, in simple terms, is a rather vast planet, much larger than this one.Our civilization relies on organic resources to survive much like yours, but while your planet has an abundance of such materials, the environment on my planet is much less suited for such growth. We barely survive by using our technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable. We need other resources outside of our planet. And your planet has been chosen as the target.";
     }
	 else if (primeInt == 501){
				Char2name.text = "Matilda";
                Char2speech.text ="Ohh. I see. So .. why are you here? Why do you .. want to warn us?";
     }
	 else if (primeInt == 502){
				Char1name.text = "YOU";
                Char1speech.text =" I’ve always been fascinated with you humans.Your culture is so rich and diverse. I just .. want to preserve that. I also believe that it is much more prudent to cooperate than try to dominate and take from other societies. ";
     }
	 else if (primeInt == 503){
				Char2name.text = "Matilda";
                Char2speech.text =" Hmmm, I think it’s also good to have peace rather than fight for things too!Dad has always told me that peace is always the first option we should go for. We should only fight when we absolutely have to and when there are no other choice.";
     }
	 else if (primeInt == 504){
				Char1name.text = "YOU";
                Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them. Unfortunately, some of my people, the loudest and most vocal ones believe that there are no other choice but to take what we need by force. That is why I’m here to prevent that.";
     }
	 else if (primeInt == 505){
				Char2name.text = "Matilda";
                Char2speech.text ="Don’t worry. My dads will take you to work tomorrow.You’ll save the world!";
     }
	 else if (primeInt == 506){
				Char1name.text = "YOU";
                Char1speech.text ="Your parents seem like very capable people. I just hope your government understands how urgent this situation is.";
     }
	 else if (primeInt == 507){
				Char2name.text = "Matilda";
                Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be, they can’t ignore an issue as big as this right?";
     }
	 else if (primeInt == 508){
				Char1name.text = "YOU";
                Char1speech.text ="Like I said, I hope so.";
     }
	 else if (primeInt == 509){
				Char3name.text = "Evan";
                Char3speech.text ="Hey Matilda, I told you to go get your homework down. The doggie is seriously not going to go anywhere I promise. (Matilda looks at A with a questioning glance and A nods)";
     }
	 else if (primeInt == 510){
				Char2name.text = "Matilda";
                Char2speech.text ="Actually, Dad there is something i want to tell you. I can read minds.";
     }
	 else if (primeInt == 511){
				Char3name.text = "Evan";
                Char3speech.text ="Hah very funny. If you think saying something like that will get you out of doing homework then think again.";
     }
	 else if (primeInt == 512){
				Char2name.text = "Matilda";
                Char2speech.text ="Dad, I’m serious. I can read what you’re thinking. Like right now, you’re thinking about how much paperwork you and Dad have to do because of the damage that was caused during the raid on the drug farm you guys raided yesterday in Southwick… And now you’re thinking about how cute Dad looked while he was shoo-";
     }
	 else if (primeInt == 513){
				Char3name.text = "Evan";
                Char3speech.text ="WOAH WOAH, that is more than enough, thank you very much, missy. Jesus, you really weren’t lying. How long have you been able to do that?";
     }
	 else if (primeInt == 514){
				Char2name.text = "Matilda";
                Char2speech.text ="(Shrugs)SInce I could remember.";
     }
	 else if (primeInt == 515){
				Char3name.text = "Evan";
                Char3speech.text ="So you’re telling me that you’ve always been able to read people’s minds? That you’ve always know what I was thinking about? ";
     }
	 else if (primeInt == 516){
				Char2name.text = "Matilda";
                Char2speech.text ="For the most part. It’s not like I’m ALWAYS listening to what your head has to say.";
     }
	 else if (primeInt == 517){
				Char3name.text = "Evan";
                Char3speech.text ="Wow… just wow. I can’t believe I’ve never noticed. My daughter is a freakin’ psychic.";
     }
	 else if (primeInt == 518){
				Char2name.text = "Matilda";
                Char2speech.text ="That’s great and all that you’re freaked out, Dad because you’re about to hear something more freaky. We’re all going to die by this time tomorrow because of a alien invasion.";
     }
	 else if (primeInt == 519){
				Char3name.text = "Evan";
                Char3speech.text ="Wait, wait…what?";
     }
	 else if (primeInt == 520){
				Char2name.text = "Matilda";
                Char2speech.text ="Yeah, by tomorrow, our planet will be turned into a wasteland with every possible resource we have stripped and taken away. Everyone will either die immediately or starve to death.";
     }
	 else if (primeInt == 521){
				Char3name.text = "Evan";
                Char3speech.text ="How is that even possible? How could you even know that such a thing will happen?";
     }
	 else if (primeInt == 522){
				Char2name.text = "Matilda";
                Char2speech.text ="Because of the doggie here, He’s not actually a doggie. He’s a alien from another planet. Say hi, A, (A raise a paw in a clumsy imitation of a wave).";
     }
	 else if (primeInt == 523){
				Char3name.text = "Evan";
                Char3speech.text ="Wait, the dog? What is even going on right now? Matilda. I’m gonna need you to explain everything.";
				NextScene1Button.SetActive(true);
	 }

//CHOICE 2
	 else if (primeInt == 600){
				Char1name.text = "YOU";
                Char1speech.text = "I don't think someone of your age would be able to comprehend it.";
	 }
	  else if (primeInt == 601){
				Char2name.text = "Matilda";
                Char2speech.text = "Ha! Try me, space doggy. I know more than you think.";
	  }
	   else if (primeInt == 602){
				Char1name.text = "YOU";
                Char1speech.text = "Hmm, I guess so. You could always just pull the information from my head, can’t you?";
	  }
	   else if (primeInt == 603){
				Char2name.text = "Matilda";
                Char2speech.text = "Exactly. It doesn't really work that way, but close enough ";
	  }
	 else if (primeInt == 604){
				Char1name.text = "YOU";
                Char1speech.text ="Well, Guinpera, in simple terms, is a rather vast planet, much larger than this one.Our civilization relies on organic resources to survive much like yours, but while your planet has an abundance of such materials, the environment on my planet is much less suited for such growth. We barely survive by using our technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable. We need other resources outside of our planet. And your planet has been chosen as the target.";
     }
	 else if (primeInt == 605){
				Char2name.text = "Matilda";
                Char2speech.text ="Ohh. I see. So .. why are you here? Why do you .. want to warn us?";
     }
	 else if (primeInt == 606){
				Char1name.text = "YOU";
                Char1speech.text =" I’ve always been fascinated with you humans.Your culture is so rich and diverse. I just .. want to preserve that. I also believe that it is much more prudent to cooperate than try to dominate and take from other societies. ";
     }
	 else if (primeInt == 607){
				Char2name.text = "Matilda";
                Char2speech.text =" Hmmm, I think it’s also good to have peace rather than fight for things too!Dad has always told me that peace is always the first option we should go for. We should only fight when we absolutely have to and when there are no other choice.";
     }
	 else if (primeInt == 608){
				Char1name.text = "YOU";
                Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them. Unfortunately, some of my people, the loudest and most vocal ones believe that there are no other choice but to take what we need by force. That is why I’m here to prevent that.";
     }
	 else if (primeInt == 609){
				Char2name.text = "Matilda";
                Char2speech.text ="Don’t worry. My dads will take you to work tomorrow.You’ll save the world!";
     }
	 else if (primeInt == 610){
				Char1name.text = "YOU";
                Char1speech.text ="Your parents seem like very capable people. I just hope your government understands how urgent this situation is.";
     }
	 else if (primeInt == 611){
				Char2name.text = "Matilda";
                Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be, they can’t ignore an issue as big as this right?";
     }
	 else if (primeInt == 612){
				Char1name.text = "YOU";
                Char1speech.text ="Like I said, I hope so.";
	 }
	else if (primeInt == 613){
				Char3name.text = "Evan";
                Char3speech.text ="Hey Matilda, I told you to go get your homework down. The doggie is seriously not going to go anywhere I promise. (Matilda looks at A with a questioning glance and A nods)";
     }
	 else if (primeInt == 614){
				Char2name.text = "Matilda";
                Char2speech.text ="Actually, Dad there is something i want to tell you. I can read minds.";
     }
	 else if (primeInt == 615){
				Char3name.text = "Evan";
                Char3speech.text ="Hah very funny. If you think saying something like that will get you out of doing homework then think again.";
     }
	 else if (primeInt == 616){
				Char2name.text = "Matilda";
                Char2speech.text ="Dad, I’m serious. I can read what you’re thinking. Like right now, you’re thinking about how much paperwork you and Dad have to do because of the damage that was caused during the raid on the drug farm you guys raided yesterday in Southwick… And now you’re thinking about how cute Dad looked while he was shoo-";
     }
	 else if (primeInt == 617){
				Char3name.text = "Evan";
                Char3speech.text ="WOAH WOAH, that is more than enough, thank you very much, missy. Jesus, you really weren’t lying. How long have you been able to do that?";
     }
	 else if (primeInt == 618){
				Char2name.text = "Matilda";
                Char2speech.text ="(Shrugs)SInce I could remember.";
     }
	 else if (primeInt == 619){
				Char3name.text = "Evan";
                Char3speech.text ="So you’re telling me that you’ve always been able to read people’s minds? That you’ve always know what I was thinking about? ";
     }
	 else if (primeInt == 620){
				Char2name.text = "Matilda";
                Char2speech.text ="For the most part. It’s not like I’m ALWAYS listening to what your head has to say.";
     }
	 else if (primeInt == 621){
				Char3name.text = "Evan";
                Char3speech.text ="Wow… just wow. I can’t believe I’ve never noticed. My daughter is a freakin’ psychic.";
     }
	 else if (primeInt == 622){
				Char2name.text = "Matilda";
                Char2speech.text ="That’s great and all that you’re freaked out, Dad because you’re about to hear something more freaky. We’re all going to die by this time tomorrow because of a alien invasion.";
     }
	 else if (primeInt == 623){
				Char3name.text = "Evan";
                Char3speech.text ="Wait, wait…what?";
     }
	 else if (primeInt == 624){
				Char2name.text = "Matilda";
                Char2speech.text ="Yeah, by tomorrow, our planet will be turned into a wasteland with every possible resource we have stripped and taken away. Everyone will either die immediately or starve to death.";
     }
	 else if (primeInt == 625){
				Char3name.text = "Evan";
                Char3speech.text ="How is that even possible? How could you even know that such a thing will happen?";
     }
	 else if (primeInt == 626){
				Char2name.text = "Matilda";
                Char2speech.text ="Because of the doggie here, He’s not actually a doggie. He’s a alien from another planet. Say hi, A, (A raise a paw in a clumsy imitation of a wave).";
     }
	 else if (primeInt == 627){
				Char3name.text = "Evan";
                Char3speech.text ="Wait, the dog? What is even going on right now? Matilda. I’m gonna need you to explain everything.";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 599;
                Choice2a.SetActive(false);
				Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
