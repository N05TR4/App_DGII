﻿using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
using WebApi.Exceptions;


namespace WebApi.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
               

                switch (error)
                {
                    case ApiException e:
                        //Custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                    case KeyNotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                     break;

                    
                }

                var result = JsonSerializer.Serialize(response);

                await response.WriteAsync(result);
            }
        }
    }
}
