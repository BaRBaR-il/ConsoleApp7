using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Student
    {
        private int calcGrade;
        private int hebrewGrade;
        public bool SetCalcGrade(int calcGrade)
        {
            if (calcGrade >= 0 && calcGrade <= 100)//הנחתי שהציון הוא בין 0 ל100 כי אין בונוסים
            {
                this.calcGrade = calcGrade;
                return true;
            }
            this.calcGrade = 0; //הנחתי ש0 ערך ברירת מחדל של הציון
            return false;
        }
        public bool SetHebrewGrade(int hebrewGrade)
        {
            if (hebrewGrade >= 0 && hebrewGrade <= 100)//הנחתי שהציון הוא בין 0 ל100 כי אין בונוסים
            {
                this.hebrewGrade = hebrewGrade;
                return true;
            }
            this.hebrewGrade = 0; //הנחתי ש0 ערך ברירת מחדל של הציון
            return false;
        }
        public Student(int calcGrade,int hebrewGrade)
        {
            SetCalcGrade(calcGrade);
            SetHebrewGrade(hebrewGrade);
        }
        public int GetHebrewGrade() { return hebrewGrade; }
        public int GetCalcGrade() { return calcGrade; }

    }
}
