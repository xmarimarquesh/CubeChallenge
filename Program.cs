using System.Collections;
using System.Collections.Generic;
using static System.Console;

//                  TOP      BOTTOM    FRONT    LEFT   RIGHT   BACK
// Cubo a = new Cubo("yellow", "green", "yellow", "blue", "red", "yellow");
// Cubo b = new Cubo("red", "green", "yellow", "yellow", "yellow", "blue");
// Cubo c = new Cubo("red", "blue", "blue", "green", "green", "yellow");
// Cubo d = new Cubo("red", "blue", "yellow", "green", "red", "green");

Cubo a = new Cubo("red", "yellow", "blue", "blue", "green", "blue"); 
Cubo b = new Cubo("red", "yellow", "blue", "green", "green", "red");
Cubo c = new Cubo("green", "green", "yellow", "blue", "yellow", "red");
Cubo d = new Cubo("red", "green", "red", "yellow", "blue", "blue");

HashSet<string> ca = Machine.Combination(a);
HashSet<string> cb = Machine.Combination(b);
HashSet<string> cc = Machine.Combination(c);
HashSet<string> cd = Machine.Combination(d);

// WriteLine("COMB A:");
// foreach (var comb in ca)
// {
//      WriteLine(comb);
// }
// WriteLine("COMB B:");
// foreach (var comb in cb)
// {
//      WriteLine(comb);
// }


int total = Machine.CombinateCube(ca, cb, cc, cd);

WriteLine("TOTAL: " + total);