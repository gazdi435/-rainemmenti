using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public enum nyelvCsalad { moduláris, strukturális, funkcionális, objektumOrientált };
    public class Nyelv
    {
        string neve;
        nyelvCsalad nyelvCsalad;
        bool forditosE;
        int megjelenesEve;
        bool alacsonyszintuE;
        int nepszeruseg2022;

        public Nyelv(string neve, nyelvCsalad nyelvCsalad, bool forditosE, int megjelenesEve, bool alacsonyszintuE, int nepszeruseg2022)
        {
            this.neve = neve;
            this.nyelvCsalad = nyelvCsalad;
            this.forditosE = forditosE;
            this.megjelenesEve = megjelenesEve;
            this.alacsonyszintuE = alacsonyszintuE;
            this.nepszeruseg2022 = nepszeruseg2022;
        }

        public string Neve { get => neve; }
        public bool ForditosE { get => forditosE; }
        public int MegjelenesEve { get => megjelenesEve; }
        public bool AlacsonyszintuE { get => alacsonyszintuE; }
        public int Nepszeruseg2022 { get => nepszeruseg2022; }
        internal nyelvCsalad NyelvCsalad { get => nyelvCsalad; }




        /// <summary>
        ///
        /// </summary>
        /// <returns>Ha a legnépszerűbb 3-ba tartozik</returns>
        public bool NepszeruE()
        {
            return this.Nepszeruseg2022 <= 3;
        }
    }
}