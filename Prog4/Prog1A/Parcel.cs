// Program 4
// CIS 200-01
// Fall 2017
// Due: 11/27/17
// By: C2518

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy that supports IComparable Interface

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;
    }

    //Parcel construction: parcel object supplied as an argument
    public Parcel(Parcel p)
          : this(p.OriginAddress, p.DestinationAddress) { }

    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
            $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
    }

    //Precondition: None
    //Postcondition: When this < p2, method returns negative #
    //               When this == p2, method returns 0
    //               When this >  p2, method returns positive
    public int CompareTo(Parcel p2)
    {
        if (this == null && p2 == null) //both null
            return 1;                   //equal
        if (this == null)               //only this is null
            return -1;                  // null is less than other costs
        if (p2 == null)                  // only p2 null
            return 1;                    //any costs greater than null

        return (this.CalcCost()).CompareTo(p2.CalcCost()); // usees costs to decide
  
    }
}
