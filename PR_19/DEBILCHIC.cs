namespace PR_19
{
    public class DEBILCHIC
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsAgreed { get; set; }


        public string GetInfo()
        {
            return $"Имя: {Name}\nEmail: {Email}\nРоль: {Role}\nСогласен: {(IsAgreed ? "Да" : "Нет")}";
        }
    }
}