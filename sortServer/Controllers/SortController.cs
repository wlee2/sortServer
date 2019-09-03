using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sortServer.Services;

namespace sortServer.Controllers
{
    [RoutePrefix("api/sort")]
    public class SortController : ApiController
    {
       [HttpPost]
       public IHttpActionResult Sorting(int[] unsorted)
        {
            Quick_Sort quicksort = new Quick_Sort();
            quicksort.QuickSort(unsorted, 0, unsorted.Length - 1);

            return Ok(quicksort.steps);
        }
    }
}
