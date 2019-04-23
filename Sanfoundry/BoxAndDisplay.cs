// SOURCE: https://www.sanfoundry.com/csharp-program-create-inputbox-display/
// AUTHOR: Sanfoundry
// FILENAME: BoxAndDisplay.cs
// PURPOSE: C# Program to Create Input Box and Display the Text.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
 
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            Console.ReadLine();
        }
      }
   }
