﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace hellenicair2
{
    partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
           
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conmanageDataSet.conmanage' table. You can move, or remove it, as needed.
            this.conmanageTableAdapter.Fill(this.conmanageDataSet.conmanage);

        }

        private void conmanageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conmanageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.conmanageDataSet);

        }

        private void flightIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Show another form.
            Form24 f2 = new Form24();
            f2.ShowDialog(this);
            linkLabel1.LinkVisited = true;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conmanageBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conmanageBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conmanageBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conmanageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.conmanageDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conmanageBindingSource.RemoveCurrent();
        }
    }
}
