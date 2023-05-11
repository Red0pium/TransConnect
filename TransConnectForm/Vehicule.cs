using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransConnectForm
{
    internal abstract class Vehicule
    {
        private string typeVehicule;
        protected bool enService;
        protected string plaqueImmatriculation;
        List<DateTime> datesOccupees;

        public Vehicule(string typeVehicule, bool enService, string plaqueImmatriculation)
        {
            this.datesOccupees = new List<DateTime>();
            this.typeVehicule = typeVehicule;
            this.enService = enService;
            this.plaqueImmatriculation = plaqueImmatriculation;
        }

        public string TypeVehicule
        { get { return typeVehicule; } }

        public bool EnService
        { get { return enService; } }

        public string PlaqueImmatriculation
        { get { return plaqueImmatriculation; } }

        public List<DateTime> ListeDatesOccupees
        { get { return datesOccupees; } }

        public virtual double Prix(string PointA, string PointB,CheminRoutier Route)
        {
            return -1;
        }


        #region date
        public void LectureDates()
        {
            datesOccupees = new List<DateTime>();
            string[] date = new string[3];
            string[] dates = File.ReadAllLines($"Vehicules\\{plaqueImmatriculation}_Date.csv");
            foreach(string d in dates)
            {
                date=d.Split("/");
                datesOccupees.Add(new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0])));
            }
        }

        public void AjoutDate(DateTime date)
        {
            string date2 = (date.Day < 10) ? ("0" + date.Day + "/") : (date.Day + "/");
            date2 += (date.Month < 10) ? ("0" + date.Month + "/") : (date.Month + "/");
            date2 += date.Year;
            if (datesOccupees.Count==0 || !datesOccupees.Contains(date.Date))
            {
                datesOccupees.Add(date.Date);
                StreamWriter writer = new StreamWriter($"Vehicules\\{plaqueImmatriculation}_Date.csv", true);
                writer.WriteLine(date2);
                writer.Close();
            }
        }

        public void SuppressionDate(DateTime date)
        {
            datesOccupees.Remove(date);
            string date2 = (date.Day < 10) ? ("0" + date.Day + "/") : (date.Day + "/");
            date2 += (date.Month < 10) ? ("0" + date.Month + "/") : (date.Month + "/");
            date2 += date.Year;
            string[] lignes = File.ReadAllLines($"Vehicules\\{plaqueImmatriculation}_Date.csv");
            StreamWriter writer = new StreamWriter($"Vehicules\\{plaqueImmatriculation}_Date.csv");
            foreach(string date1 in lignes ) 
            {
                if(date1 != date2)
                    writer.WriteLine(date1);
            }
            writer.Close();
        }

        public bool EstDisponible(DateTime date)
        {
            bool flag = true;
            if (ListeDatesOccupees != null && ListeDatesOccupees.Count > 0)
            {
                for (int i = 0; i < ListeDatesOccupees.Count && flag; i++)
                {
                    if (date.Date == ListeDatesOccupees[i])
                        flag = false;
                }
            }
            return flag;
        }
        #endregion
        public override string ToString()
        {
            return typeVehicule + " " + plaqueImmatriculation;
        }
        public virtual void EcritureFichier() { }
    }
}