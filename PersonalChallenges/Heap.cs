
using System;
using System.Collections.Generic;

namespace Solution {
    //
    // I just wanted to learn how to create a simple heap
    // Heaps are just trees (linked list) organized in a certain way
    // Min meaning a heap that starts at its smallest value
    // Max maening a heap that starts at its highest value
    // every heap has a linked list of nodes that creates our tree
    //
    // this is usefull because a heap allows us to aways have a list of elements organized by a certain criteria (usually a number) no matter what element we remove from it.
    // an used example: Reddit ranking usefull posts by using an "relatability" number (determined by what posts an user interacts with since every single one of then has a "weight" for a certain criteria that is most likelly the user's favorite) and showing then on the user home feed with peak efficiency.
    // Heaps are also probably used to configure AIs during training, since they could rank how "certain" the machine is on its decision based on the logic it was given (that could be given by either another machine or a human engineer, and that is CRAZY!!)
    // in videogames heaps can be used to connect "rooms" to eachother (since well be probably using an object pointer) so in a videogame like minus Decendance (a game on roblox) the main elevator room is our initial node or heap trunk/seed and every room generated from there is one of its children, generated one child at a time to prevent overlapping (witch may be why the game lags on generation, its instanciating/rendering the game objects into memory) with the elevator being the head of a quartenary heap.

    public class Node {
        T value {get; set;}
        BinaryHeap Children {get;set;}
    }
    public class BinaryHeap {
        Node Left {get;set;}
        Node Right {get;set;}

    }

    public void MaxHeap(Array<T> inputElements) {


        return;
    }
    public void MinHeap(Array<int> inputElements )  {


        return;
    }
}