using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
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
        public GameObject ArtChar1;
       //public GameObject ArtChar1b;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

// initial visibility settings. Any new images or buttons need to also be SetActive(false);
void Start(){  
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
                Char2name.text = "Matilda";
                Char2speech.text = "Hey, Dad!";
        }
       else if (primeInt ==3){
                Char3name.text = "Evan";
                Char3speech.text = "Hey, honey how was school?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char2name.text = "Matilda";
                Char2speech.text = "School was fine, but you will not believe what I saw when I coming home.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char4nameame.text = "Chris";
                Char4speech.text = "Yeah? What did you see, Mat?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char2name.text = "Matilda";
                Char2speech.text = "I saw a star fall down from the sky. Isn't that wierd? Stars aren't supposed to be out in the middle of the day.";
        }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "(Oh boy. I totally forgot about the wreckage of my ship. This could be complicated.";
        }
       else if (primeInt == 8){
                Char3name.text = "Evan";
                Char3speech.text = "Wow, I wonder what that coudld've been. Well, don't worry honey. I'm sure it's nothing.";
	   }
		else if (primeInt == 9){
                Char2name.text = "Matilda";
                Char2speech.text = "Oh hey doggy! When did we get a dog?";
	   }
		else if (primeInt == 10){
                Char4name.text = "Chris";
                Char4speech.text = "Oh Daddy and I found this little fella outside our door earlier. Wanna say hi?";
	   }
	   else if (primeInt == 11){
                Char2name.text = "Matilda";
                Char2speech.text = "(pets A's head) Wow, your fur is so pretty.";
	   }
		else if (primeInt == 12){
                Char4name.text = "Chris";
                Char4speech.text = "Don't you have homework to do, Matilda? You can play with the doggie after you're done with that.";
	   }
		else if (primeInt == 13){
                Char2name.text = "Matilda";
                Char2speech.text = "Awww, but I want to play with the new doggie now.";
	   }
		else if (primeInt == 14){
                Char3name.text = "Evan";
                Char3speech.text = "There’ll be plenty of time to play AFTER you’re done. Don’t worry, the doggie isn’t going anywhere.";
	   }
		else if (primeInt == 15){
                Char2name.text = "Matilda";
                Char2speech.text = "Hmph. Fine, I guess.";
	   }
		else if (primeInt == 16){
                Char4name.text = "Chris";
                Char4speech.text = "That’s the spirit. I ‘m gonna help Daddy finish up dinner now. (winks at A) You behave now. Don’t get into trouble.";
	   }
		else if (primeInt == 17){
                Char1name.text = "";
                Char1speech.text = "(Evan and Chris retreat into the kitchen. Matilda however does not go upstairs but instead stays).";
				
			if (GameHandler.hasComm == true){primeInt = 99;}
    else if (GameHandler.hasProof == true){primeInt = 299;}
	
		}


// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char2name.text = "Matilda";
                Char2speech.text = "What should we do doggy? You like playing catch?";
	   }          
        else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text ="I most certainly do not. I don’t think it’s appropriate for someone of my intellectual standing to be involved in such boorish activities. You should also most definitely not be disobeying your parental figues.";
     }
	  else if (primeInt == 102){
                Char2name.text = "Matilda";
                Char2speech.text ="Ohhh a talking doggie? I don’t see that every day. Are there a lot of talking dogs on Guinpera?";
     } 
	 else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text ="How do you know that? Have humans discovered my planet already? I didn’t think you humans have advanced your technological expertise that far yet.";
     } 
	 else if (primeInt == 104){
                Char2name.text = "Matilda";
                Char2speech.text ="I don’t know what this “tec-oh-ology” thing is. I just heard it from you.";
     } 
	 else if (primeInt == 105){
                Char1name.text = "YOU";
                Char1speech.text ="But I haven’t said anything about my home planet. How could you know?";
     } 
	 else if (primeInt == 106){
                Char2name.text = "Matilda";
                Char2speech.text ="I didn’t hear your mouth saying it. (She points to A’s head). I heard it from your head.";
     } 
	 else if (primeInt == 107){
                Char1name.text = "YOU";
                Char1speech.text ="A psychic? I’ve never heard of a human psychic. Your species shouldn’t have developed enough to possess that ability.";
     } 
	 else if (primeInt == 108){
                Char2name.text = "Matilda";
                Char2speech.text ="People’s heads have always talked to me. Their head voices are quieter, but I can hear them. No one else seems to be able to. (M pauses for a second) Your friends are coming too? But they’re not coming to visit right? They’re coming… to fight?";
     }
	 else if (primeInt == 109){
				Char1name.text = "YOU";
                Char1speech.text =" It’s a complicated situation but I’ve talked with your parental figures. They understand the situation.";
     }
	 	 else if (primeInt == 110){
				Char2name.text = "Matilda";
                Char2speech.text ="Well that’s good. Both of my dads are the smartest people I know. So what do you do on Guinpera? It doesn’t sound like a fun place.";
				Choice1a.SetActive(true);
				Choice1b.SetActive(true);
	 }
	 
	 	 else if (primeInt == 200){
				Char1name.text = "YOU";
                Char1speech.text =" Well, Guinpera, in simple terms, is a rather vast planet, much larger than this one.Our civilization relies on organic resources to survive much like yours, but while your planet has an abundance of such materials, the environment on my planet is much less suited for such growth. We barely survive by using our technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable. We need other resources outside of our planet. And your planet has been chosen as the target.";
     }
	 else if (primeInt == 201){
				Char2name.text = "Matilda";
                Char2speech.text ="Ohh. I see. So .. why are you here? Why do you .. want to warn us?";
     }
	 else if (primeInt == 202){
				Char1name.text = "YOU";
                Char1speech.text =" I’ve always been fascinated with you humans.Your culture is so rich and diverse. I just .. want to preserve that. I also believe that it is much more prudent to cooperate than try to dominate and take from other societies. ";
     }
	 else if (primeInt == 203){
				Char2name.text = "Matilda";
                Char2speech.text =" Hmmm, I think it’s also good to have peace rather than fight for things too!Dad has always told me that peace is always the first option we should go for. We should only fight when we absolutely have to and when there are no other choice.";
     }
	 else if (primeInt == 204){
				Char1name.text = "YOU";
                Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them. Unfortunately, some of my people, the loudest and most vocal ones believe that there are no other choice but to take what we need by force. That is why I’m here to prevent that.";
     }
	 else if (primeInt == 205){
				Char2name.text = "Matilda";
                Char2speech.text ="Don’t worry. My dads will take you to work tomorrow.You’ll save the world!";
     }
	 else if (primeInt == 206){
				Char1name.text = "YOU";
                Char1speech.text ="Your parents seem like very capable people. I just hope your government understands how urgent this situation is.";
     }
	 else if (primeInt == 207){
				Char2name.text = "Matilda";
                Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be, they can’t ignore an issue as big as this right?";
     }
	 else if (primeInt == 208){
				Char1name.text = "YOU";
                Char1speech.text ="Like I said, I hope so.";
     }
	 else if (primeInt == 209){
				Char3name.text = "Evan";
                Char3speech.text ="Hey, I got good news. The President agrees-( Evan stops himself as he catches sight of Matilda still in the room). Matilda. I thought I told you to go to your room. ";
     }
	 else if (primeInt == 210){
				Char2name.text = "Matilda";
                Char2speech.text ="(shrugs) Well the doggie started talking and I thought that was more interesting than doing some boring old math problems. ";
	 }
	 else if (primeInt == 211){
				Char3name.text = "Evan";
                Char3speech.text = "(at A) You spoke in front of Matilda?!";
	 }
	 else if (primeInt == 212){
				Char1name.text = "YOU";
                Char1speech.text ="I was not aware that it was supposed to be a secret that I could talk. I assumed that if you were seemingly unfazed by my oherworldly origins, your child would be as well. ";
	 }
	 else if (primeInt == 213){
				Char3name.text = "Evan";
                Char3speech.text ="Tha-That’s not how that works. Whatever, it ‘s okay . Everything’s fine. It’s fine.(turns to Matilda) So now you know Matilda.";
	 }
		else if (primeInt == 214){
				Char2name.text = "Matilda";
                Char2speech.text ="Yep. And I want to help.";
	 } 
	 else if (primeInt == 215){
				Char3name.text = "Evan";
                Char3speech.text ="Of course you do. Well, as I was saying, the President has agreed to this meeting. He said he would like to meet A as soon as possible. So we need to leave. Now. ";
	 } 
	 else if (primeInt == 216){
				Char1name.text = "YOU";
                Char1speech.text =" Where are we going exactly?";
	 } 
	 else if (primeInt == 217){
				Char3name.text = "Evan";
                Char3speech.text =" To the nearest government  military encampment, Fort MacHeath. The President is flying down as we speak. ";
	 } 
	 else if (primeInt == 218){
				Char1name.text = "YOU";
                Char1speech.text ="Huh. I assumed it would’ve been more of a hassle to convince your government to agree to a meeting. ";
	 } 
	 else if (primeInt == 219){
				Char3name.text = "Evan";
                Char3speech.text ="So did I. The Preseident must know something, otherwise I can’t see him agreeing to  a meeting with a foreign being so quickly. Anyway that’s enough talking, we need to head for Fort MacHeath. It’ll be about a three hour drive. ";
	 } 
	 else if (primeInt == 220){
				Char2name.text = "Matilda";
                Char2speech.text ="Ohhh, can I come?";
	 } 
	 else if (primeInt == 213){
				Char3name.text = "Evan";
                Char3speech.text ="(sighs) Well it's not like there's a different option. We can't exactly leave a ten-year-old alone at home without supervision.";
	 } 
	 else if (primeInt == 213){
				Char2name.text = "Matilda";
                Char2speech.text ="Yay! Off to save the world! This beats math homework by leagues!";
				NextScene1Button.setActive(true);
	 }
	 
	//SCENE 9 CHOICE 2:
	// ENCOUNTER AFTER CHOICE #1
       
	 else if (primeInt == 300){
				Char1name.text = "YOU";
                Char1speech.text = "I don't think someone of your age would be able to comprehend it.";
	 }
	  else if (primeInt == 200){
				Char2name.text = "Matilda";
                Char2speech.text = "Ha! Try me, space doggy. I know more than you think.";
	  }
	   else if (primeInt == 200){
				Char1name.text = "YOU";
                Char1speech.text = "Hmm, I guess so. You could always just pull the information from my head, can’t you?";
	  }
	   else if (primeInt == 200){
				Char2name.text = "Matilda";
                Char2speech.text = "Exactly. It doesn't really work that way, but close enough ";
	  }
	 
	 else if (primeInt == 200){
				Char1name.text = "YOU";
                Char1speech.text =" Well, Guinpera, in simple terms, is a rather vast planet, much larger than this one.Our civilization relies on organic resources to survive much like yours, but while your planet has an abundance of such materials, the environment on my planet is much less suited for such growth. We barely survive by using our technology to replicate poor copies of the little organisms that we have but now that has become too unsustainable. We need other resources outside of our planet. And your planet has been chosen as the target.";
     }
	 else if (primeInt == 201){
				Char2name.text = "Matilda";
                Char2speech.text ="Ohh. I see. So .. why are you here? Why do you .. want to warn us?";
     }
	 else if (primeInt == 202){
				Char1name.text = "YOU";
                Char1speech.text =" I’ve always been fascinated with you humans.Your culture is so rich and diverse. I just .. want to preserve that. I also believe that it is much more prudent to cooperate than try to dominate and take from other societies. ";
     }
	 else if (primeInt == 203){
				Char2name.text = "Matilda";
                Char2speech.text =" Hmmm, I think it’s also good to have peace rather than fight for things too!Dad has always told me that peace is always the first option we should go for. We should only fight when we absolutely have to and when there are no other choice.";
     }
	 else if (primeInt == 204){
				Char1name.text = "YOU";
                Char1speech.text ="Your parental figures are very wise. I agree wholeheartedly with them. Unfortunately, some of my people, the loudest and most vocal ones believe that there are no other choice but to take what we need by force. That is why I’m here to prevent that.";
     }
	 else if (primeInt == 205){
				Char2name.text = "Matilda";
                Char2speech.text ="Don’t worry. My dads will take you to work tomorrow.You’ll save the world!";
     }
	 else if (primeInt == 206){
				Char1name.text = "YOU";
                Char1speech.text ="Your parents seem like very capable people. I just hope your government understands how urgent this situation is.";
     }
	 else if (primeInt == 207){
				Char2name.text = "Matilda";
                Char2speech.text ="We’ll make them understand. No matter how thick-headed they can be, they can’t ignore an issue as big as this right?";
     }
	 else if (primeInt == 208){
				Char1name.text = "YOU";
                Char1speech.text ="Like I said, I hope so.";
     }
	 else if (primeInt == 209){
				Char3name.text = "Evan";
                Char3speech.text ="Hey, I got good news. The President agrees-( Evan stops himself as he catches sight of Matilda still in the room). Matilda. I thought I told you to go to your room. ";
     }
	 else if (primeInt == 210){
				Char2name.text = "Matilda";
                Char2speech.text ="(shrugs) Well the doggie started talking and I thought that was more interesting than doing some boring old math problems. ";
	 }
	 else if (primeInt == 211){
				Char3name.text = "Evan";
                Char3speech.text = "(at A) You spoke in front of Matilda?!";
	 }
	 else if (primeInt == 212){
				Char1name.text = "YOU";
                Char1speech.text ="I was not aware that it was supposed to be a secret that I could talk. I assumed that if you were seemingly unfazed by my oherworldly origins, your child would be as well. ";
	 }
	 else if (primeInt == 213){
				Char3name.text = "Evan";
                Char3speech.text ="Tha-That’s not how that works. Whatever, it ‘s okay . Everything’s fine. It’s fine.(turns to Matilda) So now you know Matilda.";
	 }
		else if (primeInt == 214){
				Char2name.text = "Matilda";
                Char2speech.text ="Yep. And I want to help.";
	 } 
	 else if (primeInt == 215){
				Char3name.text = "Evan";
                Char3speech.text ="Of course you do. Well, as I was saying, the President has agreed to this meeting. He said he would like to meet A as soon as possible. So we need to leave. Now. ";
	 } 
	 else if (primeInt == 216){
				Char1name.text = "YOU";
                Char1speech.text =" Where are we going exactly?";
	 } 
	 else if (primeInt == 217){
				Char3name.text = "Evan";
                Char3speech.text =" To the nearest government  military encampment, Fort MacHeath. The President is flying down as we speak. ";
	 } 
	 else if (primeInt == 218){
				Char1name.text = "YOU";
                Char1speech.text ="Huh. I assumed it would’ve been more of a hassle to convince your government to agree to a meeting. ";
	 } 
	 else if (primeInt == 219){
				Char3name.text = "Evan";
                Char3speech.text ="So did I. The Preseident must know something, otherwise I can’t see him agreeing to  a meeting with a foreign being so quickly. Anyway that’s enough talking, we need to head for Fort MacHeath. It’ll be about a three hour drive. ";
	 } 
	 else if (primeInt == 220){
				Char2name.text = "Matilda";
                Char2speech.text ="Ohhh, can I come?";
	 } 
	 else if (primeInt == 213){
				Char3name.text = "Evan";
                Char3speech.text ="(sighs) Well it's not like there's a different option. We can't exactly leave a ten-year-old alone at home without supervision.";
	 } 
	 else if (primeInt == 213){
				Char2name.text = "Matilda";
                Char2speech.text ="Yay! Off to save the world! This beats math homework by leagues!";
				NextScene1Button.setActive(true);
	 }
	 
	 
	 

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch-scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
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