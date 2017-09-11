using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.LearningHard
{
    /// <summary>
    /// 外观类 （提供一个统一的接口给客户端调用）
    /// </summary>
    public class RegistrationFacade
    {
        private RegisterCourse registerCourse;
        private NotifyStudent notifyStudent;
        public RegistrationFacade()
        {
            registerCourse = new RegisterCourse();
            notifyStudent = new NotifyStudent();
        }
        public bool RegisterCourse(string courseName, string studentName)
        {
            if (!registerCourse.CheckAvailable(courseName))
            {
                return false;
            }
            return notifyStudent.Notify(studentName);
        }
    }
}
