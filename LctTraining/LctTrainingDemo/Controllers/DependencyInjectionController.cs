﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LCT
namespace LctTrainingDemo.Controllers
{
    public class DependencyInjectionController : ApiController
    {

        private ITraining _training;

        public DependencyInjectionController(ITraining training)
        {
            this._training = training;
        }



        // GET: api/DependencyInjection
        [HttpGet]
        [Route("api/InjectMessage")]
        public string GetMessageFromInjectedObject()
        {
            string message = _training.GetWelcomeMessag.();
            return message;
        }
        


        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DependencyInjection/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DependencyInjection
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DependencyInjection/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DependencyInjection/5
        public void Delete(int id)
        {
        }
    }
}
