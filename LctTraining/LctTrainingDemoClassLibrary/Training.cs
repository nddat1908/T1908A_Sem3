using System;
using System.Collections.Generic;
using System.Text;

namespace LctTrainingDemoClassLibrary
{
    public class Training : ITraining
    {
        public string GetWelcomeMessage()
        {
            return "Welcome to LCT Training";
        }
    }
}
