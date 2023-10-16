﻿namespace BlazorAppRBAC.Shared.DTOs
{
    public class RegistrationResponseDto
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string> Errors { get; set; } = null!;
    }
}