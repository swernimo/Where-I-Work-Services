using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using where_I_workService.DataObjects;
using where_I_workService.Models;

namespace where_I_workService.Controllers
{
    public class BusinessController : TableController<Business>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            where_I_workContext context = new where_I_workContext();
            DomainManager = new EntityDomainManager<Business>(context, Request);
        }

        // GET tables/Business
        public IQueryable<Business> GetAllBusinesss()
        {
            return Query();
        }

        // GET tables/Business/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Business> GetBusiness(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Business/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Business> PatchBusiness(string id, Delta<Business> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Business
        public async Task<IHttpActionResult> PostBusiness(Business item)
        {
            Business current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Business/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteBusiness(string id)
        {
            return DeleteAsync(id);
        }
    }
}