using System.Web.Http;

[Authorize(Roles = "Administrators")]
[RoutePrefix("api/admin")]
public class AdminApiController : ApiController
{
    [HttpGet, Route("ping")]
    public IHttpActionResult Ping() => Ok(new { ok = true });
}
