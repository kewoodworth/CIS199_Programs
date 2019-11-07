// Program 3
// CIS 199-75
// Due: 3/8/2018
// By: Y8021

// This application calculates the earliest registration date
// and time for an undergraduate student given their class standing
// and last name.
// Decisions based on UofL Summer/Fall 2018 Priority Registration Schedule

// Solution 3
// This solution keeps the first letter of the last name as a char
// and uses if/else logic for the times.
// It uses defined strings for the dates and times to make it easier
// to maintain.
// It only uses programming elements introduced in the text or
// in class.
// This solution takes advantage of the fact that there really are
// only two different time patterns used. One for juniors and seniors
// and one for sophomores and freshmen. The pattern for sophomores
// and freshmen is complicated by the fact the certain letter ranges
// get one date and other letter ranges get another date.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "March 28"; // 1st day of registration
            const string DAY2 = "March 29"; // 2nd day of registration
            const string DAY3 = "March 30"; // 3rd day of registration
            const string DAY4 = "April 2";  // 4th day of registration
            const string DAY5 = "April 3";  // 5th day of registration
            const string DAY6 = "April 4";  // 6th day of registration

            const string TIME1 = "8:30 AM";  // 1st time block
            const string TIME2 = "10:00 AM"; // 2nd time block
            const string TIME3 = "11:30 AM"; // 3rd time block
            const string TIME4 = "2:00 PM";  // 4th time block
            const string TIME5 = "4:00 PM";  // 5th time block

            const float SOPHOMORE = 30; // Hours needed to be sophomore
            const float JUNIOR = 60;    // Hours needed to be junior
            const float SENIOR = 90;    // Hours needed to be senior

            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?
            bool found = false;         // Has the correct time been found in array?

            string[] timeBlocksJrSr = { TIME1, TIME2, TIME3, TIME4, TIME5 };                                            //  Upper classmen time blocks array
            char[] lastNamesJrSr = { 'A', 'E', 'J', 'P', 'T' };                                                         //  Upper classmen name array
            string[] timeBlocksUnderclass = { TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5 };   // Under classmen time blocks array
            char[] lastNamesUnderclass = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };                          //  Under classmen name array

            int indexJrSr = lastNamesJrSr.Length - 1;               // Upper classmen index 
            int indexUnder = lastNamesUnderclass.Length - 1;        // Under classmen index

            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (float.TryParse(creditHoursTxt.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= JUNIOR);

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            if (creditHours >= SENIOR)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;

                            while (indexJrSr >= 0 && !found)
                            {
                                if (lastNameLetterCh >= lastNamesJrSr[indexJrSr])
                                    found = true;
                                else
                                    --indexJrSr;
                            }
                            if (found)
                            {
                                timeStr = timeBlocksJrSr[indexJrSr];
                            }
                        }

                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE)
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }

                            while (indexUnder >= 0 && !found)
                            {
                                if (lastNameLetterCh >= lastNamesUnderclass[indexUnder])
                                    found = true;
                                else
                                    --indexUnder;
                            }
                            if (found)
                            {
                                timeStr = timeBlocksUnderclass[indexUnder];
                            }
                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // Not A-Z
                        MessageBox.Show("Make sure last name starts with a letter!");
                }
                else
                    MessageBox.Show("Enter a valid number of credit hours!");
            }
            else // Empty textbox
                MessageBox.Show("Please enter last name!");
        }
    }
}
