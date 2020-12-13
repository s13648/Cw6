using System.Threading.Tasks;
using Cw6.Dto;

namespace Cw6.Services
{
    public interface IStudyDbService
    {
        Task<Study> GetByName(string modelStudies);
    }
}
