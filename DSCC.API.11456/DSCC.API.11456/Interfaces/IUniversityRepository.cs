using DSCC.API._11456.Models;

namespace DSCC.API._11456.Interfaces
{
	public interface IUniversityRepository
	{
        void InsertUniversity(University university);
        void UpdateUniversity(University university);
        void DeleteUniversity(int universityId);
        University GetUniversityById(int universityId);
        IEnumerable<University> GetAllUniversities();
        IEnumerable<object> GetUniversitiesShortNames();
    }
}

