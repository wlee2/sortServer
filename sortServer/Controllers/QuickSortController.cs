using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sortServer.Services;

namespace sortServer.Controllers
{
    [RoutePrefix("api/QuickSort")]
    public class QuickController : ApiController
    {
       [HttpPost]
       [Route("int")]
       public IHttpActionResult SortingInt(int[] unsorted)
        {
            Sort<int> sort = new Sort<int>();
            List<int[]> steps = new List<int[]>();

            sort.QuickSort(unsorted, steps, 0, unsorted.Length - 1);
            List<int> temp = unsorted.ToList();
            steps.Add(temp.ToArray());
            return Ok(steps);
        }

        [HttpPost]
        [Route("double")]
        public IHttpActionResult SortingDouble(double[] unsorted)
        {
            Sort<double> sort = new Sort<double>();
            List<double[]> steps = new List<double[]>();

            sort.QuickSort(unsorted, steps, 0, unsorted.Length - 1);
            List<double> temp = unsorted.ToList();
            steps.Add(temp.ToArray());
            return Ok(steps);

        }

        [HttpPost]
        [Route("string")]
        public IHttpActionResult SortingString(string[] unsorted)
        {
            Sort<string> sort = new Sort<string>();
            List<string[]> steps = new List<string[]>();

            sort.QuickSort(unsorted, steps, 0, unsorted.Length - 1);
            List<string> temp = unsorted.ToList();
            steps.Add(temp.ToArray());
            return Ok(steps);

        }
    }
}
