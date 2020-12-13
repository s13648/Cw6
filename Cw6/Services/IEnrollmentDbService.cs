using System.Threading.Tasks;
using Cw6.Dto;

namespace Cw6.Services
{
    public interface IEnrollmentDbService
    {
        Task<Enrollment> GetBy(string studies, int semester);

        Task<bool> Exists(string studies, int semester);

        Task<Enrollment> EnrollStudent(EnrollStudent model, Study study);
        Task Promotions(Promotions promotions);
    }
}
