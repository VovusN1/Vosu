using Schedule.Models.ReferenceBookModule;
using Schedule.Models.ReferenceBooksModule;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schedule.Models.GeneralModule
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public byte IdPost { get; set; }
        public Post? Post { get; set; }
        public byte IdAuditorium { get; set; }
        public Auditorium? Auditorium { get; set; }
        public bool Active { get; set; }
    }
}
