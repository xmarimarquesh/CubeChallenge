using static System.Console;
using System.Collections.Generic;
public static class Machine
{
    public static int Combination(List<Cubo> cubo)
    {
        HashSet<string> combSet = new HashSet<string>();

        List<Cubo> temp = new List<Cubo>();
        foreach (Cubo c in cubo){
            temp.Add(new Cubo(c.Top, c.Bottom, c.Front, c.Left, c.Right, c.Back));
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                string comb = $"{temp.Front},{temp.Top},{temp.Bottom},{temp.Back}";
                combSet.Add(comb);

                // Rotação lateral (gira em torno do eixo vertical)
                RotateAroundVertical(temp);
            }

            // Rotação do cubo (muda o eixo vertical)
            if (i < 3)
                RotateForward(temp);
            else
                RotateSideways(temp);
        }

        foreach (var comb in combSet)
        {
            WriteLine(comb);
        }

        WriteLine($"Total de combinações distintas: {combSet.Count}");

        return combSet.Count;
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
}