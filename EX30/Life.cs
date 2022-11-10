using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        readonly private DateTime _birthDay = new DateTime();
        readonly private int _lifeSpan;
        readonly private int _age;
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public int lifeSpan
        {
            get { return _lifeSpan; }
        }
        public int age
        {
            get { return _age; }
        }
        public Life(DateTime bd, string n, float wi = 0, float h = 0, float d = 0, float we = 0, int l = 0, int a = 0) : base( n, wi, h, d, we)
        {
            this._birthDay = bd;
            this._lifeSpan = l;
            this._age = a;

        }

        public bool CheckBirthDay(DateTime bd)
        {
            if(this._birthDay == bd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
