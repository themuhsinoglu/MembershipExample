using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Membership.WepAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;

        //daha önce mediatr enjekte edilmiş ise var olanı döndür yoksa ioc de enjekte et.
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
