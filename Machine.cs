using static System.Console;
using System.Collections.Generic;
public static class Machine
{
    public static HashSet<string> Combination(Cubo cubo)
    {
        HashSet<string> combSet = new HashSet<string>();

        Cubo temp = new Cubo(cubo.Top, cubo.Bottom, cubo.Front, cubo.Left, cubo.Right, cubo.Back);

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                string comb = $"{temp.Front},{temp.Top},{temp.Bottom},{temp.Back}";
                combSet.Add(comb);

                // Rotação lateral
                RotateAroundVertical(temp);
            }

            // Rotação do cubo
            if (i < 3)
                RotateForward(temp);
            else
                RotateSideways(temp);
        }

        return combSet;
    }

    private static void RotateAroundVertical(Cubo c)
    {
        string temp = c.Front;
        c.Front = c.Right;
        c.Right = c.Back;
        c.Back = c.Left;
        c.Left = temp;
    }

    private static void RotateForward(Cubo c)
    {
        string temp = c.Top;
        c.Top = c.Front;
        c.Front = c.Bottom;
        c.Bottom = c.Back;
        c.Back = temp;
    }

    private static void RotateSideways(Cubo c)
    {
        string temp = c.Top;
        c.Top = c.Left;
        c.Left = c.Bottom;
        c.Bottom = c.Right;
        c.Right = temp;
    }

    public static int CombinateCube(HashSet<string> c1, HashSet<string> c2, HashSet<string> c3, HashSet<string> c4)
    {

        string[] partesA = [];
        string[] partesB = [];
        string[] partesC = [];
        string[] partesD = [];

        int count = 0;

        foreach (var a in c1)
        {
            foreach (var b in c2)
            {
                foreach (var c in c3)
                {
                    foreach (var d in c4)
                    {
                        partesA = a.Split(',');
                        partesB = b.Split(',');
                        partesC = c.Split(',');
                        partesD = d.Split(',');

                        if (partesA[0] != partesB[0] && partesA[0] != partesC[0] && partesA[0] != partesD[0] && partesB[0] != partesC[0] && partesB[0] != partesD[0] && partesC[0] != partesD[0]
                        && partesA[1] != partesB[1] && partesA[1] != partesC[1] && partesA[1] != partesD[1] && partesB[1] != partesC[1] && partesB[1] != partesD[1] && partesC[1] != partesD[1]
                        && partesA[2] != partesB[2] && partesA[2] != partesC[2] && partesA[2] != partesD[2] && partesB[2] != partesC[2] && partesB[2] != partesD[2] && partesC[2] != partesD[2]
                        && partesA[3] != partesB[3] && partesA[3] != partesC[3] && partesA[3] != partesD[3] && partesB[3] != partesC[3] && partesB[3] != partesD[3] && partesC[3] != partesD[3])
                        {
                            WriteLine(" | "+a+" | "+b+" | "+c+" | "+d+" | ");
                            count += 1;
                        }
                    }
                }
            }
        }

        return count;
    }


}