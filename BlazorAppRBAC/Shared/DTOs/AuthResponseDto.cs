namespace BlazorAppRBAC.Shared.DTOs
{
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}