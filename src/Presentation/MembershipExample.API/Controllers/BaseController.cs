using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MembershipExample.API.Controllers
{
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;

        //daha önce mediatr enjekte edilmiş ise var olanı döndür yoksa ioc de enjekte et.
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        //protected async Task<ValidationResult> ValidateAndHandle<TRequest>(TRequest request)
        //{
        //    var validator = HttpContext.RequestServices.GetService<IValidator<TRequest>>();

        //    if (validator != null)
        //    {
        //        var validationResult = await validator.ValidateAsync(request);

        //        //if (!validationResult.IsValid)
        //        //{
        //        //    return validationResult;
        //        //}
        //        return validationResult;
        //    }

        //    return null;
        //}

    }
}
