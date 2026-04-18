namespace MiPrimerAPI.Models
{
    public class UserApiResponse
    {
        public List<UserData> Data { get; set; }
    }

    public class UserData
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Avatar { get; set; }
    }
}
