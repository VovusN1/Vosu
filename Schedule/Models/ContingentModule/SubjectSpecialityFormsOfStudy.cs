using Schedule.Models.ReferenceBookModule;
using Schedule.Models.ReferenceBooksModule;

namespace Schedule.Models.ContingentModule
{
    public class SubjectSpecialityFormOfStudy
    {
        public int Id { get; set; }
        public int IdSubject { get; set; }
        public Subject Subject { get; set; }
        public int IdSpecialityFormOfStudy { get; set; }
        public SpecialityFormOfStudy SpecialityFormOfStudy { get; set; }
        public int IdAcademicYear { get; set; }
        public AcademicYear AcademicYear { get; set; }
        public byte NumberSemestr { get; set; }
        public byte NumberCourse { get; set; }
        public int TotalHours { get; set; }
        public int ObligatoryHours { get; set; }
        public int MaxHours { get; set; }
        public int LecturesHours { get; set; }
        public int PracticalsHours { get; set; }
        public int LaboratoryHours { get; set; }
        public int ConsultationsHours { get; set; }

        public byte IdTypeOfControl { get; set; }
        public TypeOfControl TypeOfControl { get; set; }
        public int YearApprovals { get; set; }
    }
}
