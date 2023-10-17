using LinqToDB.Mapping;

namespace Move.Model
{
    public class Author
    {
        [Identity]
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string honeNumber { get; set; }


    }

}

