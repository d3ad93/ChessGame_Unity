using UnityEngine;
using System.Collections;

public class Horse : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];

        //up left
        HorseMove(CurrentX - 1, CurrentY + 2, ref r);
        //up right
        HorseMove(CurrentX + 1, CurrentY + 2, ref r);
        //right up
        HorseMove(CurrentX + 2, CurrentY + 1, ref r);
        //right down
        HorseMove(CurrentX + 2, CurrentY - 1, ref r);
        //left up
        HorseMove(CurrentX - 2, CurrentY + 1, ref r);
        //left down
        HorseMove(CurrentX - 2, CurrentY - 1, ref r);
        //down left
        HorseMove(CurrentX - 1, CurrentY - 2, ref r);
        //down right
        HorseMove(CurrentX + 1, CurrentY - 2, ref r);

        return r; 
    }

    public void HorseMove (int x, int y, ref bool[,] r)
    {
        Chessman c;
        if(x >= 0 && x < 8 && y >= 0 && y < 8)
        {
            c = BoardManager.Instance.Chessmans[x, y];
            if(c == null)
            {
                r[x, y] = true;
            }
            else if(isWhite != c.isWhite)
            {
                r[x, y] = true;
            }
        }
    }
}
