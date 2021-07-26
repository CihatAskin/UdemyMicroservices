using FreeCourse.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Shared.ControllerBases
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> reponse)
        {
            return new ObjectResult(reponse)
            {
                StatusCode = reponse.StatusCode
            };
        }

    }
}
