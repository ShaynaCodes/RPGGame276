using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
   
    public GameObject[] options;
    public int currentQuestion;
    public PlayerMovement playerMovement;
    public Text QuesitonTxt;

    public GameObject Quizpanel;
    public GameObject GoPanel;

    public Text QuestionTxt;
    public Text EndTxt;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
     //   if(playerMovement.playerPosition == 1)
     //   { 
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
       // }
    }

    public void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        //Endings for the game
        if(score <= 3)
        {
            EndTxt.text = "You Dont figure out how you died......";
        }
        if (score > 3 && score < 7)
        {
            EndTxt.text = "You died by the well. You dont know who murdered you";
        }
        if (score > 7)
        {
            EndTxt.text = "You remember your sister murdered you by the well.";
        }
        

    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        //incorrect
        //score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for(int i = 0; i<options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            //Debug.Log("wrong");

         if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                 score += 1;
               // Debug.Log("correct");
                options[i].GetComponent<AnswerScript>().isCorrect = true;
                Debug.Log(options[i].GetComponent<AnswerScript>().isCorrect);
                Debug.Log(score);
            }

        }


        /*for (int i =0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }*/
    }
    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuesitonTxt.text = QnA[currentQuestion].Question;
            
            SetAnswers();

        }
        else
        {
            Debug.Log("Out Of Questions");
            GameOver();
        }
      
       // QnA.RemoveAt(currentQuestion);
    }
}
