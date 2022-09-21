using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathProblem : MonoBehaviour
{
    // Start is called before the first frame update
   
        public Text firstNumber;
        public Text secondNumber;

        public Text answer1;
        public Text answer2;
        public Text answer3;
        public Text answer4;
    
    public List<int> easyMathList = new List<int>();

    public int randomFirstNumber;
    public int randomSecondNumber;

    int firstNumberInProblem;
    int secondNumberInProblem;
    int answerOne;
    int answerTwo;
    int answerThree;
    int answerFour;
    int displayRandomAnswer;
    int randomAnswerPlacement;
    public int currentAnswer;
    public Text rightOrWrong_Text;
    public int count=10; //اذا طلعت 10 اسئلة يوقف
     

    private void Start() {
            DisplayMathProblem();
    }
    public void DisplayMathProblem(){


        //
        randomFirstNumber = Random.Range(0, easyMathList.Count +1);
        randomSecondNumber = Random.Range(0, easyMathList.Count +1);
        //
        firstNumberInProblem = randomFirstNumber;
        //
        secondNumberInProblem = randomSecondNumber;
        /// 
        /// //////////
        /// 
        answerOne = firstNumberInProblem + secondNumberInProblem;
        displayRandomAnswer = Random.Range(0,2);
        if(displayRandomAnswer==0)
        {
            answerTwo = answerOne + Random.Range(1,3);
            answerThree = answerOne + Random.Range(4,6);
            answerFour = answerOne + Random.Range(7,9);
        }
        else
        {
           
            answerTwo = answerOne - Random.Range(1,3);
           
            answerThree = answerOne - Random.Range(4,6);
           
            answerFour = answerOne - Random.Range(7,9);

            // عشان نشيل الاعداد السالبة من الخيارات
            if(answerTwo <0){
                answerTwo= Mathf.Abs(answerTwo);
                answerTwo = answerOne + Random.Range(1,3);
            }
            if(answerThree <0){
                answerThree= Mathf.Abs(answerThree);
                answerThree = answerOne + Random.Range(4,6);
            }
            if(answerFour <0){
                answerFour= Mathf.Abs(answerFour);
                answerFour = answerOne + Random.Range(7,9);
            }
        }
        firstNumber.text = ""+firstNumberInProblem;
        secondNumber.text = ""+secondNumberInProblem;
        randomAnswerPlacement = Random.Range(0,4);
          if(randomAnswerPlacement==0)
           {
            answer1.text = ""+answerOne;
            answer2.text = ""+answerTwo;
            answer3.text = ""+answerThree;
            answer4.text = ""+answerFour;
            currentAnswer=0;
        }
        else if(randomAnswerPlacement==1){
            answer1.text = ""+answerTwo;
            answer2.text = ""+answerOne;
            answer3.text = ""+answerFour;
            answer4.text = ""+answerThree;
            currentAnswer=1;

        }
        else if(randomAnswerPlacement==2){

            answer1.text = ""+answerThree;
            answer2.text = ""+answerFour;
            answer3.text = ""+answerOne;
            answer4.text = ""+answerTwo;
            currentAnswer=2;
        }
        
        else{
            answer1.text = ""+answerThree;
            answer2.text = ""+answerFour;
            answer3.text = ""+answerTwo;
            answer4.text = ""+answerOne;
            currentAnswer=3;
        }
        /// 
        /// ////////
        /// 

        
    }
    




public void ButtonAnswer1(){
if(currentAnswer == 0){
    rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.green;
    rightOrWrong_Text.text= ("Correct");
    Invoke("TurnOffText", 1);
}
else{
   rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.red;
    rightOrWrong_Text.text= ("Try again!");
    Invoke("TurnOffText",1); 
}
}
public void ButtonAnswer2(){
if(currentAnswer == 1){
    rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.green;
    rightOrWrong_Text.text= ("Correct");
    Invoke("TurnOffText", 1);
}
else{
   rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.red;
    rightOrWrong_Text.text= ("Try again!");
    Invoke("TurnOffText",1); 
}
}
public void ButtonAnswer3(){
if(currentAnswer == 2){
    rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.green;
    rightOrWrong_Text.text= ("Correct");
    Invoke("TurnOffText", 1);
}
else{
   rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.red;
    rightOrWrong_Text.text= ("Try again!");
    Invoke("TurnOffText",1); 
}
}
public void ButtonAnswer4(){
if(currentAnswer == 3){
    rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.green;
    rightOrWrong_Text.text= ("Correct");
    Invoke("TurnOffText", 1);
}
else{
   rightOrWrong_Text.enabled = true;
    rightOrWrong_Text.color = Color.red;
    rightOrWrong_Text.text= ("Try again!");
    Invoke("TurnOffText",1); 
}
}

public void TurnOffText(){
if(rightOrWrong_Text != null){
   rightOrWrong_Text.enabled = false;
}
    count = count-1;
if(count>0)
   DisplayMathProblem();

}


 
}
