using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    //int rn;
    //string name;
    //string address;
    //DateTime dob;

    // these are variables 
    // properties 
    // properties are the wrappers around the variables
    // properties are public. they can be used to access variables
    // outside the class
    // properties has 2 methods 
    // get set
    // get method is used to return value
    // set is used to store value

    internal class Student1
    {

        //int rn;
        //public int Rn
        //{
        //    get
        //    {
        //        return rn;
        //    }
        //    set
        //    {
        //        rn = value;
        //    }
        //}

        //string name;
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //private int rn;

        //public int Rn
        //{
        //    get { return rn; }
        //    set { rn = value; }
        //}
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //int rn;
        //public int Rn
        //{
        //    get
        //    {
        //        return rn;
        //    }
        //    set {
        //        if (value<0)
        //        {
        //            throw new Exception("rn can be negative");
        //        }
        //        rn = value; }
        //}


        // Autoimplicit properties
        public int Rn { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
    }
}
