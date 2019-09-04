using sortServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sortServer.Controllers
{
    [RoutePrefix("api/BubbleSort")]
    public class BubbleSortController : ApiController
    {
        [HttpPost]
        [Route("int")]
        public IHttpActionResult SortingInt(int[] unsorted)
        {
            Sort<int> sort = new Sort<int>();
            List<int[]> steps = new List<int[]>();

            sort.BubbleSort(unsorted, steps);
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

            sort.BubbleSort(unsorted, steps);
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

            sort.BubbleSort(unsorted, steps);
            List<string> temp = unsorted.ToList();
            steps.Add(temp.ToArray());
            return Ok(steps);

        }
    }
}
