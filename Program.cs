using System.Collections;
using System.Collections.Generic;

Cubo a = new Cubo("yellow", "green", "yellow", "blue", "red", "yellow");
Cubo b = new Cubo("red", "green", "yellow", "yellow", "yellow", "blue");
Cubo c = new Cubo("red", "blue", "blue", "green", "green", "yellow");
Cubo d = new Cubo("red", "blue", "yellow", "green", "red", "green");

List<Cubo> list = new List<>();

list.add(a);
list.add(b);
list.add(c);
list.add(d);

Combination(list);