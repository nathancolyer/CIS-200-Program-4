//Prog 4
//Grade ID: C2518
//Due: 11/27/17
//CIS 200-01

//File: AscendTypeDescCost.cs
//This class compares and sorts parcels by type(ascending) and then by cost(descending).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class AscendTypeDescCost : IComparer<Parcel>
    {
        //Pre:None
        //Postconditions: When p1 < p2, method returns negative #
        //                When p1 == p2, method returns 0
        //                When p1 > p2, methods turns postivive #
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            if ((p1.GetType().ToString()) == (p2.GetType().ToString())) //are the parcel types the same?
            {
                return (-1)*(p1.CalcCost()).CompareTo(p2.CalcCost());  //if so, compare by cost
            }
            else
            {
                return (p1.GetType().ToString()).CompareTo(p2.GetType().ToString()); // else compare the types
            }

        }
    }
}
