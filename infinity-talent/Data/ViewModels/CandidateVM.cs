using infinity_talent.Data.Models;

namespace infinity_talent.Data.ViewModels
{
    public class CandidateVM
    {
        public string Name { get; set; }
        public string EmailMain { get; set; }
        public string Password { get; set; }

        public CandidateContactsVM candidateContacts { get; set; }
    }
}
