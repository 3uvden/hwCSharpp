using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwCSharpp
{
    public class Money
    {
        public double Sum { get; set; }

        public static implicit operator Money(double sum)
        {
            return new Money(sum);
        }
        public static Money operator+(Money num, Money num1)
        {
            return new Money(num.Sum + num1.Sum);
        }
        public static Money operator+(Money num, double num1)
        {
            Money res = num + num1;
            return res;
        }
        public static Money operator-(Money num, Money num1)
        {
            return new Money(num1.Sum - num1.Sum);
        }
        public static Money operator-(Money num, double num1)
        {
            Money res = num1 - num1;
            return res;
        }
        public static Money operator*(Money num, int num1)
        {
            return new Money(num.Sum * num1);
        }
        public static Money operator/(Money num, int num1)
        {
            if (num1 == 0)
            {
                throw new DivideByZeroException("Делить на 0 нельзя");
            }
            return new Money(num.Sum / num1);
        }
        public static Money operator++(Money num)
        {
            return new Money(num.Sum + 0.1);
        }
        public static Money operator--(Money num)
        {
            return new Money(num.Sum - 0.1);
        }
        public static bool operator>(Money num, Money num1)
        {
            return num.Sum > num1.Sum;
        }
        public static bool operator<(Money num, Money num1)
        {
            return num.Sum < num1.Sum;
        }
        public static bool operator==(Money num, Money num1)
        {
            return num.Sum == num1.Sum;
        }
        public static bool operator!=(Money num, Money num1)
        {
            return num.Sum != num1.Sum;
        }
        public Money(double sum)
        {
            Sum = sum;
        }
    }
}
