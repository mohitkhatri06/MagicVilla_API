namespace MagicVilla_Web.Models.Dto
{
    public class LoginResponseDTO
    {
        public RegisterationRequestDTO User { get; set; }
        public string Token { get; set; }
    }
}
