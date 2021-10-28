using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLibrary
{
    public class Day
    {
        /// <summary>
        /// Mendapatkan nama hari dalam bahasa indonesia
        /// Misal, bila dayNumber = 1, method ini akan menghasilkan Senin
        /// </summary>
        /// <param name="dayNumber">hari dalam angka</param>
        /// <returns>hari dalam bahasa indonesia</returns>
        public string NameOfDay(int dayNumber)
        {
            string hari = "";

            switch (dayNumber)
            {
                case 1:
                    hari = "Senin";
                    break;

                case 2:
                    hari = "Selasa";
                    break;

                case 3:
                    hari = "Rabu";
                    break;

                case 4:
                    hari = "Kamis";
                    break;

                case 5:
                    hari = "Jum'at";
                    break;

                case 6:
                    hari = "Sabtu";
                    break;

                case 7:
                    hari = "Minggu";
                    break;

                default:
                    break;
            }

            return hari;
        }
    }
}
