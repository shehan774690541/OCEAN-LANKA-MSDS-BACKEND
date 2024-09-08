using System.Net;

namespace ocl_msds.Helpers.Responces
{
    public class BaseResponce
    {
        public int status_code {  get; set; }
        public object data { get; set; }

        /// <summary>
        /// This method can be used to genarete the responce object from the classes with are inherited from the BaseResponse class
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="data"></param>
        ///

        public void CreateResponce(HttpStatusCode statusCode, object data)
        {
            status_code = (int)statusCode;
            this.data = data;
        }

    }
}
