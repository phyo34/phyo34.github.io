using System;
using System.Collections.Generic;
using System.Text;

namespace skinsurance
{
    public class Comparison
    {

        public static string[] problemChildren = { "retinol", "salicylic acid", "retnoid", "glycolic acid", "citric acid",
                                                   "mandelic acid", "malic acid", "tartaric acid", "lactic acid", "benzoyl perioxide",
                                                   "vitamin c", "niacinamide"};

        private bool _harmfulConflict = false;

        private bool _lessEffective = false;




        public string[] FindMatches(string[] ingredients)
        {

            string[] matches = new string[problemChildren.Length];
            for (int i = 0; i < ingredients.Length; i++)
            {
                for (int j = 0; j < problemChildren.Length; j++)
                {
                    if (ingredients[i] == problemChildren[j])
                    {
                        matches[j] = problemChildren[j];
                    }
                }
            }
            return matches;


        }



        public void CompareIngredients(string[] ingredientsOne, string[] ingredientsTwo)
        {
            string[] problemOne = FindMatches(ingredientsOne);
            string[] problemTwo = FindMatches(ingredientsTwo);

            HarmfulConflict(problemOne, problemTwo);
            LessEffective(problemOne, problemTwo);

        }





        //JUST comparing harmful interactions
        public void HarmfulConflict(string[] problemOne, string[] problemTwo)
        {
            for (int i = 0; i < problemOne.Length; i++)
            {
                for (int j = 0; j < problemTwo.Length; j++)
                {
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "retnoid" || problemTwo[j] == "retnoid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "salicylic acid" || problemTwo[j] == "salicylic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "retnoid" || problemTwo[j] == "retnoid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "glycolic acid" || problemTwo[j] == "glycolic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "citric acid" || problemTwo[j] == "citric acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "mandelic acid" || problemTwo[j] == "mandelic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "malic acid" || problemTwo[j] == "malic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "tartaric acid" || problemTwo[j] == "tartaric acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "lactic acid" || problemTwo[j] == "lactic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retnoid" || problemTwo[j] == "retnoid") && (problemOne[i] == "benzoyl perioxide" || problemTwo[j] == "benzoyl perioxide"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "salicylic acid" || problemTwo[j] == "salicylic acid") && (problemOne[i] == "glycolic acid" || problemTwo[j] == "glycolic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }


                }
            }

        }



        //JUST comparing less effective interactions
        public void LessEffective(string[] problemOne, string[] problemTwo)
        {
            for (int i = 0; i < problemOne.Length; i++)
            {
                for (int j = 0; j < problemTwo.Length; j++)
                {
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "salicylic acid" || problemTwo[j] == "salicylic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "retnoid" || problemTwo[j] == "retnoid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "glycolic acid" || problemTwo[j] == "glycolic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "citric acid" || problemTwo[j] == "citric acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "mandelic acid" || problemTwo[j] == "mandelic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "malic acid" || problemTwo[j] == "malic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "tartaric acid" || problemTwo[j] == "tartaric acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "lactic acid" || problemTwo[j] == "lactic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "vitamin c" || problemTwo[j] == "vitamin c") && (problemOne[i] == "niacinamide" || problemTwo[j] == "niacinamide"))
                    {
                        _lessEffective = true;
                        break;
                    }


                }
            }
        }



        public bool AllGood(out bool harmfulConflict, out bool lessEffective)
        {
            harmfulConflict = _harmfulConflict;
            lessEffective = _lessEffective;

            if (harmfulConflict || lessEffective)
            {
                return false;
            }
            return true;
        }




    }
}