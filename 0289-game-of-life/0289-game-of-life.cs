public class Solution {
    public void GameOfLife(int[][] board) {
        int sizeA = board.Length;
        int sizeB = board[0].Length;
        int[][] oldBoard = board.Select(a => a.ToArray()).ToArray();

        for(int a = 0; a < sizeA; a++){
            for(int b = 0; b < sizeB; b ++){
                int na = 0;

                if(isNotFirst(a)){
                    //check line above
                    if(isNotFirst(b)){
                        //left
                        na += oldBoard[a-1][b-1];
                    }
                    //direct above
                    na += oldBoard[a-1][b];
                    if(isNotLast(b, sizeB)){
                        //right
                        na += oldBoard[a-1][b+1];
                    }
                }
                //on the same line
                if(isNotFirst(b)){
                    //left
                    na += oldBoard[a][b-1];
                }
                if(isNotLast(b, sizeB)){
                    //right
                    na += oldBoard[a][b+1];
                }
                if(isNotLast(a, sizeA)){
                    //check line bellow
                    if(isNotFirst(b)){
                        //left
                        na += oldBoard[a+1][b-1];
                    }
                    //direct bellow
                    na += oldBoard[a+1][b];
                    if(isNotLast(b, sizeB)){
                        //right
                        na += oldBoard[a+1][b+1];
                    }
                }

                if(oldBoard[a][b] == 1){
                    //its alive
                    if(na < 2 || na > 3){
                        board[a][b] = 0;
                    }
                } else {
                    //is dead
                    if(na == 3){
                        board[a][b] = 1;
                    }
                }
            }
        }
    }

    public bool isNotFirst(int val){
        if(val > 0)
            return true;
        return false;
    }

    public bool isNotLast(int val, int size){
        if(val+1 < size)
            return true;
        return false;
    }
}