using System;
using System.Collections.Generic;
using System.Text;

namespace skinsurance
{
    public static class CompareProducts
    {

        public static string[] problemChildren = { "retinol", "salicylic acid", "glycolic acid", "citric acid",
                                                   "mandelic acid", "malic acid", "tartaric acid", "lactic acid", "benzoyl peroxide",
                                                   "ascorbic acid", "niacinamide"};

        private static bool _harmfulConflict = false;

        private static bool _lessEffective = false;




        public static string[] FindMatches(string[] ingredients)
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



        public static void CompareIngredients(string[] ingredientsOne, string[] ingredientsTwo)
        {
            _harmfulConflict = false;
            _lessEffective = false; 

            string[] problemOne = FindMatches(ingredientsOne);
            string[] problemTwo = FindMatches(ingredientsTwo);

            HarmfulConflict(problemOne, problemTwo);
            LessEffective(problemOne, problemTwo);

        }





        //JUST comparing harmful interactions
        public static void HarmfulConflict(string[] problemOne, string[] problemTwo)
        {
            for (int i = 0; i < problemOne.Length; i++)
            {
                for (int j = 0; j < problemTwo.Length; j++)
                {
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "retinol" || problemTwo[j] == "retinol"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "salicylic acid" || problemTwo[j] == "salicylic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "glycolic acid" || problemTwo[j] == "glycolic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "citric acid" || problemTwo[j] == "citric acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "mandelic acid" || problemTwo[j] == "mandelic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "malic acid" || problemTwo[j] == "malic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "tartaric acid" || problemTwo[j] == "tartaric acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "lactic acid" || problemTwo[j] == "lactic acid"))
                    {
                        _harmfulConflict = true;
                        break;
                    }
                    if ((problemOne[i] == "retinol" || problemTwo[j] == "retinol") && (problemOne[i] == "benzoyl peroxide" || problemTwo[j] == "benzoyl peroxide"))
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
        public static void LessEffective(string[] problemOne, string[] problemTwo)
        {
            for (int i = 0; i < problemOne.Length; i++)
            {
                for (int j = 0; j < problemTwo.Length; j++)
                {
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "salicylic acid" || problemTwo[j] == "salicylic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "glycolic acid" || problemTwo[j] == "glycolic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "citric acid" || problemTwo[j] == "citric acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "mandelic acid" || problemTwo[j] == "mandelic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "malic acid" || problemTwo[j] == "malic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "tartaric acid" || problemTwo[j] == "tartaric acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "lactic acid" || problemTwo[j] == "lactic acid"))
                    {
                        _lessEffective = true;
                        break;
                    }
                    if ((problemOne[i] == "ascorbic acid" || problemTwo[j] == "ascorbic acid") && (problemOne[i] == "niacinamide" || problemTwo[j] == "niacinamide"))
                    {
                        _lessEffective = true;
                        break;
                    }


                }
            }
        }



        public static bool AllGood(out bool harmfulConflict, out bool lessEffective)
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