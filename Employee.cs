using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    internal class Employee
    {
        private string employeeFirstName;
        private string employeeLastName;
        private int noOfDependents;
        private double noOfHours;

        public Employee(string first, string last, int dep,double hours)
        { 
            employeeFirstName = first;
            employeeLastName = last;
            noOfDependents = dep;
            noOfHours = hours;
        }

        public string EmployeeFirstName
        {
            set { employeeFirstName = value; }
            get { return employeeFirstName; }
        }
        public string EmployeeLastName
        {
            set { employeeLastName = value; }
            get { return employeeLastName; }
        }
        public int NoOfDependents
        {
            set { noOfDependents = value; }
            get { return noOfDependents; }
        }
        public double NoOfHours
        { set { noOfHours = value; }
            get { return noOfHours; }

        }
        public double DetermineGross()
        {
            const double RATE = 150.00;
            return noOfHours * RATE;
        }

        public double DetermineAgencyFee()
        {
            const double AGENCY_CHARGE = 0.13;
            return DetermineGross()*DetermineAgencyFee();
        }

        public double DetermineFederalTax()
        {
            const double FEDERAL_TAX = 0.25;
            const double DEPENDENT_ALLOWED = 0.0575;
            double gross;
            gross=DetermineGross();

            return (gross - (gross * (DEPENDENT_ALLOWED * noOfDependents))) * FEDERAL_TAX;

        }

        public double DetermineSocialSec()
        {
            const double SOCIAL_SEC_RATE = 0.0785;
            return DetermineGross() * SOCIAL_SEC_RATE;
        }

        public double DetermineNet()
        {
            return DetermineGross() - DetermineSocialSec() - DetermineFederalTax() - DetermineAgencyFee();
        }

        public override string ToString()
        {
            return employeeFirstName + " " + employeeLastName + "\nTake Home Pay: " + DetermineNet().ToString("C");
        }


    }
}
