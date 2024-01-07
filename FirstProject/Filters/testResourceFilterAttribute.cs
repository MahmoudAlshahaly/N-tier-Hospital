using Microsoft.AspNetCore.Mvc.Filters;

namespace FirstProject.Filters
{
    public class testResourceFilterAttribute : IResourceFilter
    {
        private readonly ILogger<testResourceFilterAttribute> _logger;

        public testResourceFilterAttribute(ILogger<testResourceFilterAttribute> logger)
        {
            _logger = logger;
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            var a=context.HttpContext.Request.Body;
            Console.WriteLine(a);
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
