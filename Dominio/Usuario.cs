namespace Example_julian.Dominio
{
    public class Usuario
    {

        public int Id;

        public string Name;

        public string Email;

        public Usuario(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public Usuario()
        {
            Id = 0;
            Name = "";
            Email = "";
        }


    }
}
