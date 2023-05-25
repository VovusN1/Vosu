using Schedule.Models.GeneralModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models.ContingentModule
{
    public class TeacherSubject
    {

        public int Id { get; set; }
        public int IdTeacher { get; set; }
        public Employee Teacher { get; set; }
        public int IdSubjectSpecialityFormOfStudy { get; set; }
        public SubjectSpecialityFormOfStudy SubjectSpeciality { get; set; }
        public double TotalHours { get; set; }
        public double LecturesHours { get; set; }
        public double PracticalsHours { get; set; }
        public double LaboratoryHours { get; set; }
        public double ConsultationsHours { get; set; }

            
    }
}
