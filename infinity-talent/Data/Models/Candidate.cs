using System;
using System.Collections.Generic;

namespace infinity_talent.Data.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailMain { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
