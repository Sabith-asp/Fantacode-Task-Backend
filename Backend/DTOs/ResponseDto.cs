﻿namespace Backend.DTOs
{
    public class ResponseDto<T>
    {
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }

    }
}
