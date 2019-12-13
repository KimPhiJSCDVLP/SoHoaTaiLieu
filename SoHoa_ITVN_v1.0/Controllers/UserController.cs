using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using So_Hoa_ITVN_Models;
using So_Hoa_ITVN_Services.Services.ServicesUser;

namespace SoHoa_ITVN_v1._0.Controllers
{
    [RoutePrefix("api/userapi")]
    public class UserApiController : BaseApiController
    {
        private IServicesUser iServicesUser;
        //[HttpGet, Route("")]
        //public async Task<IHttpActionResult> Search([FromUri]Pagination pagination, [FromUri]int? userId = null, [FromUri]int? apiId = null)
        //{
        //    //using (var db = new ApplicationDbContext())
        //    //{
        //    //    IQueryable<UserApi> results = db.UserApi;
        //    //    if (pagination == null)
        //    //        pagination = new Pagination();
        //    //    if (pagination.includeEntities)
        //    //    {
        //    //        results = results.Include(o => o.Users);
        //    //    }

        //    //    if (userId.HasValue) results = results.Where(o => o.UserId == userId);
        //    //    if (apiId.HasValue) results = results.Where(o => o.ApiId == apiId);

        //    //    results = results.OrderBy(o => o.UserApiId);

        //    //    return Ok((await GetPaginatedResponse(results, pagination)));
        //    //}
        //}

        [HttpGet, Route("{userApiId:int}")]
        public async Task<IHttpActionResult> Get(int userApiId)
        {
            if (userApiId == 0)
                return NotFound();
            else
            {
                S_Users userApi = iServicesUser.GetUser(userApiId);
                if (userApi !=null)
                {

                    return Ok(userApi);
                }
                else
                    return NotFound();
            }
        }

        //[HttpPost, Route("")]
        //public async Task<IHttpActionResult> Insert([FromBody]UserApi userApi)
        //{
        //    if (userApi.UserApiId != 0) return BadRequest("Invalid UserApiId");

        //    using (var db = new ApplicationDbContext())
        //    {
        //        db.UserApi.Add(userApi);
        //        await db.SaveChangesAsync();
        //    }

        //    return Ok(userApi);
        //}

        //[HttpPut, Route("{userApiId:int}")]
        //public async Task<IHttpActionResult> Update(int userApiId, [FromBody]UserApi userApi)
        //{
        //    if (userApi.UserApiId != userApiId) return BadRequest("Id mismatch");

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    using (var db = new ApplicationDbContext())
        //    {
        //        db.Entry(userApi).State = EntityState.Modified;

        //        try
        //        {
        //            await db.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException ducEx)
        //        {
        //            bool exists = db.UserApi.Count(o => o.UserApiId == userApiId) > 0;
        //            if (!exists)
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw ducEx;
        //            }
        //        }

        //        return Ok(userApi);
        //    }
        //}

        //[HttpDelete, Route("{userApiId:int}")]
        //public async Task<IHttpActionResult> Delete(int userApiId)
        //{
        //    using (var db = new ApplicationDbContext())
        //    {
        //        var userApi = await db.UserApi.SingleOrDefaultAsync(o => o.UserApiId == userApiId);

        //        if (userApi == null)
        //            return NotFound();

        //        db.Entry(userApi).State = EntityState.Deleted;

        //        await db.SaveChangesAsync();

        //        return Ok();
        //    }
        //}


    }
}
