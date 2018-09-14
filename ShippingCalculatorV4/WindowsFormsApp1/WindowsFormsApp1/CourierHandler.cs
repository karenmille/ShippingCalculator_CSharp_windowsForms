using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class CourierHandler
    {
        private FrmCalculator frmCalculator;
        private List<Company> companies;
        private List<Company> sortedAndQualifiedCompanies;
        private List<Company> unqualifiedCompanies;
        List<string> nameList = new List<string>();
        List<Boolean> shipsBoxList = new List<Boolean>();
        List<Boolean> shipsCrateList = new List<Boolean>();
        List<Boolean> shipsOtherList = new List<Boolean>();
        List<Int32> priceMultiplierList = new List<Int32>();
        OleDbConnection dbConnect;
        OleDbCommand dbCommand;
        OleDbDataReader dbReader;

        public CourierHandler(FrmCalculator frmCalculator)
        {
            this.frmCalculator = frmCalculator;
            unqualifiedCompanies = new List<Company>();

            OpenConnection();
            CreateCommand();
            ReadInData();

            companies = new List<Company>
            {
                // these are our three companies
                new Courier(nameList[0], frmCalculator.BasePrice, shipsBoxList[0], shipsCrateList[0], shipsOtherList[0], priceMultiplierList[0]),
                new Courier(nameList[1], frmCalculator.BasePrice, shipsBoxList[1], shipsCrateList[1], shipsOtherList[1], priceMultiplierList[1]),
                new Courier(nameList[2], frmCalculator.BasePrice, shipsBoxList[2], shipsCrateList[2], shipsOtherList[2], priceMultiplierList[2])
            };
        }

        void OpenConnection()
        {
            string sConnection;
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb";
            dbConnect = new OleDbConnection(sConnection);
            dbConnect.Open();
        }

        void CreateCommand()
        {
            string sql;
            sql = "SELECT * FROM CourierData";
            dbCommand = new OleDbCommand();
            dbCommand.CommandText = sql;
            dbCommand.Connection = dbConnect;
        }

        void ReadInData()
        {
            nameList.Clear();
            //string myname;
            dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                //myname = dbReader["name"].ToString();
                nameList.Add(dbReader["name"].ToString());
                shipsBoxList.Add((bool) dbReader["shipsBox"]);
                shipsCrateList.Add((bool)dbReader["shipsCrate"]);
                shipsOtherList.Add((bool)dbReader["shipsOther"]);
                priceMultiplierList.Add((Int32) dbReader["priceMultiplier"]);
            }
            dbReader.Close();
            dbConnect.Close();

            /*Console.WriteLine("CourierAllData");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("shipsBoxList");
            foreach (Boolean name in shipsBoxList)
            {
                Console.WriteLine(name);
            }*/
        }

        public List<Company> GetSortedAndQualifiedCompanies()
        {
            sortedAndQualifiedCompanies = RemoveUncalifiedCompanies(SortByPrice(companies));
            return sortedAndQualifiedCompanies;
        }

        private List<Company> SortByPrice(List<Company> companies)
        {
            // sort companies by price, from lowerst to highest
            return companies.OrderBy(o => o.Price()).ToList();
        }

        private List<Company> RemoveUncalifiedCompanies(List<Company> companies)
        {
            // form remove any company that doesn't ship the type of cargo selected in the GUI
            List<Company> qualifiedCompanies = new List<Company>();

            // check radio button for the cargo type
            foreach (var company in companies)
            {
                var courier = (Courier) company;

                if (frmCalculator.RdoBox.Checked && courier.ShipsBox)
                {
                    qualifiedCompanies.Add(courier);
                }
                else if (frmCalculator.RdoCarte.Checked && courier.ShipsCrate)
                {
                    qualifiedCompanies.Add(courier);
                }
                else if (frmCalculator.RdoOther.Checked && courier.ShipsSpecial)
                {
                    qualifiedCompanies.Add(courier);
                }
            }

            return qualifiedCompanies;
        }

        private void getUnqualifiedCompanies()
        {
            // return any company that is not in the qualifiedCompanies list
            foreach (Company company in companies)
            {
                var courier = (Courier) company;
                if (!sortedAndQualifiedCompanies.Contains(courier))
                {
                    unqualifiedCompanies.Add(courier);
                }
            }
        }

        public override string ToString()
        {
            // Overrode ToString method
            StringBuilder sb = new StringBuilder();

            sb.AppendLine().Append("Qualified Companies and Sorted By Price").AppendLine().
                Append("---------------------------------------").AppendLine();
            foreach (var company in sortedAndQualifiedCompanies)
            {
                var coursier = (Courier)company;
                sb.Append(coursier).AppendLine();
            }

            sb.AppendLine().Append("Unqualified Companies").AppendLine().
                Append("---------------------------------------").AppendLine();
            getUnqualifiedCompanies();
            foreach (var company in unqualifiedCompanies)
            {
                var coursier = (Courier)company;
                sb.Append(coursier).AppendLine();
            }

            return sb.ToString();
        }

        public List<string> getUnsortedNames()
        {
            List<string> unsortedNames = new List<string>();

            foreach (var company in companies)
            {
                var coursier = (Courier)company;
                unsortedNames.Add(coursier.Name);
            }

            return unsortedNames;
        }
    }
}
