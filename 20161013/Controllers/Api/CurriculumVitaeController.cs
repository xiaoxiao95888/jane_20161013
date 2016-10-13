using System.Linq;
using System.Web.Http;
using _20161013.Service;

namespace _20161013.Controllers.Api
{
    public class CurriculumVitaeController : ApiController
    {
        public readonly CurriculumVitaeService CurriculumVitaeService;

        public CurriculumVitaeController()
        {
            CurriculumVitaeService=new CurriculumVitaeService();
        }

        public object Get()
        {
            return CurriculumVitaeService.GetCurriculumVitaes().Count();
        }
    }
}
