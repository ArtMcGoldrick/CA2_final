using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2_final
{
    //This creates the enum outside of class
    public enum ActivityType { Air, Water, Land };

    public class Activitys
    {
        //Properties
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public ActivityType TypeOfActivity { get; set; }

        //Constructors
        public Activitys(string name, decimal cost, string description, ActivityType typeOfActivity)
        {
            Name = name;
            Cost = cost;
            Description = description;
            TypeOfActivity = typeOfActivity;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
