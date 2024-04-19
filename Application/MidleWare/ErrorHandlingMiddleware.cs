﻿using System;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Test.Application.MidleWare;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IWebHostEnvironment env)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex, env);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception, IWebHostEnvironment env)
    {
        HttpStatusCode status;
        string message;
        var stackTrace = String.Empty;

        var exceptionType = exception.GetType();
        if (exceptionType == typeof(BadRequestException))
        {
            message = exception.Message;
            status = HttpStatusCode.BadRequest;
        }
       
        else if(exceptionType==typeof(UnauthorizedAccessException))
        {
            message = exception.Message;
            status = HttpStatusCode.Unauthorized;
        }
        else
        {
            status = HttpStatusCode.InternalServerError;
            message = exception.Message;
            if (env.IsEnvironment("Development"))
                stackTrace = exception.StackTrace;
        }

        var result = JsonSerializer.Serialize(new { error = message, stackTrace });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)status;
        return context.Response.WriteAsync(result);
    }
}

public class TestException:Exception
{
    public new string Message { get; set; }

    public TestException(string Message)
    {
        this.Message = Message;
    }

    public TestException(string[] errors)
    {
        var sb = new StringBuilder();
        foreach (var erorr in errors)
            sb.AppendLine(erorr.ToString());
        Message = sb.ToString();
    }
}

public class BadRequestException : TestException
{
    public BadRequestException(string Message) : base(Message)
    {
    }
}