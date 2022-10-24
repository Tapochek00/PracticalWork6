using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Пять
{
    internal class Liquid
    {
        String name;
        double density;
        double volume;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }

        public Double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }

        public Liquid()
        {
            Name = "";
            Density = 0;
            Volume = 0;
        }

        public Liquid(string name, double density, double volume)
        {
            Name = name;
            Density = density;
            Volume = volume;
        }

        /// <summary>
        /// Находит разницу объёмов жидкостей
        /// </summary>
        /// <param name="liquid">Вторая жидкость</param>
        /// <returns>Разницу объёмов</returns>
        public double VolumeDifference(Liquid liquid)
        {
            return Math.Abs(liquid.Volume - Volume);
        }

        /// <summary>
        /// Находит разницу плотностей жидкостей
        /// </summary>
        /// <param name="liquid">Вторая жидкость</param>
        /// <returns>Разницу жидкостей</returns>
        public double DensityDifference(Liquid liquid)
        {
            return Math.Abs(liquid.Density - Density);
        }

        /// <summary>
        /// Изменить назнание, плотность и объём жидкости 
        /// </summary>
        public void SetParams()
        {
            Name = "";
            Density = 0;
            Volume = 0;
        }

        /// <summary>
        /// Изменить назнание, плотность и объём жидкости 
        /// </summary>
        public void SetParams(string name, double density, double volume)
        {
            Name = name;
            Density = density;
            Volume = volume;
        }

        /// <summary>
        /// Возвращает информацию о жидкости, собранную в одну строку
        /// </summary>
        /// <returns>Информация о жидкости</returns>
        public string LiquidInfo()
        {
            return "Название: " + Name + "\n" + "Плотность: " + Density.ToString() + "\n" + "Объём: " + Volume.ToString();
        }

        /// <summary>
        /// Проверяет, что сосуды имеют одинаковые жидкости равного объема.
        /// </summary>
        /// <param name="liquid"></param>
        /// <returns>Логическое значение: true, если жидкости одинаковые; false, если жидкости разные</returns>
        public bool IsSame(Liquid liquid)
        {
            if(liquid.Name == Name && liquid.Density == Density && liquid.Volume == Volume) return true;
            else return false;
        }

        /// <summary>
        /// Увеличивает объём на 1
        /// </summary>
        public static Liquid operator ++(Liquid liquid)
        {
            liquid.Volume += 1;
            return liquid;
        }

        /// <summary>
        /// Уменьшает объём на 1
        /// </summary>
        public static Liquid operator --(Liquid liquid)
        {
            if (liquid.Volume > 0) liquid.Volume -= 1;
            return liquid;
        }
    }
}
