using System;
using System.Collections.Generic;

namespace Unit_Tests
{
    public class Words
    {
        public List<string> WordList = new List<string>();

        public string ConCatenator(string word1, string word2){
            if(word1 != null && word2 != null){
                return word1 + word2;
            }
            else{
                throw new ArgumentException("String required, cannot accept null value");
            }
            
        }
        public string WordStretcher(string word1){
            if(word1 != null){
                return word1.ToUpper();
            }
            else{
                throw new ArgumentException("String required, cannot accept null value");
            }
            
        }

        public string WordShrinker(string word1){
            if(word1 != null){
                return word1.ToLower();
            }
            else{
                throw new ArgumentException("String required, cannot accept null value");
            }
            
        }

        public void WordToList(string word1){
            if(word1 is string && word1 != null){
                WordList.Add(word1);
            }
            else{
                throw new ArgumentException("Must be of type string, cannot accept null value");
            }
            
        }

        public int FindWordIndexInList(string word1){
            if(word1 is string && word1 != null){
                return WordList.BinarySearch(word1);
            }
            else{
                throw new ArgumentException("Must be of type string, cannot accept null value");
            }
            
        }

    }
}
