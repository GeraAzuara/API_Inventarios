using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;

namespace InventariosAPI.Data.Utils
{
    public class AuthResponse
    {
        /// <summary>
        /// Description about the response.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// HTTP Status Code returned by the API Request
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Token computed by the API
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Found Errors list during API request
        /// </summary>
        public IEnumerable<string> Errors { get; set; }

        /// <summary>
        /// Extra Info returne by the API request
        /// </summary>
        public IEnumerable<string> ExtraInfo { get; set; }

        /// <summary>
        /// Token's Expiration date
        /// </summary>
        public DateTime? ExpireDate { get; set; }


        #region Constructores
        public AuthResponse()
        {

        }

        //public AuthResponse(int Code)
        //{
        //    StatusCode = Code;
        //    switch (Code)
        //    {
        //        case StatusCodes.Status404NotFound:
        //            Message = "No hay Coincidencias.";
        //            break;
        //    }
        //}
        #endregion
    }
}
