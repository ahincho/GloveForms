﻿
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloveInterfaces;

namespace GloveClasses
{

    #pragma warning disable CS8618
    public class Diagnosis : Recordable
    {

        // Attributes of Diagnosis Class

        private static string Table = "Diagnostico";
        private string Name;
        private string Description;
        private int CurrentStatus;
        private static List<string> Fields = new List<string>() { "DiagNombre", "DiagDescripcion", "DiagEstado" };
        private List<string> DataSummary = new List<string>();

        // Class Constructors

        public Diagnosis(string name, string description, int currentStatus)
        {
            setName(name);
            setDescription(description);
            setCurrentStatus(currentStatus);
        }

        // Setters for Diagnosis Class

        public void setName(string name)
        {
            this.Name = name;
            this.DataSummary.Add("'" + name.ToString() + "'");
        }

        public void setDescription(string description)
        {
            this.Description = description;
            this.DataSummary.Add("'" + description.ToString() + "'");
        }

        public void setCurrentStatus(int currentStatus)
        {
            this.CurrentStatus = currentStatus;
            this.DataSummary.Add(currentStatus.ToString());
        }

        // Setters for Diagnosis Class

        public string getName()
        {
            return this.Name;
        }

        public string getDescription()
        {
            return this.Description;
        }

        public int getCurrentStatus()
        {
            return this.CurrentStatus;
        }

        private List<string> getDataSummary()
        {
            return this.DataSummary;
        }

        private static List<string> getFields()
        {
            return Diagnosis.Fields;
        }

        // Method which returns the name of the table associated

        public string getTableName()
        {
            return Diagnosis.Table;
        }


        // Method to concatenate all the Class Fields. Useful when
        // we need to do a query and need to enum the fields of the table

        public string getFieldsWithCommas()
        {
            return string.Join<Object>(",", getFields());
        }

        // Method to concatenate all the Class Data
        // Useful when we need to insert this object in the Database

        public string mergedWithCommas()
        {
            string merged = string.Join<Object>(", ", getDataSummary());
            return merged;
        }

    }

}