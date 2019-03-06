using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS

       private Product GetProductData()
       {
            return new Product()
            {
                FirstName = "Geralt",
                Surname = "of Rivia",
                LastName = "n/a",
                Gender = Product.GenderType.Male,
                Race = "Human",
                Profession = "Witcher",
                Children = Product.HasChildren.Yes,
                ChildFirstName = "Ciri",
                ChildGender = Product.GenderType.Female,
                Description = "Geralt of Rivia was a witcher, a monster hunter for " +
                "\n hire, who possessed superhuman abilities and was" +
                "\n a master swordsman. During the Trial of the " +
                "\n Grasses, Geralt exhibited unusual tolerance for the " +
                "\n mutagens that grant witchers their abilities. " +
                "\n Accordingly, Geralt was subjected to further " +
                "\n experimental mutagens which rendered his hair " +
                "\n white and may have given him greater speed, " +
                "\n strength, and stamina than his fellow witchers.",
                ImageFileName = "GeraltPicture.jpg"
            };
       }

       private Company GetCompanyData()
       {
            Company company = new Company();

            company.Name = "Acne Agency";
            company.Address = "11 Front Street";
            company.City = "Traverse City";
                       
            return company;
       }
        #endregion

        #region EVENTS


        #endregion

    }
}
