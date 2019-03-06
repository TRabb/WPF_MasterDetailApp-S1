using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS

        public enum GenderType { none, Male, Female }
        public enum HasChildren { Yes, No}

        #endregion

        #region FIELDS

        private string _firstName;
        private string _surname;
        private string _lastName;
        private GenderType _gender;
        private string _race;
        private string _profession;
        private HasChildren _hasChildren;
        private string _childFirstName;
        private GenderType _childGender;
        private string _imageFileName;
        private string _description;

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public GenderType Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }



        public string Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }



        public HasChildren Children
        {
            get { return _hasChildren; }
            set { _hasChildren = value; }
        }



        public string ChildFirstName
        {
            get { return _childFirstName; }
            set { _childFirstName = value; }
        }



        public GenderType ChildGender
        {
            get { return _childGender; }
            set { _childGender = value; }
        }


        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageFileName; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
