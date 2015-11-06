using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;

namespace Knot_Tying.Models
{
    public class CompetitionViewModel
    {
        public COMPETITIONEntities db = new COMPETITIONEntities(); //setting the variable db as the competitionentities database

        //this is the save method to save the entry into the database
        public void SaveEntry() // THINKING ABOUT THIS AS A PRACTISE ISSUE
        {
            CompetitionEntry.CMQ_ID = CompetitionQuestion.CMQ_ID; //competition entry table will have the competition question id from the competition question table
            CompetitionEntry.COMP_ID = COMP_ID; //competition entry table will have the comp id
            CompetitionEntry.GIVEN_ANSWER_ID = SelectedAnswer; //enters the selected answer into the given answer field into the competition entry table
            db.CompetitionEntries.Add(CompetitionEntry); //adds the entry intot he database
            db.SaveChanges(); //saves the entries
            AnsStr = getAnswer(SelectedAnswer); //variable AnsStr is getAnswer
        }

        //this returns the answer onto the thankyou form 
        public String getAnswer(int answerID)
        {
            AnsStr = "";
            foreach (var answer in Answers)
            {
                if (answer.ID == answerID)
                {
                    AnsStr = answer.Answer_Text;
                }
            }
            return AnsStr;
        }

        public List<String> GetSuggestion(  String pStrSuggestion)
        {
            List<String> result = new List<String>();
            var suggestedNames = db.GetSuggestion(pStrSuggestion);
            foreach (var a in suggestedNames)
            {
                result.Add(a);
            }
            return result;
        }

        public CompetitionViewModel()
        {
            var result = db.GetQuestion().First(); //this gets the first question out of the database
            CompetitionQuestion = new CompetitionQuestion(); //this makes it a new competition question
            CompetitionQuestion.CMQ_ID = result.CMQ_ID; //this matches the competition question id with result id
            CompetitionQuestion.QUESTION = result.QUESTION;
            COMP_ID = result.COMP_ID;
            var resultAnswers = db.GetAnswers(result.CMQ_ID).ToList(); //displays the answers as a list

            // Answers, sorts out what answer is correct
            Answers = new List<ANSWER>();
            foreach (GetAnswers_Result a in resultAnswers)
            {
                ANSWER Ans = new ANSWER();
                Ans.CMQ_ID = result.CMQ_ID;
                Ans.Answer_Text = a.Answer_Text;
                Ans.IS_CORRECT = a.IS_CORRECT;
                Ans.ID = a.ID;           
                Answers.Add(Ans);
            }
        }

        //this get and sets each variable
        public ANSWER Answer { get; set; }
        public Competition Competition { get; set;  }
        public CompetitionQuestion CompetitionQuestion { get; set; }
        public CompetitionEntry CompetitionEntry { get; set; }
        public School School { get; set; }

        public Int32 SelectedAnswer { get; set; }
        public String AnsStr { get; set; }
        public Int32 COMP_ID { get; set; }
        public virtual List<ANSWER> Answers { get; set; }

    }
}