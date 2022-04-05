using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_GenericTypes
{
    class Helper
    {
        public bool sendMail<T>(string member, T content)
        {
            if (member.Equals("Admin"))
            {
                Mail<T> mail = new Mail<T>
                {
                    From = "test@gmail.com",
                    To = "test2@gmail.com",
                    Content = content
                };
            }
            else
            {
                Mail<T> mail = new Mail<T>
                {
                    From = "test1@gmail.com",
                    To = "test2@gmail.com",
                    Content = content
                };
            }
            return true;
        }
    }
    class Mail<T>
    {
        public string From { get; set; }
        public string To { get; set; }
        public T Content { get; set; }

        public void Test()
        {
            new Helper().sendMail("", default(T));
        }
    }
}
