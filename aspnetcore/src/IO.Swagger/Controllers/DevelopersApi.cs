/*
 * Simple Geth API
 *
 * This is a simple Geth API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: spannos@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DevelopersApiController : ControllerBase
    { 
        /// <summary>
        /// searches inventory
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="searchString">pass an optional search string for looking up inventory</param>
        /// <param name="skip">number of records to skip for pagination</param>
        /// <param name="limit">maximum number of records to return</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        [HttpGet]
        [Route("/insight-dc-sv-2020/geth/1.0.0/inventory")]
        [ValidateModelState]
        [SwaggerOperation("SearchInventory")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<InventoryItem>), description: "search results matching criteria")]
        public virtual IActionResult SearchInventory([FromQuery]string searchString, [FromQuery]int? skip, [FromQuery][Range(0, 50)]int? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<InventoryItem>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"releaseDate\" : \"2016-08-29T09:12:33.001Z\",\n  \"name\" : \"Widget Adapter\",\n  \"id\" : \"d290f1ee-6c54-4b01-90e6-d701748f0851\",\n  \"manufacturer\" : {\n    \"phone\" : \"408-867-5309\",\n    \"name\" : \"ACME Corporation\",\n    \"homePage\" : \"https://www.acme-corp.com\"\n  }\n}, {\n  \"releaseDate\" : \"2016-08-29T09:12:33.001Z\",\n  \"name\" : \"Widget Adapter\",\n  \"id\" : \"d290f1ee-6c54-4b01-90e6-d701748f0851\",\n  \"manufacturer\" : {\n    \"phone\" : \"408-867-5309\",\n    \"name\" : \"ACME Corporation\",\n    \"homePage\" : \"https://www.acme-corp.com\"\n  }\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<InventoryItem>>(exampleJson)
                        : default(List<InventoryItem>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
