using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class Exam
    {
        private string id;
        private string title;
        private DateTime openedAt;
        private int duration;
        // each question mapped with its score
        private Dictionary<Question, int> questions;
    }
}
