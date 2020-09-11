using System.Linq;

namespace SmallTasks
{
    public class FirstTask
    {
        private readonly string str1;
        private readonly string str2;

        public FirstTask(string str1, string str2)
        {
            this.str1 = str1;
            this.str2 = str2;
        }

        public bool IsReverse() => new string(str1.Reverse().ToArray()) == str2;
    }
}
