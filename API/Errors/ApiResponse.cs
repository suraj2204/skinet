using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message= null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 =>"A bad Request, You have made",
                401 =>"Authorize, you are not",
                404 =>"Resource Not found",
                500 =>"Errors are the path to the dark side.errors lead to anger",
                _=> null
            };
        }
    }
}