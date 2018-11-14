//Prog 4
//Grade ID: C2518
//Due: 11/27/17
//CIS 200-01

//File: DescDestZip.cs
//This class compares and sorts parcels by destination zip code in descending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescDestZip : IComparer<Parcel>
    {
        //Precondition: None
        //Postcondition: When p1 < p2, method returns negative #
        //               When p1 == p2, method returns 0
        //               When p1 >  p2, method returns positive
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;
            if (p1 == null)
                return -1;
            if (p2 == null)
                return -1;

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); //reverses natural order = descending
        }
    }
}
