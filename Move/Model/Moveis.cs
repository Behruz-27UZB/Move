using LinqToDB.Mapping;

namespace Move.Model
{
    public class Moveis
    {
        internal int Id;
        internal string Image;

        public class Author
        {
            [Identity]
            public int Id { get; set; }

            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
