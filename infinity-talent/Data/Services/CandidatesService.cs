using infinity_talent.Data.Models;
using infinity_talent.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace infinity_talent.Data.Services
{
    public class CandidatesService
    {
        private AppDbContext _context;
        public CandidatesService(AppDbContext context)
        {
            _context = context;
        }

        public void AddCandidate(CandidateVM candidate)
        {
            var _candidate = new Candidate()
            {
                Name = candidate.Name,
                EmailMain = candidate.EmailMain,
                Created = DateTime.Now
            };

            _context.Candidates.Add(_candidate);
            _context.SaveChanges();

            var _candidateContacts = new CandidateContacts()
            {
                Mobile = candidate.candidateContacts.Mobile,
                Linkedln = candidate.candidateContacts.Linkedln,
                CandidateId = _candidate.Id
            };

            _context.CandidatesContacts.Add(_candidateContacts);
            _context.SaveChanges();
        }

        public List<Candidate> GetAllCandidates() => _context.Candidates.ToList();

        public Candidate GetCandidateById(int candidateId) => _context.Candidates.FirstOrDefault(n => n.Id == candidateId);

        public Candidate UpdateCandidate(int id, CandidateVM candidate)
        {
            var _candidate = _context.Candidates.FirstOrDefault(n => n.Id == id);
            if (_candidate != null)
            {
                _candidate.Name = candidate.Name;
                _candidate.EmailMain = candidate.EmailMain;
                _candidate.Updated = DateTime.Now;

                _context.SaveChanges();
            }
            return _candidate;
        }

        public void DeleteBookById(int id)
        {
            var _candidate = _context.Candidates.FirstOrDefault(n => n.Id == id);

            if (_candidate != null)
            {
                _context.Candidates.Remove(_candidate);
                _context.SaveChanges();
            }
        }
    }
}
