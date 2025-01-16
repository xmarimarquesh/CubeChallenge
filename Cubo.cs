using System;
using System.Collections.Generic;


public class Cubo
{
    public string Top { get; set; }
    public string Bottom { get; set; }
    public string Front { get; set; }
    public string Left { get; set; }
    public string Right { get; set; }
    public string Back { get; set; }

    public Cubo(string top, string bottom, string front, string left, string right, string back)
    {
        Top = top;
        Bottom = bottom;
        Front = front;
        Left = left;
        Right = right;
        Back = back;
    }

    
}
