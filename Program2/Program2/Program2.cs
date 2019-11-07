/* Y8021
 * CIS 199-75 Program 2
 * Due Tuesday, March 6
 * Requests credit hours and first letter of last name from student
 * Returns registration date and time
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Program2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        //  Input accepted
        private void enterButton_Click(object sender, EventArgs e)
        {
            float creditHours;      //  Establishes variable creditHours as float
            char lastName;          //  Establishes variable lastName as char
            bool isChar;            //  Establishes variable isChar as bool

            //  Establishes variables for this year's registration dates and times
            string seniorDate = "Wednesday, March 28",      //  Senior registration date
                   juniorDate = "Thursday, March 29",       //  Junior regisration date
                   sophomoreDateAL = "Friday, March 30",    //  Sophomores A-L registration date
                   sophomoreDateMZ = "Monday, April 2",     //  Sophomores M-Z regisration date
                   freshmanDateAL = "Tuesday, April 3",     //  Freshmen A-L registration date
                   freshmanDateMZ = "Wednesday, April 4",   //  Freshmen M-Z registration date
                   round1 = "8:30 a.m.",
                   round2 = "10:00 a.m.",
                   round3 = "11:30 a.m.",
                   round4 = "2:00 p.m.",
                   round5 = "4:00 p.m.";

            const float SENIOR = 90;        //  Credit floor for Seniors
            const float JUNIOR = 60;        //  Credit floor for Juniors
            const float SOPHOMORE = 30;     //  Credit floor for Sophomores

            creditHours = float.Parse(creditHoursBox.Text);     //  Assigns value for creditHours
            lastName = char.Parse(lastNameBox.Text);            //  Assigns value for lastName
            isChar = char.IsLetter(lastName);                   //  Tests if lastName input is a letter

            //  Checks for valid creditHours input
            if (float.TryParse(creditHoursBox.Text, out creditHours) && creditHours > 0)
            {
                //  If the lastName input is a letter
                if (isChar == true)
                {
                    lastName = char.ToUpper(lastName);  //  Convert lastName to uppercase

                    //  Seniors
                    if (creditHours >= SENIOR)
                    {
                        if (lastName <= 'D')
                            registrationDateLabel.Text = $"{seniorDate}\n{round1}";
                        else
                        if (lastName <= 'I')
                            registrationDateLabel.Text = $"{seniorDate}\n{round2}";
                        else
                        if (lastName <= 'O')
                            registrationDateLabel.Text = $"{seniorDate}\n{round3}";
                        else
                        if (lastName <= 'S')
                            registrationDateLabel.Text = $"{seniorDate}\n{round4}";
                        else
                            registrationDateLabel.Text = $"{seniorDate}\n{round5}";
                    }

                    //  Juniors
                    else
                    if (creditHours >= JUNIOR)
                    {
                        if (lastName <= 'D')
                            registrationDateLabel.Text = $"{juniorDate}\n{round1}";
                        else
                        if (lastName <= 'I')
                            registrationDateLabel.Text = $"{juniorDate}\n{round2}";
                        else
                        if (lastName <= 'O')
                            registrationDateLabel.Text = $"{juniorDate}\n{round3}";
                        else
                        if (lastName <= 'S')
                            registrationDateLabel.Text = $"{juniorDate}\n{round4}";
                        else
                            registrationDateLabel.Text = $"{juniorDate}\n{round5}";
                    }

                    //  Sophomores
                    else
                    if (creditHours >= SOPHOMORE)
                    {
                        if (lastName <= 'B')
                            registrationDateLabel.Text = $"{sophomoreDateAL}\n{round1}";
                        else
                        if (lastName <= 'D')
                            registrationDateLabel.Text = $"{sophomoreDateAL}\n{round2}";
                        else
                        if (lastName <= 'F')
                            registrationDateLabel.Text = $"{sophomoreDateAL}\n{round3}";
                        else
                        if (lastName <= 'I')
                            registrationDateLabel.Text = $"{sophomoreDateAL}\n{round4}";
                        else
                        if (lastName <= 'L')
                            registrationDateLabel.Text = $"{sophomoreDateAL}\n{round5}";
                        else
                        if (lastName <= 'O')
                            registrationDateLabel.Text = $"{sophomoreDateMZ}\n{round1}";
                        else
                        if (lastName <= 'Q')
                            registrationDateLabel.Text = $"{sophomoreDateMZ}\n{round2}";
                        else
                        if (lastName <= 'S')
                            registrationDateLabel.Text = $"{sophomoreDateMZ}\n{round3}";
                        else
                        if (lastName <= 'V')
                            registrationDateLabel.Text = $"{sophomoreDateMZ}\n{round4}";
                        else
                            registrationDateLabel.Text = $"{sophomoreDateMZ}\n{round5}";
                    }

                    //  Freshmen
                    else
                    if (creditHours < SOPHOMORE)
                    {
                        if (lastName <= 'B')
                        registrationDateLabel.Text = $"{freshmanDateAL}\n{round1}";
                        else
                        if (lastName <= 'D')
                            registrationDateLabel.Text = $"{freshmanDateAL}\n{round2}";
                        else
                        if (lastName <= 'F')
                            registrationDateLabel.Text = $"{freshmanDateAL}\n{round3}";
                        else
                        if (lastName <= 'I')
                            registrationDateLabel.Text = $"{freshmanDateAL}\n{round4}";
                        else
                        if (lastName <= 'L')
                            registrationDateLabel.Text = $"{freshmanDateAL}\n{round5}";
                        else
                        if (lastName <= 'O')
                            registrationDateLabel.Text = $"{freshmanDateMZ}\n{round1}";
                        else
                        if (lastName <= 'Q')
                            registrationDateLabel.Text = $"{freshmanDateMZ}\n{round2}";
                        else
                        if (lastName <= 'S')
                            registrationDateLabel.Text = $"{freshmanDateMZ}\n{round3}";
                        else
                        if (lastName <= 'V')
                            registrationDateLabel.Text = $"{freshmanDateMZ}\n{round4}";
                        else
                            registrationDateLabel.Text = $"{freshmanDateMZ}\n{round5}";
                    }
                }
                else  //  Displays message box if valid last name character not entered
                    MessageBox.Show("Please enter only the first letter of your last name.");
            }
            else  //  Displays message box if valid credit hours are not entered
                MessageBox.Show("Please enter your cumulative total of credit hours.");
        }
    }
}
