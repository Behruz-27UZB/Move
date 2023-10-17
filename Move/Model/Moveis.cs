namespace Move.Model
{
    public class Moveis
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discreption { get; set; }
        public string Inage { get; set; }
        public virtual Author? Authore { get; set; }
    }
}
