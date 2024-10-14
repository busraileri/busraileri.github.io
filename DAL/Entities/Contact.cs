using System.Reflection.Metadata.Ecma335;

namespace MyPortfolio.DAL.Entities
{
	public class Contact
	{
        public int ContactId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

    }
}
