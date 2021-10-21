namespace GenericServicesCrud.DTO.JWT
{
    public class JWTSettingDTO
    {
        public string SecurityKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
