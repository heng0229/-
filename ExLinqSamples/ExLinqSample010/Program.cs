using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample010
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = createteachers();
            var student = createstudents();
            var result =
                from t in teacher
                join s in student
                on t.classname equals s.classname
                select
                new ResultInfo
                { classname = t.classname, teacher = t.teacher, student = s.student };
            foreach(var item in result)
            {
                Console.WriteLine($"{item.classname}:{item.teacher}:{item.student}");
            }
            Console.ReadLine();
        }
        static List<TeacherInfo> createteachers()
        {
            return new List<TeacherInfo>
            {
            new TeacherInfo { classname="1A",teacher="Bill"},
            new TeacherInfo { classname="1B",teacher="David"}
            };
        }
        static List<StudentInfo> createstudents()
        {
            return new List<StudentInfo>
            {
            new StudentInfo { classname="1A",student="魯夫"},
            new StudentInfo { classname="1A",student="索隆"},
            new StudentInfo { classname="1B",student="櫻木"},
            new StudentInfo { classname="1A",student="香吉士"},
            new StudentInfo { classname="1B",student="流川楓"}
            };
        }
    }
}