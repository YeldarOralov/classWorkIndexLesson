using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyLesson
{
    public class User
    {
        
        

        //private int _id;
        //public int GetId()
        //{
        //    return _id;
        //}
        //public void SetId(int id)
        //{
        //    _id = id;
        //}

        public int Id { get; set; }
        
        //public возвр_тип {get;set} - автосвойство (auto property)

        /* private тип переменная;
         * public возвр_тип имя
         * {
         *      get{
         *          тело;
         *          return переменная;
         *      }
         *      set{
         *          тело;
         *          переменная = value;
         *      }
         *  }
         *
         * 
         */
        private string _login;
        public string Login
        {
            get
            {
                //тело
                return _login;
            }
            set
            {
                _login = value;
            }
        }
        
        private string _password;



        private string[] _nicknames;
        public string this[int index]
        {
            get { return _nicknames[index]; }
            set { _nicknames[index] = value; }
        }

        /* private тип_массива[] переменная;
         * public тип_массива this [тип index]
         * {
         *      get{
         *          return переменная[index]
         *      }
         *      set{
         *          переменная[index] = value;
         *      }
         * }
         */


        



    }
}
