using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    //Derives from the base controller.
    public class ActivitiesController : BaseAPIController
    {
        private readonly DataContext context;

        //Inject the DataContext directly into the controller
        public ActivitiesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet] // /activities
        public async Task<ActionResult<List<Activity>>> GetActivities(){
            return await context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] // activities/:id
        public async Task<ActionResult<Activity>> GetActivity(Guid id){
            return await context.Activities.FindAsync(id);
        }
    }
}