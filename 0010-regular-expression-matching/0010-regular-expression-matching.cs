public class Solution {
    public bool IsMatch(string s, string p) {
        return IsMatchHelper(s, p, s.Length -1, p.Length -1);
    }

    private bool IsMatchHelper(string s, string p, int sLen, int pLen){
        //If the string is empty the pattern must be only *
        if(sLen < 0){
            while(pLen >= 0 && p[pLen] == '*'){
                if(p[pLen -1] == '*'){
                    pLen --;
                } else {
                    pLen -= 2;
                }
            }

            return pLen < 0;
        }

        //If the pattern is empty it is automatically false
        if(pLen < 0){
            return false;
        }

        //Checks if the current last letter of the string is equal to the pattern or if it is a ., if so goes on to check the rest
        if(s[sLen] == p[pLen] || p[pLen] == '.'){
            return IsMatchHelper(s, p, sLen -1, pLen -1);
        }

        //On this point if the current pattern is not a * then it is a automatically false
        if(p[pLen] != '*'){
            return false;
        }

        //Similar to the begining, goes checking from the end to the start all the * on the pattern
        while(pLen >= 0 && p[pLen] == '*'){
            pLen--;
        }

        //After removing all the * from the end there is no more pattern then it is false
        if(pLen < 0){
            return false;
        }

        //since the last pattern was a *, goes checking if the last characters from the string are a match, if it is false because the match is wrong it will get out of the while
        while(sLen >= 0 && (s[sLen] == p[pLen] || p[pLen] == '.')){
            if(IsMatchHelper(s, p, sLen, pLen-1)){
                return true;
            }

            sLen --;
        }

        //if the pattern was equal on the last character bur not the next, than recall it self to start all again with the rest of the pattern and string
        return IsMatchHelper(s, p, sLen, pLen -1);
    }
}