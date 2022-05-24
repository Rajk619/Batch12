using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacultyDataLayer.Entities;
namespace FacultyDataLayer.Repositories
{
    public class FacultyRepository
    {
        private readonly FacultyDBContext db;
        public FacultyRepository()
        {
            this.db = new FacultyDBContext();
        }
        public void AddFaculty(Faculty faculty)
        {
            db.Faculties.Add(faculty);
            db.SaveChanges();
        }
        public void EditFacaulty(Faculty faculty)
        {
            db.Faculties.Update(faculty);
            db.SaveChanges();
        }
    }
}
