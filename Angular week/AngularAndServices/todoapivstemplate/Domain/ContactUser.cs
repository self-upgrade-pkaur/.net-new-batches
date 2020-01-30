﻿using System;

namespace Domain
{
    public class ContactUser
    {
        /// <summary>
        /// ID with default as zero means no value returned
        /// </summary>
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        private string firstName;
        public string MiddleName { get; set; }
        private string lastName;
        private string mobile;
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public String Email { get; set; }
        public DateTime? Modified { get; set; }
        public string FirstName
        {
            get => firstName; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("first name cannot be empty ");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("last name cannot be empty ");
                }
                lastName = value;
            }
        }

        public string Mobile
        {
            get => mobile; set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone cannot be Empty");
                }
                mobile = value;
            }
        }
        /// <summary>
        /// This method is used to get full name of the user
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="mName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>

        public string GetName(string fName, string mName, string lName)
        {
            return $"{fName} {mName} {lName}";
        }
    }
}
