﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Choice
    {
        public int ID { get; set; }
        public string ChoiceDescription { get; set; }
        //public int QuestionID { get; set; }
        public Question QuestionID { get; set; }
    }
}
