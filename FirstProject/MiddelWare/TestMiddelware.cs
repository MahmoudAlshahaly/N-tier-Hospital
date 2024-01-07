namespace FirstProject.MiddelWare
{
    public class TestMiddelware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TestMiddelware> _logger;

        //next for call the next middelware
        public TestMiddelware(RequestDelegate next,ILogger<TestMiddelware> logger)
        {
            _next = next;
            _logger = logger;
        }
        //to send httpcontext 
        public async Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("Test middelware before isolated 2");
            //logic before
            await _next.Invoke(httpContext);
            //logic after
            _logger.LogInformation("Test middelware after isolated 2");

        }


    }
}
