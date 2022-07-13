namespace JokesWebApp.Models
{
    public class Joke
    {
        public Joke()
        {

        }

        public virtual int Id { get; set; }
        public virtual string? JokeQuestion { get; set; }
        public virtual string? JokeAnswer { get; set; }
    }
}
