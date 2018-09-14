using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCalculator : Form
    {
        private static readonly double STANDAR_FEE = 50;
        private string type;
        private string unit;
        private string weight;
        private double miles;
        private double boxPrice;
        private double cratePrice;
        private double otherPrice;
        private double basePrice;
        private double typePrice;
        private double poundPrice;
        private double kilogramPrice;
        private double weightPrice;
        private double milesPrice;
        private DistanceGetter distanceGetter;
        private Address addresses;
        private CourierHandler courierHandler;

        private void CalculateShipping()
        {

            //radio buton for type of package
            if (this.rdoBox.Checked)
            {
                
                this.type = "Box";
                typePrice = boxPrice;
            }
            else if (this.rdoCarte.Checked)
            { 
                this.type = "Crate";
                typePrice = cratePrice;
            }
            else if (this.rdoOther.Checked)
            {
                this.type = "Other";
                typePrice = otherPrice;
            }

            //radio button for dimentions
            if (this.rdoCentimeter.Checked)
            {
                this.unit = "Cm";
            }
            else if (this.rdoInch.Checked)
            {
                this.unit = "In";
            }

            //radio butons for weight
            if (this.rdoKilogram.Checked)
            {
                this.weight = "Kg";
                weightPrice = poundPrice * 0.453592;
            }
            else if (this.rdoPound.Checked)
            {
                this.weight = "lb";
                weightPrice = poundPrice;
            }

            distanceGetter = new DistanceGetter(this);
            //Console.WriteLine(DistanceGetter.GetDrivingDistanceInMiles("3501 Davie Rd, Davie, FL 33314",
            //"2300 SW 46th Ave, Fort Lauderdale, FL 33317"));

           // MessageBox.Show(Convert.ToString(DistanceGetter.GetDrivingDistanceInMiles("3501 Davie Rd, Davie, FL 33314",
                //"1000 James L Turnage Blvd, West Palm Beach, FL 33415")));
        }

        public TextBox TxtOriging
        {
            get => txtOriging;
            set => txtOriging = value;
        }

        public TextBox TxtDest
        {
            get => txtDest;
            set => txtDest = value;
        }

        public double BasePrice { get => basePrice; }
        public RadioButton RdoBox { get => rdoBox; }
        public RadioButton RdoCarte { get => rdoCarte; }
        public RadioButton RdoOther { get => rdoOther; }
        public GroupBox GrpType
        {
            get => grpType; 
        }

        //this funton display the results in the app
        private void displayResults()
        {
            txtLenght.ForeColor = Color.Black;
            txtTotalWeight.ForeColor = Color.Black;
            txtHeight.ForeColor = Color.Black;
            txtWidth.ForeColor = Color.Black;
            this.lblType.Text = type;
            lblLength.Text = txtLenght.Text;
            lblWidth.Text = txtWidth.Text;
            lblHeight.Text = txtHeight.Text;
            lblWeight.Text = txtTotalWeight.Text;
        }

        //this funtion clear the app
        public void clear()
        {
            this.lblType.Text = "";
            this.lblLength.Text = "";
            this.lblWidth.Text = "";
            this.lblHeight.Text = "";
            this.lblWeight.Text = "";
            this.lblDistance.Text = "";
            txtLenght.ForeColor = Color.LightGray;
            txtTotalWeight.ForeColor = Color.LightGray;
            txtHeight.ForeColor = Color.LightGray;
            txtWidth.ForeColor = Color.LightGray;
            txtOriging.ForeColor = Color.LightGray;
            txtDest.ForeColor = Color.LightGray;
            this.txtLenght.Text = "Lenght";
            this.txtWidth.Text = "Width";
            this.txtHeight.Text = "Height";
            this.txtTotalWeight.Text = "Total Weight";
            this.txtOriging.Text = "Origin";
            this.txtDest.Text = "Destination";
        }

        public FrmCalculator()
        {
            InitializeComponent();

            miles = 0;
            boxPrice = 1;
            cratePrice = 2;
            otherPrice = 3;
            poundPrice = .30; 
            milesPrice = .20;

            addresses = new Address(this);
            Console.WriteLine(txtOriging.AutoCompleteCustomSource.Count);
            Console.WriteLine(txtOriging.AutoCompleteCustomSource.Count);
        }

        private void rdoCarte_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShipping();
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShipping();
        }

        private void lblType_Click(object sender, EventArgs e)
        {
            displayResults();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // generate a random distance, this is only temporary

            getDistance(txtOriging.Text, txtDest.Text);
            CalculateShipping();
            displayResults();
            if (DimentionsValidation())
            {


                try
                {
                    basePrice = STANDAR_FEE * typePrice * Convert.ToDouble(txtTotalWeight.Text) * weightPrice * miles * milesPrice;

                    // create new courierHandler
                    //courierHandler = new CourierHandler(this);
                    // this output a list, use this to populate the "RESULTS" tab int he GUI
                    //courierHandler.GetSortedAndQualifiedCompanies();
                    // see output on the console
                    //Console.WriteLine(courierHandler);
                    ShowResult();
                    addresses.AddNewAddressesSuggestions();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, check all imput is in the correct format and radio buttons are checked.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                    clear();
                    ResetTextBoxesText();

                }
            }else
            {
                MessageBox.Show("Erro, No #0 or negative amount on the dimentions", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void rdoBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShipping();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to Exit ?", "Exit", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void rdoCentimeter_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShipping();
        }

        private void rdoInch_CheckedChanged(object sender, EventArgs e)
        {
            CalculateShipping();
        }

        private void lblWeight_Click(object sender, EventArgs e)
        {
           
        }

        private void getDistance(string origin, string destination)
        {
            //Random rnd = new Random();
            // miles = rnd.Next(1, 3000);
            miles = distanceGetter.GetDrivingDistanceInMiles(origin, destination);

            if (txtOriging.Text != null && txtOriging.Text != "Origin" && 
                txtDest.Text != null && txtDest.Text != "Destination")
            {
                lblDistance.Text = "Distance:\n" + Convert.ToString(miles) + " miles";
            }
            else
            {
                MessageBox.Show("Enter Origin and Destination addresses.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLength_Click(object sender, EventArgs e)
        {
           
        }

        private void txtLenght_TextChanged(object sender, EventArgs e)
        {
            txtLenght.ForeColor = Color.Black;
        }

        //the enter events clear the textboxes when trying to add imput value
        //C# How To Set PlaceHolder String to TextBox
        private void txtLenght_Enter(object sender, EventArgs e)
        {
            if (txtLenght.Text == "Lenght")
            {
                //txtLenght.Text = String.Empty;
                txtLenght.Text = "";
            }
            ResetTextBoxesText();
        }

        private void txtWidth_Enter(object sender, EventArgs e)
        {
            if (txtWidth.Text == "Width")
            {
                txtWidth.Text = "";
            }
            ResetTextBoxesText();
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            if (txtHeight.Text == "Height")
            {
                txtHeight.Text = "";
            }
            ResetTextBoxesText();
        }

        private void txtTotalWeight_Enter(object sender, EventArgs e)
        {
            if (txtTotalWeight.Text == "Total Weight")
            {
                txtTotalWeight.Text = "";
            }
            ResetTextBoxesText();
        }

        private void txtOriging_Enter(object sender, EventArgs e)
        {
            if (txtOriging.Text == "Origin")
            {
                txtOriging.Text = "";
            }
            ResetTextBoxesText();
        }

        private void txtDest_Enter(object sender, EventArgs e)
        {
            if (txtDest.Text == "Destination")
            {
                txtDest.Text = "";
            }
            ResetTextBoxesText();
        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }

        public void ResetTextBoxesText()
        {
            List<TextBox> txtBoxes = new List<TextBox>();
            List<string> txtBoxesDefaultStrings = new List<string>();
            txtBoxes.Add(txtOriging);
            txtBoxes.Add(txtDest);
            txtBoxes.Add(txtLenght);
            txtBoxes.Add(txtWidth);
            txtBoxes.Add(txtHeight);
            txtBoxes.Add(txtTotalWeight);
            txtBoxesDefaultStrings.Add("Origin");
            txtBoxesDefaultStrings.Add("Destination");
            txtBoxesDefaultStrings.Add("Lenght");
            txtBoxesDefaultStrings.Add("Width");
            txtBoxesDefaultStrings.Add("Height");
            txtBoxesDefaultStrings.Add("Total Weight");

            for (int i = 0; i < txtBoxes.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(txtBoxes[i].Text) &&
                    !txtBoxes[i].Focused)
                {
                    txtBoxes[i].Text = txtBoxesDefaultStrings[i];
                }
            }
        }

        private void txtOriging_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtOriging_TextChanged_1(object sender, EventArgs e)
        {
            txtOriging.ForeColor = Color.Black;
          
        }

        private void txtDest_TextChanged(object sender, EventArgs e)
        {
            txtDest.ForeColor = Color.Black;
        }

        private void txtDest_TextChanged_1(object sender, EventArgs e)
        {
            txtDest.ForeColor = Color.Black;
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            txtWidth.ForeColor = Color.Black;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            txtHeight.ForeColor = Color.Black;
        }

        private void txtTotalWeight_TextChanged(object sender, EventArgs e)
        {
            txtTotalWeight.ForeColor = Color.Black;
        }

        private void ShowResult()
        {
            

            courierHandler = new CourierHandler(this);
            List<Company> sortedAndQualifiedCompanies = courierHandler.GetSortedAndQualifiedCompanies();
            List<Label> lblNameList = new List<Label>();
            List<PictureBox> picLogoList = new List<PictureBox>();
            List<Label> lblPriceList = new List<Label>();

            lblNameList.Add(lbl1stCompany);
            lblNameList.Add(lbl2ndCompany);
            lblNameList.Add(lbl3rdCompany);

            picLogoList.Add(pictureBox1);
            picLogoList.Add(pictureBox2);
            picLogoList.Add(pictureBox3);

            lblPriceList.Add(lbl1stPrice);
            lblPriceList.Add(lbl2ndPrice);
            lblPriceList.Add(lbl3rdPrice);

            for (int i = 0; i < courierLogoList.Images.Count; i++)
            {
                if (i <= (sortedAndQualifiedCompanies.Count - 1))
                {
                    /*if (sortedAndQualifiedCompanies[i].Name.Equals("UPS"))
                    {
                        lblNameList[i].Text = sortedAndQualifiedCompanies[i].Name;
                        picLogoList[i].Image = courierLogoList.Images[0];
                        lblPriceList[i].Text = sortedAndQualifiedCompanies[i].Price().ToString("C");
                    }

                    if (sortedAndQualifiedCompanies[i].Name.Equals("DHL"))
                    {
                        lblNameList[i].Text = sortedAndQualifiedCompanies[i].Name;
                        picLogoList[i].Image = courierLogoList.Images[1];
                        lblPriceList[i].Text = sortedAndQualifiedCompanies[i].Price().ToString("C");
                    }

                    if (sortedAndQualifiedCompanies[i].Name.Equals("USPS"))
                    {
                        lblNameList[i].Text = sortedAndQualifiedCompanies[i].Name;
                        picLogoList[i].Image = courierLogoList.Images[2];
                        lblPriceList[i].Text = sortedAndQualifiedCompanies[i].Price().ToString("C");
                    }*/
                
                    
                    // this match company logo with it's corresponding name and price result
                    foreach (var name in courierHandler.getUnsortedNames())
                    {
                        if (sortedAndQualifiedCompanies[i].Name.Equals(name))
                        {
                            lblNameList[i].Text = sortedAndQualifiedCompanies[i].Name;
                            lblPriceList[i].Text = sortedAndQualifiedCompanies[i].Price().ToString("C");

                            for (int j = 0; j < courierLogoList.Images.Count; j++)
                            {
                                if ((name.ToLower() + ".png").Equals(courierLogoList.Images.Keys[j]))
                                {
                                    picLogoList[i].Image = courierLogoList.Images[j];
                                }
                            }
                        }
                    }
                }
                else
                {
                    lblNameList[i].Text = null;
                    picLogoList[i].Image = null;
                    lblPriceList[i].Text = null;
                }
            }
            // result out put in the console
            Console.WriteLine(courierHandler);
            // switch to the RESULTS tab
            tabControl.SelectedIndex = 1;
        }

        //this is the validation for negative amounts on the dimentions text boxes
        private Boolean DimentionsValidation()
        {
            try
            {
                if (Convert.ToDouble(txtHeight.Text) <= 0 || Convert.ToDouble(txtWidth.Text) <= 0 || Convert.ToDouble(txtTotalWeight.Text) <= 0 || Convert.ToDouble(txtLenght.Text) <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, Only digits allow on the dimentions text boxes", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
                return false;
            }
        }

    }
}

