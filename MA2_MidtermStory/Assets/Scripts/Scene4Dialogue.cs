using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //MatildaExcited
		    public GameObject ArtChar1b; //MatildaHappy
        public GameObject ArtChar1c; //MatilaLeaningIn
        public GameObject ArtChar1d; //MatildaQuestioning
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
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
        ArtChar1a.SetActive(false);
		    ArtChar1b.SetActive(false);
		    ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
      if (GameHandler.hasComm==true){primeInt=1;}
      if (GameHandler.hasAi==true){}
      if (GameHandler.hasProof==true){}
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(I’m not sure how well a conversation will go with this one, but I’ll try.)";
                Char2name.text = "";
                Char2speech.text = "";
              }
       else if (primeInt ==3){
                Char1name.text = "YOU";
                Char1speech.text = "Hello, underdeveloped female human. I need your help.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
              }
       else if (primeInt == 4){
         ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "Woah, a talking dog?";
              }
       else if (primeInt == 5){
         ArtChar1a.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Small Human";
                Char2speech.text = "Here, doggy doggy!";
                //gameHandler.AddPlayerStat(1);
              }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(She is .. touching my head?)\n(.. Huh. It’s strangely nice.)";
                Char2name.text = "";
				        Char2speech.text = "";
              }
       else if (primeInt ==7){
                Char1name.text = "YOU";
                Char1speech.text = "(This must be a common gesture among humans.)\n(I should cooperate with this underdeveloped specimen.)";
                Char2name.text = "";
                Char2speech.text = "";
              }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "My name’s Matilda, doggy! Do you have a name?";
              }
		   else if (primeInt == 9){
                Char1name.text = "YOU";
                Char1speech.text = "It is a pleasure to meet you human, but time is of the essence and we don’t have the luxury of dawdling.";
                Char2name.text = "";
                Char2speech.text = "";
              }
       else if (primeInt == 10){
                Char1name.text = "YOU";
                Char1speech.text = "Please take me to your leader.";
                Char2name.text = "";
                Char2speech.text = "";
              }

		else if (primeInt == 11){
      ArtChar1c.SetActive(false);
      ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "You want to meet my dads? They’re pretty rad.";
              }
       else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "They work in a big office where they beat bad guys and talk to people in neat suits.\nThey’re the coolest!";
              }
		else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Do you wanna a jelly sandwich, by the way?";
                nextButton.SetActive(false);
                Choice1a.SetActive(true);
                Choice1b.SetActive(true);
              }

     else if (primeInt ==100){
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";

           	  }
     else if (primeInt ==101){
                Char1name.text = "YOU";
                Char1speech.text = "Mm! This is .. actually good, human.";
                Char2name.text = "";
                Char2speech.text = "";

              }
     else if (primeInt ==102){
       ArtChar1b.SetActive(false);
       ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Wow! An alien eating my sandwich.\nAnd liking it, too!";

              }
     else if (primeInt ==103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Sooooo cool!";

              }
     else if (primeInt ==104){
       ArtChar1a.SetActive(false);
       ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Do they not have sandwiches on .. Geeneepeera?";

              }
      else if (primeInt ==105){
                Char1name.text = "YOU";
                Char1speech.text = "How ... do you know that?\nHave humans discovered my planet already?";
                Char2name.text = "";
                Char2speech.text = "";

              }
      else if (primeInt ==106){
                Char1name.text = "YOU";
                Char1speech.text = "I didn’t think you humans have advanced your technological expertise that far yet.";
                Char2name.text = "";
                Char2speech.text = "";

              }
      else if (primeInt ==107){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "I don’t know what this 'tec-oh-ology' thing is. I just heard it from you.";

              }
      else if (primeInt ==108){
                Char1name.text = "YOU";
                Char1speech.text = "But I haven’t said anything about my home planet. How could you know?";
                Char2name.text = "";
                Char2speech.text = "";

              }
      else if (primeInt ==109){
        ArtChar1d.SetActive(false);
        ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "People’s heads have always talked to me.\nTheir head voices are quieter, but I can hear them.";

              }
      else if (primeInt ==110){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "No one else seems to be able to.";

              }
      else if (primeInt ==111){
        ArtChar1b.SetActive(false);
        ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Your friends are coming too?\nBut they’re not coming to visit right? They’re coming .. to fight?";

              }
      else if (primeInt ==112){
                Char1name.text = "YOU";
                Char1speech.text = "Yes, this planet is in danger.\nI need to talk to the person in charge of this planet.";
                Char2name.text = "";
                Char2speech.text = "";
              }
      else if (primeInt ==113){
        ArtChar1d.SetActive(false);
        ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Haha, off to go see Dad and Dad then!";
                nextButton.SetActive(false);
                NextScene1Button.SetActive(true);
              }
      else if (primeInt ==200){
                Char1name.text = "YOU";
                Char1speech.text = "Is it ... a weapon capable of disintegrating the cosmic fabric of this universe?!";
                Char2name.text = "";
                Char2speech.text = "";

              }
      else if (primeInt ==201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "No, you nincompoop. It’s a sandwich. You eat it like this.";

              }
      else if (primeInt ==202){
        ArtChar1b.SetActive(false);
        ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Matilda";
                Char2speech.text = "Do they not have sandwiches on .. Geeneepeera?";

              }
      else if (primeInt ==203){
                Char1name.text = "YOU";
                Char1speech.text = "How ... do you know that?\nHave humans discovered my planet already?";
                Char2name.text = "";
                Char2speech.text = "";

              }
      else if (primeInt ==204){
                Char1name.text = "YOU";
                Char1speech.text = "I didn’t think you humans have advanced your technological expertise that far yet.";
                Char2name.text = "";
                Char2speech.text = "";

                       }
               else if (primeInt ==205){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "I don’t know what this 'tec-oh-ology' thing is. I just heard it from you.";

                       }
               else if (primeInt ==206){
                         Char1name.text = "YOU";
                         Char1speech.text = "But I haven’t said anything about my home planet. How could you know?";
                         Char2name.text = "";
                         Char2speech.text = "";

                       }
               else if (primeInt ==207){
                 ArtChar1d.SetActive(false);
                 ArtChar1b.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "People’s heads have always talked to me.\nTheir head voices are quieter, but I can hear them.";

                       }
               else if (primeInt ==208){
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "No one else seems to be able to.";

                       }
               else if (primeInt ==209){
                 ArtChar1b.SetActive(false);
                 ArtChar1d.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "Your friends are coming too?\nBut they’re not coming to visit right? They’re coming .. to fight?";

                       }
               else if (primeInt ==210){
                         Char1name.text = "YOU";
                         Char1speech.text = "Yes, this planet is in danger.\nI need to talk to the person in charge of this planet.";
                         Char2name.text = "";
                         Char2speech.text = "";
                       }
               else if (primeInt ==211){
                 ArtChar1d.SetActive(false);
                 ArtChar1a.SetActive(true);
                         Char1name.text = "";
                         Char1speech.text = "";
                         Char2name.text = "Matilda";
                         Char2speech.text = "Haha, off to go see Dad and Dad then!";
                         nextButton.SetActive(false);
                         NextScene1Button.SetActive(true);
                       }
}



        public void Choice1aFunct(){
          primeInt=99;
          Char1name.text = "YOU";
          Char1speech.text = "(I can’t help but be curious.)\n(I suppose this will help me bond with this human better, too.)";
          Char2name.text = "";
          Char2speech.text = "";
          nextButton.SetActive(true);
          Choice1a.SetActive(false);
          Choice1b.SetActive(false);
        }
        public void Choice1bFunct(){
          primeInt=199;
          Char1name.text = "YOU";
          Char1speech.text = "Your reply is astonishingly unhelpful.\nWhat is this 'sandwich' you are brandishing at me?";
          Char2name.text = "";
          Char2speech.text = "";
          nextButton.SetActive(true);
          Choice1a.SetActive(false);
          Choice1b.SetActive(false);
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6");
          GameHandler.metMatilda=true;
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
}
