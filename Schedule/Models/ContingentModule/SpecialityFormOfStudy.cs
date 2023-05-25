using Schedule.Models.ReferenceBooksModule;

namespace Schedule.Models.ContingentModule
{
    public class SpecialityFormOfStudy
    {
        public int Id { get; set; }
        public byte IdSpeciality { get; set; }
        public Speciality Speciality { get; set; }
        public byte IdDepartament { get; set; }
        public Departament Departament { get; set; }
        public byte IdFormOfStudy { get; set; }
        public FormOfStudy FormOfStudy { get; set; }
    }
}
