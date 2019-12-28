using System;
using System.Collections.Generic;
using System.Text;

namespace App1_Lamp.Model
{
    public class Lamp
    {
        private string Status { get; set; }
        private string Adjustment { get; set; }

        public Lamp() { }

        public Lamp(string state)
        {
            Status = state;
        }

        public String AdjustmentLamp()
        {
            if(Status == "Off")
            {
                Adjustment = "0%";
                return "Adjustment : " + Adjustment;
            }
            else if (Status == "On")
            {
                Adjustment = "100%";
                return "Adjustment : " + Adjustment;
            }
            else if(Status == "Half-light")
            {
                Adjustment = "50%";
                return "Adjustment : " + Adjustment;
            }
            return null;
        }

        public override string ToString()
        {
            return "State : " + Status;
        }
    }
}
