using Schedule.Models.GeneralModule;
using Schedule.Models.ReferenceBooksModule;

namespace Schedule.Models.ContingentModule
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdClassTeacher { get; set; }
        public Employee ClassTeacher { get; set; }
        public int IdSpecialityFormOfStudy { get; set; }
        public SpecialityFormOfStudy SpecialityFormOfStudy { get; set; }
        //public byte IdTypeFinancing { get; set; }
        //public TypeFinancing TypeFinancing { get; set; }
        //public byte IdStatusGroup { get; set; }
        //public StatusGroup StatusGroup { get; set; }
    }
}
