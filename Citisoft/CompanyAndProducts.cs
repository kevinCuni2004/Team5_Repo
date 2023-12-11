using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citisoft
{
    public class CompanyAndProducts
    {
        private int _companyId;
        private int CompanyId { get { return _companyId; } set {_companyId = value; } }
        private int _productId;
        private int ProductId { get { return _productId; } set { _productId = value; } }
        private string _description;
        private string Description { get { return _description; } set { _description = value; } }
        private string _cloud;
        private string Cloud { get { return _cloud; } set { _cloud = value; } }
        private string _companyName;
        private string CompanyName { get { return _companyName; } set { _companyName = value; } }
        private DateTime _dateJoined;
        private DateTime DateJoined { get { return _dateJoined; } set { _dateJoined = value; } }
        private DateTime _lastReviewedDate;
        private DateTime LastReviwedDate { get { return _lastReviewedDate; } set { _lastReviewedDate = value; } }
        private DateTime _lastDemoDate;
        private DateTime LastDemoDate { get { return _lastDemoDate ; } set { _lastDemoDate = value; } }
        private DateTime _establishedDate;
        private DateTime EstablishedDate { get { return _establishedDate; } set { _establishedDate = value; } }
        private string _internalProfessionalServices;
        private string InternalProfessionalServices { get { return _internalProfessionalServices; } set { _internalProfessionalServices = value; } }
        private string _companyWebsite;
        private string CompanyWebsite { get { return _companyWebsite; } set { _companyWebsite = value; } }
        private int _noOfEmployees;
        private int NoOfEmployees { get { return _noOfEmployees; } set { _noOfEmployees = value; } }
        public CompanyAndProducts(string name)
        {
            this._companyName = name;
        }

        public SearchVendors SearchVendors
        {
            get => default;
            set
            {
            }
        }
    }
}
