using WPF_MasterDetailApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF_MasterDetailApp.Models
{
    public class ProductWindowPresenter : ObservableObject
    {

        #region ENUMS

        public enum ProductListSort
        {
            LastName,
            Age,
            AverageAnnualGross
        }

        #endregion

        #region FIELDS

        private Company _companyInfo;
        private Product _selectedProduct;
        private List<Product> _allProducts;
        private ObservableCollection<Product> _activeProducts;

        #endregion

        #region PROPERTIES

        public Company CompanyInfo
        {
            get { return _companyInfo; }
            set { _companyInfo = value; }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (_selectedProduct == value)
                {
                    return;
                }
                _selectedProduct = value;
                RaisePropertyChangedEvent("SelectedProduct");
            }
        }

        /// <summary>
        /// all products currently in the data set
        /// </summary>
        public List<Product> AllProducts
        {
            get { return _allProducts; }
            set { _allProducts = value; }
        }

        /// <summary>
        /// all products currently being displayed in the list box in the master area
        /// </summary>
        public ObservableCollection<Product> ActiveProducts
        {
            get { return _activeProducts; }
            set { _activeProducts = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public ProductWindowPresenter(Company company, List<Product> products)
        {
            _allProducts = products;
            _companyInfo = company;
            _activeProducts = new ObservableCollection<Product>(products);
        }

        #endregion

        #region METHODS

        public void QuitApplication()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// sort the active product list displayed in the master list by Last Name, Age, or Average Annual Gross
        /// </summary>
        /// <param name="productListSort">sort field</param>
        public void SortList(ProductListSort productListSort)
        {
            switch (productListSort)
            {
                case ProductListSort.LastName:
                    _activeProducts = new ObservableCollection<Product>(_activeProducts.OrderBy(c => c.LastName));
                    RaisePropertyChangedEvent("ActiveProducts");
                    break;
                case ProductListSort.Age:
                    _activeProducts = new ObservableCollection<Product>(_activeProducts.OrderBy(c => c.Age));
                    RaisePropertyChangedEvent("ActiveProducts");
                    break;
                case ProductListSort.AverageAnnualGross:
                    _activeProducts = new ObservableCollection<Product>(_activeProducts.OrderBy(c => c.AverageAnnualGross));
                    RaisePropertyChangedEvent("ActiveProducts");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// filter the active product list displayed in the master list by Last Name chosen by the user
        /// </summary>
        /// <param name="lastName"></param>
        public void FilterListLastName(string lastName)
        {
            if (lastName != "All Names")
            {
                _activeProducts = new ObservableCollection<Product>(_allProducts.Where(c => c.LastName == lastName));
            }
            else
            {
                _activeProducts = new ObservableCollection<Product>(_allProducts);
            }
            RaisePropertyChangedEvent("ActiveProducts");
        }

        /// <summary>
        /// search the Last Name in active product list displayed in the master list by the user search term
        /// </summary>
        /// <param name="searchTerm"></param>
        public void SearchListLastName(string searchTerm)
        {
            if (searchTerm != "")
            {
                _activeProducts = new ObservableCollection<Product>(_allProducts.Where(c => c.LastName.ToLower().Contains(searchTerm.ToLower())));
            }
            RaisePropertyChangedEvent("ActiveProducts");
        }

        #endregion

        #region EVENTS


        #endregion


    }
}
